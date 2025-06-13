using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    public partial class ExpenseForm : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";

        public ExpenseForm()
        {
            InitializeComponent();
            DisplayCategoryList();
            displayExpenseData();
            LoadCategoriesIntoComboBox();

        }
        public void displayExpenseData()
        {
            ExpenseData eData = new ExpenseData();
            List<ExpenseData> listData = eData.expenseListData();

            dataGridView1.DataSource = listData;

        }
        private void LoadCategoriesIntoComboBox()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, category FROM categories", connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                expense_category.DataSource = dt;
                expense_category.DisplayMember = "category";  // what user sees
                expense_category.ValueMember = "id";          // what gets stored
            }
        }

        public void DisplayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Active");

                    expense_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        expense_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }
        private void expense_addBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_price.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please fill in all of the fields before proceeding", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = @"INSERT INTO expenses (item, price, description, date_expense, date_insert, category_id) 
               VALUES (@item, @price, @description, @date_expense, @date_insert, @category_id)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {

                        int categoryId = Convert.ToInt32(expense_category.SelectedValue);
                        cmd.Parameters.AddWithValue("@category_id", categoryId);

                        cmd.Parameters.AddWithValue("@item", expense_item.Text);
                        cmd.Parameters.AddWithValue("@price", expense_price.Text);
                        cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();


                        MessageBox.Show("Expense added successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
                displayExpenseData();
            }
        }
        public void clearFields()
        {
            expense_category.SelectedIndex = -1;
            expense_item.Text = "";
            expense_price.Text = "";
            expense_description.Text = "";
        }
        private void expense_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updateBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_price.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "UPDATE expenses SET category = @cat, item = @item, price = @price, description = @desc, date_expense = @date_ex WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {

                            cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expense_item.Text);
                            cmd.Parameters.AddWithValue("@price", expense_price.Text);
                            cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                            cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();


                            MessageBox.Show("Expense updated successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connect.Close();
                    }
                }
                displayExpenseData();
            }
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_price.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                expense_date.Value = Convert.ToDateTime( row.Cells[5].Value.ToString());
            } 
        }

        private void expense_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_price.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select a category first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Expense deleted successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }


            }
            displayExpenseData();
        }
    }
}

