using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            dashboardForm1.Initialize(budgetForm1);
        }



        private void close1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave the application?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            budgetForm1.Visible = false;
            expenseForm1.Visible = false;
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            budgetForm1.Visible = false;
            expenseForm1.Visible = false;
        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            budgetForm1.Visible = false;
            expenseForm1.Visible = true;
        }

        private void budget_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            budgetForm1.Visible = true;
            expenseForm1.Visible = false;
        }
    }
}
