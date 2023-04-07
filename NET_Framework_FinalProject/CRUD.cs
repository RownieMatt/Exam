using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Framework_FinalProject
{
    public partial class CRUD : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            HeaderL.Text = Application.UserAppDataRegistry.GetValue("Header").ToString();
            con.Open();
            if (HeaderL.Text == "Employees")
            {
                SqlCommand Show = new SqlCommand("select * from tblEmployeeExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (HeaderL.Text == "Customers")
            {
                SqlCommand Show = new SqlCommand("select * from tblCustomerExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            con.Close();
        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Close();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (HeaderL.Text == "Employees")
            {
                SqlCommand Insert = new SqlCommand("Insert_tblEmployeeExam", con);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = NameTBox.Text;
                Insert.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = AdressTBox.Text;
                if (PHTBox.Text.Length < 12)
                {
                    Insert.Parameters.AddWithValue("@PhoneNumber", SqlDbType.Int).Value = Convert.ToInt32(PHTBox.Text);
                }
                else
                {
                    MessageBox.Show("Please type in valid Phone Number");
                }
                if (Regex.Matches(EmailTBox.Text,"@").Count > 0)
                {
                    Insert.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = EmailTBox.Text;
                }
                else
                {
                    MessageBox.Show("Please put in valid Email");
                }

                Insert.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(AgeTBox.Text);
                Insert.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = Convert.ToChar(GenTBox.Text);
                Insert.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = DOBDT.Value;
                Insert.Parameters.AddWithValue("@Nationality", SqlDbType.VarChar).Value = NatTBox.Text;
                Insert.Parameters.AddWithValue("@Salary", SqlDbType.Float).Value = Convert.ToDouble(SalaryTBox.Text);
                Insert.Parameters.AddWithValue("@Position", SqlDbType.VarChar).Value = PosTBox.Text;
                Insert.Parameters.AddWithValue("@StartDate", SqlDbType.DateTime).Value = SDDT.Value;
                Insert.ExecuteNonQuery();
                SqlCommand Show = new SqlCommand("select * from tblEmployeeExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (HeaderL.Text == "Customers")
            {
                SqlCommand Insert = new SqlCommand("Insert_tblCustomerExam", con);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = NameTBox.Text;
                Insert.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = AdressTBox.Text;
                if (PHTBox.Text.Length < 12)
                {
                    Insert.Parameters.AddWithValue("@PhoneNumber", SqlDbType.Int).Value = Convert.ToInt32(PHTBox.Text);
                }
                else
                {
                    MessageBox.Show("Please type in valid Phone Number");
                }
                if (Regex.Matches(EmailTBox.Text, "@").Count > 0)
                {
                    Insert.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = EmailTBox.Text;
                }
                else
                {
                    MessageBox.Show("Please put in valid Email");
                }
                Insert.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(AgeTBox.Text);
                Insert.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = Convert.ToChar(GenTBox.Text);
                Insert.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = DOBDT.Value;
                Insert.Parameters.AddWithValue("@Nationality", SqlDbType.VarChar).Value = NatTBox.Text;
                Insert.Parameters.AddWithValue("@Salary", SqlDbType.Float).Value = Convert.ToDouble(SalaryTBox.Text);
                Insert.Parameters.AddWithValue("@Position", SqlDbType.VarChar).Value = PosTBox.Text;
                Insert.Parameters.AddWithValue("@StartDate", SqlDbType.DateTime).Value = SDDT.Value;
                Insert.ExecuteNonQuery();
                SqlCommand Show = new SqlCommand("select * from tblCustomerExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            NameTBox.Text = string.Empty;
            IDTBox.Text = string.Empty;
            AdressTBox.Text = string.Empty;
            PHTBox.Text = string.Empty;
            EmailTBox.Text = string.Empty;
            AgeTBox.Text = string.Empty;
            GenTBox.Text = string.Empty;
            NatTBox.Text = string.Empty;
            SalaryTBox.Text = string.Empty;
            PosTBox.Text = string.Empty;
            con.Close();
        }

        private void ModifyB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (HeaderL.Text == "Employees")
            {
                SqlCommand Insert = new SqlCommand("Modify_tblEmployeeExam", con);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Convert.ToInt64(IDTBox.Text);
                Insert.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = NameTBox.Text;
                Insert.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = AdressTBox.Text;
                Insert.Parameters.AddWithValue("@PhoneNumber", SqlDbType.Int).Value = Convert.ToInt32(PHTBox.Text);
                Insert.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = EmailTBox.Text;
                Insert.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(AgeTBox.Text);
                Insert.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = Convert.ToChar(GenTBox.Text);
                Insert.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = DOBDT.Value;
                Insert.Parameters.AddWithValue("@Nationality", SqlDbType.VarChar).Value = NatTBox.Text;
                Insert.Parameters.AddWithValue("@Salary", SqlDbType.Float).Value = Convert.ToDouble(SalaryTBox.Text);
                Insert.Parameters.AddWithValue("@Position", SqlDbType.VarChar).Value = PosTBox.Text;
                Insert.Parameters.AddWithValue("@StartDate", SqlDbType.DateTime).Value = SDDT.Value;
                Insert.ExecuteNonQuery();
                SqlCommand Show = new SqlCommand("select * from tblEmployeeExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (HeaderL.Text == "Customers")
            {
                SqlCommand Insert = new SqlCommand("Modify_tblCustomerExam", con);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Convert.ToInt64(IDTBox.Text);
                Insert.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = NameTBox.Text;
                Insert.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = AdressTBox.Text;
                Insert.Parameters.AddWithValue("@PhoneNumber", SqlDbType.Int).Value = Convert.ToInt32(PHTBox.Text);
                Insert.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = EmailTBox.Text;
                Insert.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(AgeTBox.Text);
                Insert.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = Convert.ToChar(GenTBox.Text);
                Insert.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = DOBDT.Value;
                Insert.Parameters.AddWithValue("@Nationality", SqlDbType.VarChar).Value = NatTBox.Text;
                Insert.Parameters.AddWithValue("@Salary", SqlDbType.Float).Value = Convert.ToDouble(SalaryTBox.Text);
                Insert.Parameters.AddWithValue("@Position", SqlDbType.VarChar).Value = PosTBox.Text;
                Insert.Parameters.AddWithValue("@StartDate", SqlDbType.DateTime).Value = SDDT.Value;
                Insert.ExecuteNonQuery();
                SqlCommand Show = new SqlCommand("select * from tblCustomerExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            NameTBox.Text = string.Empty;
            IDTBox.Text = string.Empty;
            AdressTBox.Text = string.Empty;
            PHTBox.Text = string.Empty;
            EmailTBox.Text = string.Empty;
            AgeTBox.Text = string.Empty;
            GenTBox.Text = string.Empty;
            NatTBox.Text = string.Empty;
            SalaryTBox.Text = string.Empty;
            PosTBox.Text = string.Empty;

            con.Close();
        }
    }
}
