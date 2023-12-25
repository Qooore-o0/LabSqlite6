using System;
using System.Linq;
using System.Windows.Forms;
namespace ExpensesApp
{
    public partial class Form2 : Form
    {
        DateTime дата = DateTime.Now;
        ExpenseTrackerDatabase database;
        Form1 formMain;
        public Form2(ExpenseTrackerDatabase db, Form1 form)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.database = db;
            this.formMain = form;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameOp.Text) && !string.IsNullOrEmpty(textBoxCommentOp.Text) 
                && !string.IsNullOrEmpty(textBoxSumOp.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                if (!textBoxSumOp.Text.Any(char.IsLetter) && !textBoxSumOp.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
                {
                    string имя= textBoxNameOp.Text;
                    double сумма = Convert.ToDouble(textBoxSumOp.Text);
                    string категория = comboBox1.Text;
                    string комментарий = textBoxCommentOp.Text;
                    database.InsertExpense(имя, сумма, категория, дата, комментарий);
                    MessageBox.Show("Успешно");
                    formMain.CountExpenses();
                    this.Close();
                } else
                {
                    MessageBox.Show("Введите корректную сумму");
                }
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            дата = dateTimePicker1.Value;
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNameOp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
