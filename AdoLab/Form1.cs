using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AdoLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButtonsEnabled(false, true);

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        List<Employee> employees = new List<Employee>();
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=AdoCompany;Integrated Security=True;Trust Server Certificate=True");
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            employees.Clear();
            dataGridView.DataSource = null;
            EmptyTextBoxes();
            SqlCommand sqlCommand = new SqlCommand("DisplayEmployeesDataSP", connection);
            connection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee()
                {
                    Id = reader.GetInt32(0),
                    Fname = reader.GetString(1),
                    Lname = reader.GetString(2),
                    DeptId = reader.GetInt32(3),
                    DeptName = reader.GetString(4)
                };
                employees.Add(emp);
            }
            connection.Close();
            dataGridView.DataSource = employees;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            employees.Clear();
            dataGridView.DataSource = null;

            SqlCommand sqlCommand = new SqlCommand("SearchEmployeeSP", connection) { CommandType = CommandType.StoredProcedure };
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "id",
                Value = int.Parse(IdBox.Text),
                SqlDbType = SqlDbType.Int
            };
            sqlCommand.Parameters.Add(idParam);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                Employee emp = new Employee()
                {
                    Id = reader.GetInt32(0),
                    Fname = reader.GetString(1),
                    Lname = reader.GetString(2),
                    DeptId = reader.GetInt32(3),
                    DeptName = reader.GetString(4)
                };
                employees.Add(emp);
            }
            connection.Close();
            EmptyTextBoxes();
            dataGridView.DataSource = employees;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand("UpdateEmployeesData", connection) { CommandType = CommandType.StoredProcedure };
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "id",
                Value = int.Parse(IdBox.Text),
                SqlDbType = SqlDbType.Int
            };
            SqlParameter FnameParam = new SqlParameter()
            {
                ParameterName = "Fname",
                Value = FnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            SqlParameter LnameParam = new SqlParameter()
            {
                ParameterName = "Lname",
                Value = LnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            SqlParameter didParam = new SqlParameter()
            {
                ParameterName = "DeptId",
                Value = int.Parse(DidBox.Text),
                SqlDbType = SqlDbType.Int
            };
            SqlParameter DnameParam = new SqlParameter()
            {
                ParameterName = "DeptName",
                Value = DnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            sqlCommand.Parameters.Add(idParam);
            sqlCommand.Parameters.Add(FnameParam);
            sqlCommand.Parameters.Add(LnameParam);
            sqlCommand.Parameters.Add(didParam);
            sqlCommand.Parameters.Add(DnameParam);
            connection.Open();
            int rows = sqlCommand.ExecuteNonQuery();

            EmptyTextBoxes();
            connection.Close();

            btnDisplay_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeDataSP", connection) { CommandType = CommandType.StoredProcedure };
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "id",
                Value = int.Parse(IdBox.Text),
                SqlDbType = SqlDbType.Int
            };
            sqlCommand.Parameters.Add(idParam);
            connection.Open();
            int rows = sqlCommand.ExecuteNonQuery();
            connection.Close();
            EmptyTextBoxes();

            btnDisplay_Click(sender, e);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand("InsertEmployeeData", connection) { CommandType = CommandType.StoredProcedure };
            SqlParameter FnameParam = new SqlParameter()
            {
                ParameterName = "Fname",
                Value = FnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            SqlParameter LnameParam = new SqlParameter()
            {
                ParameterName = "Lname",
                Value = LnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            SqlParameter didParam = new SqlParameter()
            {
                ParameterName = "DeptId",
                Value = int.Parse(DidBox.Text),
                SqlDbType = SqlDbType.Int
            };
            SqlParameter DnameParam = new SqlParameter()
            {
                ParameterName = "DeptName",
                Value = DnameBox.Text,
                SqlDbType = SqlDbType.NVarChar
            };
            sqlCommand.Parameters.Add(FnameParam);
            sqlCommand.Parameters.Add(LnameParam);
            sqlCommand.Parameters.Add(didParam);
            sqlCommand.Parameters.Add(DnameParam);

            connection.Open();
            int rows = sqlCommand.ExecuteNonQuery();

            EmptyTextBoxes();
            connection.Close();

            btnDisplay_Click(sender, e);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            ButtonsEnabled(true, false);
            //connection.Open();
        }

       

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //connection.Close();
            ButtonsEnabled(false, true);
            dataGridView.DataSource= null;
        }
        private void ButtonsEnabled(bool c, bool d)
        {
            btnDisplay.Enabled = c;
            btnDelete.Enabled = c;
            btnInsert.Enabled = c;
            btnUpdate.Enabled = c;
            btnSearch.Enabled = c;
            btnConnect.Enabled = d;
            btnDisconnect.Enabled = c;
        }

        private void EmptyTextBoxes()
        {
            IdBox.Text = string.Empty;
            FnameBox.Text= string.Empty;
            LnameBox.Text= string.Empty;
            DnameBox.Text= string.Empty;
            DidBox.Text= string.Empty;
        }
    }
}
