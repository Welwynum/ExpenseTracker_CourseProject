namespace ExpenseTracker
{
    partial class BudgetForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.budgetType = new System.Windows.Forms.ComboBox();
            this.ClearBudget = new System.Windows.Forms.Button();
            this.UpdateBudget = new System.Windows.Forms.Button();
            this.DeleteBudget = new System.Windows.Forms.Button();
            this.AddBudget = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.budgetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barChartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChartBudget)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.budgetDataGridView);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 386);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Budgets";
            // 
            // budgetDataGridView
            // 
            this.budgetDataGridView.AllowUserToAddRows = false;
            this.budgetDataGridView.AllowUserToDeleteRows = false;
            this.budgetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.budgetDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budgetDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.budgetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetDataGridView.EnableHeadersVisualStyles = false;
            this.budgetDataGridView.Location = new System.Drawing.Point(22, 48);
            this.budgetDataGridView.Name = "budgetDataGridView";
            this.budgetDataGridView.ReadOnly = true;
            this.budgetDataGridView.RowHeadersVisible = false;
            this.budgetDataGridView.Size = new System.Drawing.Size(465, 298);
            this.budgetDataGridView.TabIndex = 3;
            this.budgetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.budgetDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.budgetType);
            this.panel2.Controls.Add(this.ClearBudget);
            this.panel2.Controls.Add(this.UpdateBudget);
            this.panel2.Controls.Add(this.DeleteBudget);
            this.panel2.Controls.Add(this.AddBudget);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.budgetAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.budgetCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 308);
            this.panel2.TabIndex = 1;
            // 
            // budgetType
            // 
            this.budgetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.budgetType.FormattingEnabled = true;
            this.budgetType.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.budgetType.Location = new System.Drawing.Point(137, 81);
            this.budgetType.Name = "budgetType";
            this.budgetType.Size = new System.Drawing.Size(208, 28);
            this.budgetType.TabIndex = 27;
            // 
            // ClearBudget
            // 
            this.ClearBudget.BackColor = System.Drawing.Color.SeaGreen;
            this.ClearBudget.FlatAppearance.BorderSize = 0;
            this.ClearBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBudget.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBudget.ForeColor = System.Drawing.Color.White;
            this.ClearBudget.Location = new System.Drawing.Point(371, 230);
            this.ClearBudget.Name = "ClearBudget";
            this.ClearBudget.Size = new System.Drawing.Size(102, 56);
            this.ClearBudget.TabIndex = 25;
            this.ClearBudget.Text = "CLEAR";
            this.ClearBudget.UseVisualStyleBackColor = false;
            this.ClearBudget.Click += new System.EventHandler(this.ClearBudget_Click);
            // 
            // UpdateBudget
            // 
            this.UpdateBudget.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateBudget.FlatAppearance.BorderSize = 0;
            this.UpdateBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBudget.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBudget.ForeColor = System.Drawing.Color.White;
            this.UpdateBudget.Location = new System.Drawing.Point(137, 230);
            this.UpdateBudget.Name = "UpdateBudget";
            this.UpdateBudget.Size = new System.Drawing.Size(102, 56);
            this.UpdateBudget.TabIndex = 26;
            this.UpdateBudget.Text = "UPDATE";
            this.UpdateBudget.UseVisualStyleBackColor = false;
            this.UpdateBudget.Click += new System.EventHandler(this.UpdateBudget_Click_1);
            // 
            // DeleteBudget
            // 
            this.DeleteBudget.BackColor = System.Drawing.Color.SeaGreen;
            this.DeleteBudget.FlatAppearance.BorderSize = 0;
            this.DeleteBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBudget.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBudget.ForeColor = System.Drawing.Color.White;
            this.DeleteBudget.Location = new System.Drawing.Point(254, 230);
            this.DeleteBudget.Name = "DeleteBudget";
            this.DeleteBudget.Size = new System.Drawing.Size(102, 56);
            this.DeleteBudget.TabIndex = 23;
            this.DeleteBudget.Text = "DELETE";
            this.DeleteBudget.UseVisualStyleBackColor = false;
            this.DeleteBudget.Click += new System.EventHandler(this.DeleteBudget_Click_1);
            // 
            // AddBudget
            // 
            this.AddBudget.BackColor = System.Drawing.Color.SeaGreen;
            this.AddBudget.FlatAppearance.BorderSize = 0;
            this.AddBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBudget.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBudget.ForeColor = System.Drawing.Color.White;
            this.AddBudget.Location = new System.Drawing.Point(22, 230);
            this.AddBudget.Name = "AddBudget";
            this.AddBudget.Size = new System.Drawing.Size(102, 56);
            this.AddBudget.TabIndex = 24;
            this.AddBudget.Text = "ADD";
            this.AddBudget.UseVisualStyleBackColor = false;
            this.AddBudget.Click += new System.EventHandler(this.AddBudget_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Amount :";
            // 
            // budgetAmount
            // 
            this.budgetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.budgetAmount.Location = new System.Drawing.Point(137, 123);
            this.budgetAmount.Name = "budgetAmount";
            this.budgetAmount.Size = new System.Drawing.Size(208, 26);
            this.budgetAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type :";
            // 
            // budgetCategory
            // 
            this.budgetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.budgetCategory.FormattingEnabled = true;
            this.budgetCategory.Location = new System.Drawing.Point(137, 28);
            this.budgetCategory.Name = "budgetCategory";
            this.budgetCategory.Size = new System.Drawing.Size(208, 28);
            this.budgetCategory.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.barChartBudget);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(536, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 308);
            this.panel3.TabIndex = 2;
            // 
            // barChartBudget
            // 
            chartArea5.Name = "ChartArea1";
            this.barChartBudget.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.barChartBudget.Legends.Add(legend5);
            this.barChartBudget.Location = new System.Drawing.Point(21, 49);
            this.barChartBudget.Name = "barChartBudget";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.barChartBudget.Series.Add(series5);
            this.barChartBudget.Size = new System.Drawing.Size(598, 247);
            this.barChartBudget.TabIndex = 7;
            this.barChartBudget.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bar Chart";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chartBudget);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(536, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 386);
            this.panel4.TabIndex = 3;
            // 
            // chartBudget
            // 
            chartArea6.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartBudget.Legends.Add(legend6);
            this.chartBudget.Location = new System.Drawing.Point(24, 58);
            this.chartBudget.Name = "chartBudget";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartBudget.Series.Add(series6);
            this.chartBudget.Size = new System.Drawing.Size(594, 311);
            this.chartBudget.TabIndex = 6;
            this.chartBudget.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pie Chart";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BudgetForm";
            this.Size = new System.Drawing.Size(1201, 737);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChartBudget)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView budgetDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearBudget;
        private System.Windows.Forms.Button UpdateBudget;
        private System.Windows.Forms.Button DeleteBudget;
        private System.Windows.Forms.Button AddBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox budgetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox budgetCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox budgetType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChartBudget;
    }
}
