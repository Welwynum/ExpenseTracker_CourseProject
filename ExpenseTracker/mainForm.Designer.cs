namespace ExpenseTracker
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.budget_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new ExpenseTracker.DashboardForm();
            this.budgetForm1 = new ExpenseTracker.BudgetForm();
            this.expenseForm1 = new ExpenseTracker.ExpenseForm();
            this.categoryForm1 = new ExpenseTracker.CategoryForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1369, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 19);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 45);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.Screenshot_2025_05_26_152355;
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expense Tracker";
            // 
            // close1
            // 
            this.close1.AutoSize = true;
            this.close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close1.Location = new System.Drawing.Point(1369, 9);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(20, 19);
            this.close1.TabIndex = 12;
            this.close1.Text = "X";
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.budget_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.addCategory_btn);
            this.panel2.Controls.Add(this.expenses_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 737);
            this.panel2.TabIndex = 3;
            // 
            // budget_btn
            // 
            this.budget_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.budget_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budget_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.budget_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.budget_btn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget_btn.Image = global::ExpenseTracker.Properties.Resources.budget_piggy_saving_icon_icon_1320086683086208285_24px;
            this.budget_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.budget_btn.Location = new System.Drawing.Point(12, 370);
            this.budget_btn.Name = "budget_btn";
            this.budget_btn.Size = new System.Drawing.Size(175, 44);
            this.budget_btn.TabIndex = 10;
            this.budget_btn.Text = "Budget";
            this.budget_btn.UseVisualStyleBackColor = false;
            this.budget_btn.Click += new System.EventHandler(this.budget_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Image = global::ExpenseTracker.Properties.Resources.logout_1324760598547500271_24px;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 596);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(175, 44);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addCategory_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategory_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.addCategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_btn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_btn.Image = global::ExpenseTracker.Properties.Resources.bxs_category_1325051951160984370_24px;
            this.addCategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory_btn.Location = new System.Drawing.Point(12, 270);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(175, 44);
            this.addCategory_btn.TabIndex = 8;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = false;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.expenses_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenses_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.Image = global::ExpenseTracker.Properties.Resources.payment_wallet_icon_1320166083969035735_24px;
            this.expenses_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Location = new System.Drawing.Point(12, 320);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(175, 44);
            this.expenses_btn.TabIndex = 7;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Image = global::ExpenseTracker.Properties.Resources.chart_dashboard_graph_icon_1320183289418444646_24px__1_;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 220);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(175, 44);
            this.dashboard_btn.TabIndex = 6;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome, ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExpenseTracker.Properties.Resources.bank_calculate_calculator_chart_finance_graph_icon_1320073243474169578_128px;
            this.pictureBox2.Location = new System.Drawing.Point(28, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.budgetForm1);
            this.panel3.Controls.Add(this.expenseForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1201, 737);
            this.panel3.TabIndex = 10;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(-3, -3);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1201, 737);
            this.dashboardForm1.TabIndex = 13;
            // 
            // budgetForm1
            // 
            this.budgetForm1.Location = new System.Drawing.Point(0, 0);
            this.budgetForm1.Name = "budgetForm1";
            this.budgetForm1.Size = new System.Drawing.Size(1201, 737);
            this.budgetForm1.TabIndex = 12;
            // 
            // expenseForm1
            // 
            this.expenseForm1.Location = new System.Drawing.Point(0, 0);
            this.expenseForm1.Name = "expenseForm1";
            this.expenseForm1.Size = new System.Drawing.Size(1201, 737);
            this.expenseForm1.TabIndex = 11;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1201, 737);
            this.categoryForm1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 782);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.Button expenses_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button budget_btn;
        private CategoryForm categoryForm1;
        private ExpenseForm expenseForm1;
        private BudgetForm budgetForm1;
        private DashboardForm dashboardForm1;
    }
}