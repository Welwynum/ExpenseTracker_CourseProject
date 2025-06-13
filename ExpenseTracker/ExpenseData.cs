using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    internal class ExpenseData
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";


        public int ID { set; get; } 
        public string Category { set; get; }
        public string Item { set; get; }
        public string Price { set; get; }
        public string Description { set; get; }
        public string DateExpense { set; get; }

        public List<ExpenseData> expenseListData()
        {

            List<ExpenseData> listData = new List<ExpenseData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();
                string selectData = "SELECT * FROM expenses";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpenseData eData = new ExpenseData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Price = reader["price"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateExpense = ((DateTime)reader["date_expense"]).ToString("dd-MM-yyyy");

                        listData.Add(eData);
                    }
                }
            }
            return listData;
        }
    }
}
