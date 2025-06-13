using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.IO;


namespace ExpenseTracker
{
    public partial class BudgetForm : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";

        private int getID = 0;

        public BudgetForm()
        {
            InitializeComponent();
            LoadCategoryComboBox();
            LoadBudgetData();
            LoadBudgetPieChart();
            LoadBudgetVsSpendingChart();
        }

        private void LoadCategoryComboBox()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, category FROM categories WHERE status = 'active'", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                budgetCategory.DisplayMember = "category";
                budgetCategory.ValueMember = "id";
                budgetCategory.DataSource = dt;
                budgetCategory.SelectedIndex = -1;

                connect.Close();
            }
        }

        private void LoadBudgetData()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"
                    SELECT b.Id, c.category AS CategoryName, b.Type, b.Amount 
                    FROM Budgets b
                    INNER JOIN categories c ON b.category_id = c.id", connect);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                budgetDataGridView.DataSource = dt;
                connect.Close();
            }
        }

       

        private void ClearFields()
        {
            budgetCategory.SelectedIndex = -1;
            budgetType.SelectedIndex = -1;
            budgetAmount.Text = "";
            getID = 0;
        }

        private void LoadBudgetPieChart()
        {
            chartBudget.Series.Clear();
            chartBudget.Titles.Clear();
            chartBudget.Titles.Add("Budget by Category");

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT c.category, SUM(b.Amount) AS Total 
                    FROM Budgets b
                    INNER JOIN categories c ON b.category_id = c.id
                    GROUP BY c.category", connect);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    series.Points.AddXY(reader["category"].ToString(), Convert.ToDecimal(reader["Total"]));
                }
                connect.Close();
            }

            chartBudget.Series.Add(series);
        }


        private void LoadBudgetVsSpendingChart()
        {
            barChartBudget.Series.Clear();
            barChartBudget.Titles.Clear();
            barChartBudget.Titles.Add("Budget vs Expenses by Category");

            Series series = new Series("Budget")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            Series seriesExpenses = new Series("Expenses")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                //  Get BUDGETS per category
                string queryBudgets = @"
            SELECT c.category, SUM(b.Amount) AS BudgetTotal
            FROM Budgets b
            JOIN categories c ON b.category_id = c.id
            GROUP BY c.category";
                SqlCommand cmd = new SqlCommand(queryBudgets, connect);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, decimal> budgetData = new Dictionary<string, decimal>();
                while (reader.Read())
                {
                    string category = reader["category"].ToString();
                    decimal budgetAmount = Convert.ToDecimal(reader["BudgetTotal"]);
                    budgetData[category] = budgetAmount;
                }
                reader.Close();

                // Get EXPENSES per category
                string queryExpenses = @"
            SELECT c.category, SUM(e.price) AS ExpenseTotal
            FROM expenses e
            JOIN categories c ON e.category_id = c.id
            GROUP BY c.category";
                SqlCommand cmd2 = new SqlCommand(queryExpenses, connect);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                Dictionary<string, decimal> expenseData = new Dictionary<string, decimal>();
                while (reader2.Read())
                {
                    string category = reader2["category"].ToString();
                    decimal expenseAmount = Convert.ToDecimal(reader2["ExpenseTotal"]);
                    expenseData[category] = expenseAmount;
                }
                reader2.Close();

                // Combine and render chart
                var allCategories = budgetData.Keys.Concat(expenseData.Keys).Distinct();

                foreach (var category in allCategories)
                {
                    decimal budget = budgetData.ContainsKey(category) ? budgetData[category] : 0;
                    decimal expense = expenseData.ContainsKey(category) ? expenseData[category] : 0;

                    series.Points.AddXY(category, budget);
                    seriesExpenses.Points.AddXY(category, expense);
                }

                barChartBudget.Series.Add(series);
                barChartBudget.Series.Add(seriesExpenses);
            }
        }





        private void ClearBudget_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddBudget_Click_1(object sender, EventArgs e)
        {
            if (budgetCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(budgetAmount.Text) || budgetType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string insertQuery = "INSERT INTO Budgets (category_id, Type, Amount) VALUES (@catId, @type, @amount)";
                SqlCommand cmd = new SqlCommand(insertQuery, connect);
                cmd.Parameters.AddWithValue("@catId", Convert.ToInt32(budgetCategory.SelectedValue));
                cmd.Parameters.AddWithValue("@type", budgetType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(budgetAmount.Text));
                cmd.ExecuteNonQuery();
                connect.Close();
            }
 

            LoadBudgetData();
            LoadBudgetPieChart();
            LoadBudgetVsSpendingChart();
            ClearFields();
            MessageBox.Show("Budget added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void budgetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = budgetDataGridView.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                string categoryName = row.Cells[1].Value.ToString();


                for (int i = 0; i < budgetCategory.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)budgetCategory.Items[i];
                    if (item["category"].ToString() == categoryName)
                    {
                        budgetCategory.SelectedIndex = i;
                        break;
                    }
                }

                budgetType.SelectedItem = row.Cells[2].Value.ToString();
                budgetAmount.Text = row.Cells[3].Value.ToString();
            }
        }

        private void UpdateBudget_Click_1(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a budget to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string updateQuery = "UPDATE Budgets SET category_id = @catId, Type = @type, Amount = @amount WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, connect);
                cmd.Parameters.AddWithValue("@catId", Convert.ToInt32(budgetCategory.SelectedValue));
                cmd.Parameters.AddWithValue("@type", budgetType.SelectedItem);
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(budgetAmount.Text));
                cmd.Parameters.AddWithValue("@id", getID);
                cmd.ExecuteNonQuery();
                connect.Close();
            }

            LoadBudgetData();
            LoadBudgetPieChart();
            LoadBudgetVsSpendingChart();
            ClearFields();
            MessageBox.Show("Budget updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteBudget_Click_1(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a budget to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string deleteQuery = "DELETE FROM Budgets WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(deleteQuery, connect);
                cmd.Parameters.AddWithValue("@id", getID);
                cmd.ExecuteNonQuery();
                connect.Close();
            }

            LoadBudgetData();
            LoadBudgetPieChart();
            LoadBudgetVsSpendingChart();
            ClearFields();
            MessageBox.Show("Budget deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Chart BarChartBudget
        {
            get { return barChartBudget; }
        }


    }

}
