using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using PdfSharp.Fonts;




namespace ExpenseTracker
{

    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";

        private BudgetForm budgetFormRef;


        public DashboardForm()
        {
            InitializeComponent();
         
        }
        public void Initialize(BudgetForm budgetForm)
        {
            this.budgetFormRef = budgetForm;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadExpenseSummary();
            LoadTopThreeCategories();
            LoadExpenseChart();
        }

        private void LoadExpenseSummary()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                // This Week
                SqlCommand cmdWeek = new SqlCommand("SELECT ISNULL(SUM(price), 0) FROM expenses WHERE DATEPART(week, date_expense) = DATEPART(week, GETDATE()) AND YEAR(date_expense) = YEAR(GETDATE())", connect);
                lblWeekTotal.Text = cmdWeek.ExecuteScalar().ToString();

                // This Month
                SqlCommand cmdMonth = new SqlCommand("SELECT ISNULL(SUM(price), 0) FROM expenses WHERE MONTH(date_expense) = MONTH(GETDATE()) AND YEAR(date_expense) = YEAR(GETDATE())", connect);
                lblMonthTotal.Text = cmdMonth.ExecuteScalar().ToString();

                // This Year
                SqlCommand cmdYear = new SqlCommand("SELECT ISNULL(SUM(price), 0) FROM expenses WHERE YEAR(date_expense) = YEAR(GETDATE())", connect);
                lblYearTotal.Text = cmdYear.ExecuteScalar().ToString();

                connect.Close();
            }
        }

        private void LoadTopThreeCategories()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT TOP 3 c.category, SUM(e.price) AS TotalSpent
                    FROM expenses e
                    JOIN categories c ON e.category_id = c.id
                    GROUP BY c.category
                    ORDER BY TotalSpent DESC", connect);

                SqlDataReader reader = cmd.ExecuteReader();
                int rank = 1;
                while (reader.Read())
                {
                    string category = reader["category"].ToString();
                    string amount = reader["TotalSpent"].ToString();

                    switch (rank)
                    {
                        case 1:
                            lblTop1.Text = category;
                            lblTop1Amount.Text = amount;
                            break;
                        case 2:
                            lblTop2.Text = category;
                            lblTop2Amount.Text = amount;
                            break;
                        case 3:
                            lblTop3.Text = category;
                            lblTop3Amount.Text = amount;
                            break;
                    }
                    rank++;
                }
                reader.Close();
                connect.Close();
            }
        }

        private void LoadExpenseChart()
        {
            chartExpenses.Series.Clear();
            Series series = new Series("Expenses");
            series.ChartType = SeriesChartType.Pie;

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT c.category, SUM(e.price) AS TotalSpent
                    FROM expenses e
                    JOIN categories c ON e.category_id = c.id
                    GROUP BY c.category", connect);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string category = reader["category"].ToString();
                    decimal total = Convert.ToDecimal(reader["TotalSpent"]);
                    series.Points.AddXY(category, total);
                }
                reader.Close();

                chartExpenses.Series.Add(series);
                connect.Close();
            }
        }



        private void GeneratePdfReport()
        {
            GlobalFontSettings.UseWindowsFontsUnderWindows = true;
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Expense Tracker Report";
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            int y = 40;
            var myFontBig = new XFont("Arial", 18, XFontStyleEx.Bold);
            var myFontNaming = new XFont("Arial", 18, XFontStyleEx.Bold);
            var myFont = new XFont("Arial", 12, XFontStyleEx.Regular);
            // TITLE
            gfx.DrawString("Expense Tracker Report", myFontBig, XBrushes.Black, new XPoint(40, y));
            y += 40;

            // WEEK / MONTH / YEAR
            gfx.DrawString($"Spent This Week: {lblWeekTotal.Text}", myFont, XBrushes.Black, new XPoint(40, y));
            y += 20;
            gfx.DrawString($"Spent This Month: {lblMonthTotal.Text}", myFont, XBrushes.Black, new XPoint(40, y));
            y += 20;
            gfx.DrawString($"Spent This Year: {lblYearTotal.Text}", myFont, XBrushes.Black, new XPoint(40, y));
            y += 40;

            // TOP CATEGORIES
            gfx.DrawString("Top 3 Categories:", myFontNaming, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"1. {lblTop1.Text} - {lblTop1Amount.Text}", myFont , XBrushes.Black, new XPoint(60, y));
            y += 20;
            gfx.DrawString($"2. {lblTop2.Text} - {lblTop2Amount.Text}", myFont, XBrushes.Black, new XPoint(60, y));
            y += 20;
            gfx.DrawString($"3. {lblTop3.Text} - {lblTop3Amount.Text}", myFont, XBrushes.Black, new XPoint(60, y));
            y += 40;

            // CHARTS
            // Saves both charts to images first
            string barPath = Path.Combine(Path.GetTempPath(), "barChart.png");
            string piePath = Path.Combine(Path.GetTempPath(), "pieChart.png");

            budgetFormRef.BarChartBudget.SaveImage(barPath, ChartImageFormat.Png);
            chartExpenses.SaveImage(piePath, ChartImageFormat.Png);

            // Draws images to PDF
            XImage barImg = XImage.FromFile(barPath);
            XImage pieImg = XImage.FromFile(piePath);

            gfx.DrawString("Budget vs Expenses", myFontNaming, XBrushes.Black, new XPoint(40, y));
            y += 20;
            gfx.DrawImage(barImg, 40, y, 500, 200);
            y += 220;

            gfx.DrawString("Expenses by Category", myFontNaming, XBrushes.Black, new XPoint(40, y));
            y += 20;
            gfx.DrawImage(pieImg, 40, y, 300, 200);

            // Saves the PDF
            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExpenseReport.pdf");
            pdf.Save(savePath);
            MessageBox.Show($"PDF saved to Desktop as 'ExpenseReport.pdf'", "Report Created", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void makePDF_btn_Click(object sender, EventArgs e)
        {
            GeneratePdfReport();
        }
    }
}
