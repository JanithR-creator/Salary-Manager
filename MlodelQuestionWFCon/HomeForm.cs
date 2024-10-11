using ModelQuestion;

namespace MlodelQuestionWFCon
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm emp = new AddEmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SalaryManager();

            dataGridView1.DataSource = EmployeeData.SalaryTable;

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
