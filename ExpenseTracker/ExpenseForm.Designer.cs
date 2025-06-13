namespace ExpenseTracker
{
    partial class ExpenseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expense_clearBtn = new System.Windows.Forms.Button();
            this.expense_updateBtn = new System.Windows.Forms.Button();
            this.expense_deleteBtn = new System.Windows.Forms.Button();
            this.expense_addBtn = new System.Windows.Forms.Button();
            this.expense_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expense_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expense_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expense_item = new System.Windows.Forms.TextBox();
            this.expense_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 321);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 240);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.expense_clearBtn);
            this.panel2.Controls.Add(this.expense_updateBtn);
            this.panel2.Controls.Add(this.expense_deleteBtn);
            this.panel2.Controls.Add(this.expense_addBtn);
            this.panel2.Controls.Add(this.expense_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.expense_description);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.expense_price);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.expense_item);
            this.panel2.Controls.Add(this.expense_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 321);
            this.panel2.TabIndex = 1;
            // 
            // expense_clearBtn
            // 
            this.expense_clearBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.expense_clearBtn.FlatAppearance.BorderSize = 0;
            this.expense_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_clearBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_clearBtn.ForeColor = System.Drawing.Color.White;
            this.expense_clearBtn.Location = new System.Drawing.Point(721, 235);
            this.expense_clearBtn.Name = "expense_clearBtn";
            this.expense_clearBtn.Size = new System.Drawing.Size(102, 56);
            this.expense_clearBtn.TabIndex = 12;
            this.expense_clearBtn.Text = "CLEAR";
            this.expense_clearBtn.UseVisualStyleBackColor = false;
            this.expense_clearBtn.Click += new System.EventHandler(this.expense_clearBtn_Click);
            // 
            // expense_updateBtn
            // 
            this.expense_updateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.expense_updateBtn.FlatAppearance.BorderSize = 0;
            this.expense_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_updateBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_updateBtn.ForeColor = System.Drawing.Color.White;
            this.expense_updateBtn.Location = new System.Drawing.Point(405, 235);
            this.expense_updateBtn.Name = "expense_updateBtn";
            this.expense_updateBtn.Size = new System.Drawing.Size(102, 56);
            this.expense_updateBtn.TabIndex = 12;
            this.expense_updateBtn.Text = "UPDATE";
            this.expense_updateBtn.UseVisualStyleBackColor = false;
            this.expense_updateBtn.Click += new System.EventHandler(this.expense_updateBtn_Click);
            // 
            // expense_deleteBtn
            // 
            this.expense_deleteBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.expense_deleteBtn.FlatAppearance.BorderSize = 0;
            this.expense_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_deleteBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.expense_deleteBtn.Location = new System.Drawing.Point(581, 235);
            this.expense_deleteBtn.Name = "expense_deleteBtn";
            this.expense_deleteBtn.Size = new System.Drawing.Size(102, 56);
            this.expense_deleteBtn.TabIndex = 11;
            this.expense_deleteBtn.Text = "DELETE";
            this.expense_deleteBtn.UseVisualStyleBackColor = false;
            this.expense_deleteBtn.Click += new System.EventHandler(this.expense_deleteBtn_Click);
            // 
            // expense_addBtn
            // 
            this.expense_addBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.expense_addBtn.FlatAppearance.BorderSize = 0;
            this.expense_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_addBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_addBtn.ForeColor = System.Drawing.Color.White;
            this.expense_addBtn.Location = new System.Drawing.Point(266, 235);
            this.expense_addBtn.Name = "expense_addBtn";
            this.expense_addBtn.Size = new System.Drawing.Size(102, 56);
            this.expense_addBtn.TabIndex = 11;
            this.expense_addBtn.Text = "ADD";
            this.expense_addBtn.UseVisualStyleBackColor = false;
            this.expense_addBtn.Click += new System.EventHandler(this.expense_addBtn_Click);
            // 
            // expense_date
            // 
            this.expense_date.Location = new System.Drawing.Point(593, 129);
            this.expense_date.Name = "expense_date";
            this.expense_date.Size = new System.Drawing.Size(200, 20);
            this.expense_date.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description :";
            // 
            // expense_description
            // 
            this.expense_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.expense_description.Location = new System.Drawing.Point(594, 28);
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            this.expense_description.Size = new System.Drawing.Size(535, 76);
            this.expense_description.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price :";
            // 
            // expense_price
            // 
            this.expense_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.expense_price.Location = new System.Drawing.Point(143, 128);
            this.expense_price.Name = "expense_price";
            this.expense_price.Size = new System.Drawing.Size(208, 26);
            this.expense_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item :";
            // 
            // expense_item
            // 
            this.expense_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.expense_item.Location = new System.Drawing.Point(143, 82);
            this.expense_item.Name = "expense_item";
            this.expense_item.Size = new System.Drawing.Size(208, 26);
            this.expense_item.TabIndex = 3;
            // 
            // expense_category
            // 
            this.expense_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.expense_category.FormattingEnabled = true;
            this.expense_category.Location = new System.Drawing.Point(143, 33);
            this.expense_category.Name = "expense_category";
            this.expense_category.Size = new System.Drawing.Size(208, 28);
            this.expense_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseForm";
            this.Size = new System.Drawing.Size(1201, 737);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expense_item;
        private System.Windows.Forms.ComboBox expense_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expense_description;
        private System.Windows.Forms.DateTimePicker expense_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expense_price;
        private System.Windows.Forms.Button expense_updateBtn;
        private System.Windows.Forms.Button expense_addBtn;
        private System.Windows.Forms.Button expense_clearBtn;
        private System.Windows.Forms.Button expense_deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
