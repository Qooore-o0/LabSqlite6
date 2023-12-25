using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExpensesApp
{
    public partial class Form3 : Form
    {
        ExpenseTrackerDatabase expenseTrackerDatabase;
        public Form3(ExpenseTrackerDatabase db)
        {
            InitializeComponent();
            Data();
            this.expenseTrackerDatabase = db;
        }

        private void Data()
        {
            //Создаем datatable с названиями столбцов
           DataTable dataTable = new DataTable("Расходы");
            dataTable.Columns.Add("Название", typeof(string));
            dataTable.Columns.Add("Сумма", typeof(string));
            dataTable.Columns.Add("Категория", typeof(string));
            dataTable.Columns.Add("Дата", typeof(string));
            dataTable.Columns.Add("Комментарий", typeof(string));
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string имя = filterName.Text;
            DateTime начальная_дата = filterDateStart.Value;
            DateTime конечная_дата= filterDateEnd.Value;

            double макс = 0;
            double мин = 0;
            if (!string.IsNullOrWhiteSpace(filterMax.Text) && !filterMax.Text.Any(char.IsLetter) && 
                !filterMax.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                макс = Convert.ToDouble(filterMax.Text);
            }
            if (!string.IsNullOrWhiteSpace(filterMin.Text) && !filterMin.Text.Any(char.IsLetter) && 
                !filterMin.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                мин = Convert.ToDouble(filterMin.Text);
            }
            dataGridView1.DataSource = expenseTrackerDatabase.GetDataTableWithFilters(имя, мин, макс, начальная_дата,
                конечная_дата);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
