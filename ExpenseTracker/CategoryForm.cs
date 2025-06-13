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
    public partial class CategoryForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }
        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.categoryListData();

            dataGridView1.DataSource = listData;
            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "DD-MM-YYYY";
        } 
        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1 )
            {
                MessageBox.Show("Please fill in all of the fields before proceeding", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories(category, status, date_insert)" +
                        "VALUES (@cat, @status, @date)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect)) {

                        cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Category added successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayCategoryList();
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_status.SelectedItem = row.Cells[2].Value.ToString();
               
            }
        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE categories SET category = @cat, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category updated successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }

               
            }
            displayCategoryList();
        }


        public void clearFields()
        {
            category_category.Text = "";
            category_status.SelectedIndex = -1;
        }
        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1)
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

                        string updateData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                           
                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Category deleted successfullly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }


            }
            displayCategoryList();
        }
    }
}
