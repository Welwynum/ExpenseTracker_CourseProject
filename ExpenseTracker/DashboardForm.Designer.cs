namespace ExpenseTracker
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearTotal = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonthTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblWeekTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblTop3 = new System.Windows.Forms.Label();
            this.lblTop3Amount = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTop1 = new System.Windows.Forms.Label();
            this.lblTop1Amount = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTop2 = new System.Windows.Forms.Label();
            this.lblTop2Amount = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.makePDF_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 216);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expense\'s Data";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaGreen;
            this.panel7.Controls.Add(this.lblYear);
            this.panel7.Controls.Add(this.lblYearTotal);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(796, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(387, 148);
            this.panel7.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(98, 107);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(150, 23);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Spent this year";
            // 
            // lblYearTotal
            // 
            this.lblYearTotal.AutoSize = true;
            this.lblYearTotal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearTotal.ForeColor = System.Drawing.Color.White;
            this.lblYearTotal.Location = new System.Drawing.Point(98, 38);
            this.lblYearTotal.Name = "lblYearTotal";
            this.lblYearTotal.Size = new System.Drawing.Size(20, 23);
            this.lblYearTotal.TabIndex = 5;
            this.lblYearTotal.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ExpenseTracker.Properties.Resources.year_icon;
            this.pictureBox3.Location = new System.Drawing.Point(28, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.lblMonth);
            this.panel6.Controls.Add(this.lblMonthTotal);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(405, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 148);
            this.panel6.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(96, 107);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(169, 23);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Spent this month";
            // 
            // lblMonthTotal
            // 
            this.lblMonthTotal.AutoSize = true;
            this.lblMonthTotal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthTotal.ForeColor = System.Drawing.Color.White;
            this.lblMonthTotal.Location = new System.Drawing.Point(96, 38);
            this.lblMonthTotal.Name = "lblMonthTotal";
            this.lblMonthTotal.Size = new System.Drawing.Size(20, 23);
            this.lblMonthTotal.TabIndex = 5;
            this.lblMonthTotal.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExpenseTracker.Properties.Resources.date_event_month_icon_1320184636328124602_64px;
            this.pictureBox2.Location = new System.Drawing.Point(26, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Controls.Add(this.lblWeek);
            this.panel5.Controls.Add(this.lblWeekTotal);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(12, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 148);
            this.panel5.TabIndex = 1;
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.White;
            this.lblWeek.Location = new System.Drawing.Point(99, 107);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(157, 23);
            this.lblWeek.TabIndex = 6;
            this.lblWeek.Text = "Spent this week";
            // 
            // lblWeekTotal
            // 
            this.lblWeekTotal.AutoSize = true;
            this.lblWeekTotal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekTotal.ForeColor = System.Drawing.Color.White;
            this.lblWeekTotal.Location = new System.Drawing.Point(99, 38);
            this.lblWeekTotal.Name = "lblWeekTotal";
            this.lblWeekTotal.Size = new System.Drawing.Size(20, 23);
            this.lblWeekTotal.TabIndex = 5;
            this.lblWeekTotal.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.date_event_paper_scheduler_week_icon_1320191204733048265_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Location = new System.Drawing.Point(6, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 216);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top Three Expense Categories";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SeaGreen;
            this.panel11.Controls.Add(this.lblTop3);
            this.panel11.Controls.Add(this.lblTop3Amount);
            this.panel11.Controls.Add(this.pictureBox6);
            this.panel11.Location = new System.Drawing.Point(796, 53);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(387, 148);
            this.panel11.TabIndex = 2;
            // 
            // lblTop3
            // 
            this.lblTop3.AutoSize = true;
            this.lblTop3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3.ForeColor = System.Drawing.Color.White;
            this.lblTop3.Location = new System.Drawing.Point(95, 111);
            this.lblTop3.Name = "lblTop3";
            this.lblTop3.Size = new System.Drawing.Size(117, 23);
            this.lblTop3.TabIndex = 7;
            this.lblTop3.Text = "Category C";
            // 
            // lblTop3Amount
            // 
            this.lblTop3Amount.AutoSize = true;
            this.lblTop3Amount.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3Amount.ForeColor = System.Drawing.Color.White;
            this.lblTop3Amount.Location = new System.Drawing.Point(95, 42);
            this.lblTop3Amount.Name = "lblTop3Amount";
            this.lblTop3Amount.Size = new System.Drawing.Size(20, 23);
            this.lblTop3Amount.TabIndex = 5;
            this.lblTop3Amount.Text = "0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ExpenseTracker.Properties.Resources.bronze_medal;
            this.pictureBox6.Location = new System.Drawing.Point(25, 42);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SeaGreen;
            this.panel10.Controls.Add(this.lblTop1);
            this.panel10.Controls.Add(this.lblTop1Amount);
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Location = new System.Drawing.Point(405, 53);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(385, 148);
            this.panel10.TabIndex = 2;
            // 
            // lblTop1
            // 
            this.lblTop1.AutoSize = true;
            this.lblTop1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop1.ForeColor = System.Drawing.Color.White;
            this.lblTop1.Location = new System.Drawing.Point(93, 111);
            this.lblTop1.Name = "lblTop1";
            this.lblTop1.Size = new System.Drawing.Size(115, 23);
            this.lblTop1.TabIndex = 7;
            this.lblTop1.Text = "Category A";
            // 
            // lblTop1Amount
            // 
            this.lblTop1Amount.AutoSize = true;
            this.lblTop1Amount.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop1Amount.ForeColor = System.Drawing.Color.White;
            this.lblTop1Amount.Location = new System.Drawing.Point(93, 42);
            this.lblTop1Amount.Name = "lblTop1Amount";
            this.lblTop1Amount.Size = new System.Drawing.Size(20, 23);
            this.lblTop1Amount.TabIndex = 5;
            this.lblTop1Amount.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ExpenseTracker.Properties.Resources.first_place_medal;
            this.pictureBox5.Location = new System.Drawing.Point(23, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaGreen;
            this.panel9.Controls.Add(this.lblTop2);
            this.panel9.Controls.Add(this.lblTop2Amount);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Location = new System.Drawing.Point(12, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(387, 148);
            this.panel9.TabIndex = 1;
            // 
            // lblTop2
            // 
            this.lblTop2.AutoSize = true;
            this.lblTop2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop2.ForeColor = System.Drawing.Color.White;
            this.lblTop2.Location = new System.Drawing.Point(96, 111);
            this.lblTop2.Name = "lblTop2";
            this.lblTop2.Size = new System.Drawing.Size(115, 23);
            this.lblTop2.TabIndex = 7;
            this.lblTop2.Text = "Category B";
            // 
            // lblTop2Amount
            // 
            this.lblTop2Amount.AutoSize = true;
            this.lblTop2Amount.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop2Amount.ForeColor = System.Drawing.Color.White;
            this.lblTop2Amount.Location = new System.Drawing.Point(96, 42);
            this.lblTop2Amount.Name = "lblTop2Amount";
            this.lblTop2Amount.Size = new System.Drawing.Size(20, 23);
            this.lblTop2Amount.TabIndex = 5;
            this.lblTop2Amount.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ExpenseTracker.Properties.Resources.second_place;
            this.pictureBox4.Location = new System.Drawing.Point(26, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.chartExpenses);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 226);
            this.panel3.TabIndex = 1;
            // 
            // chartExpenses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(12, 45);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(553, 170);
            this.chartExpenses.TabIndex = 5;
            this.chartExpenses.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expense\'s Chart";
            // 
            // makePDF_btn
            // 
            this.makePDF_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.makePDF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makePDF_btn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePDF_btn.Location = new System.Drawing.Point(871, 596);
            this.makePDF_btn.Name = "makePDF_btn";
            this.makePDF_btn.Size = new System.Drawing.Size(315, 82);
            this.makePDF_btn.TabIndex = 2;
            this.makePDF_btn.Text = "Make PDF report";
            this.makePDF_btn.UseVisualStyleBackColor = false;
            this.makePDF_btn.Click += new System.EventHandler(this.makePDF_btn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.makePDF_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(1201, 737);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button makePDF_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYearTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMonthTotal;
        private System.Windows.Forms.Label lblWeekTotal;
        private System.Windows.Forms.Label lblTop3Amount;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblTop1Amount;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTop2Amount;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblTop3;
        private System.Windows.Forms.Label lblTop1;
        private System.Windows.Forms.Label lblTop2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
    }
}
