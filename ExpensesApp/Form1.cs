using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExpensesApp
{
    public partial class Form1 : Form
    {
        ExpenseTrackerDatabase db;
        public Form1()
        {
            InitializeComponent();
            string projectPath = @"C:\Users\Владислав\Desktop\ExpensesApp-master\Base.db";
            db = new ExpenseTrackerDatabase(projectPath);
            db.CreateExpenseTable();
            CountExpenses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 добавить = new Form2(db, this);
            добавить.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 поиск = new Form3(db);
            поиск.Show();
        }

        public void CountExpenses()
        {
            flowLayoutPanel1.Controls.Clear();
            label2.Text = db.CalculateExpensesLast30Days().ToString();
            List<string> lastNExpenses = db.GetLastNExpenses(7);

            foreach (string expense in lastNExpenses)
            {
                Debug.WriteLine(expense);
                Label label = new Label
                {
                    AutoSize = true,
                    ForeColor = Color.Black,
                    Font = label3.Font,
                    Text = expense
                };
                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
