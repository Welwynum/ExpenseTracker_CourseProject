﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTracker
{
     class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";


        public int ID { set; get; } //0
        public string Category { set; get; }//1
        public string Status { set; get; }//2
        public string Date { set; get; }//3


        public List<CategoryData> categoryListData()
        {

            List<CategoryData> listData= new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(stringConnection)) {

                connect.Open();
                string selectData = "SELECT * FROM categories";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        } 

    }
}
