using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace NET_Framework_FinalProject
{
    public partial class MainScreen : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            WlcmLabel.Text = "Welcome " + Application.UserAppDataRegistry.GetValue("Username").ToString();
        }

        private void tblEmployeeB_Click(object sender, EventArgs e)
        {
            DetailsB.Visible = true;
            tblEmployeeB.Visible = false;
            tblCustomerB.Visible = true;
            GridView.Visible = true;
            DeleteB.Visible = true;
            SearchB.Visible = true;
            SearchTBox.Visible = true;
            SearchTBox.Text = string.Empty;
            WlcmLabel.Text = "Employees";
            AscB.Visible = true;
            DscB.Visible = true;
            con.Open();
            SqlCommand Show = new SqlCommand("Select * from tblEmployeeExam", con);
            SqlDataAdapter da = new SqlDataAdapter(Show);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;
            con.Close();
        }
        private void tblCustomerB_Click(object sender, EventArgs e)
        {
            DetailsB.Visible = true;
            tblEmployeeB.Visible = true;
            tblCustomerB.Visible = false;
            GridView.Visible = true;
            DeleteB.Visible = true;
            SearchB.Visible = true;
            SearchTBox.Visible = true;
            SearchTBox.Text = string.Empty;
            AscB.Visible = true;
            DscB.Visible = true;
            WlcmLabel.Text = "Customers";
            con.Open();
            SqlCommand Show = new SqlCommand("Select * from tblCustomerExam", con);
            SqlDataAdapter da = new SqlDataAdapter(Show);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView.DataSource = dt;
            con.Close();
        }
        private void LogOB_Click(object sender, EventArgs e)
        {
            LoginScreen lg = new LoginScreen();
            lg.Show();
            this.Close();
        }

        private void DetailsB_Click(object sender, EventArgs e)
        {
            if (tblEmployeeB.Visible == false)
            {
                Application.UserAppDataRegistry.SetValue("Header", "Employees");
                CRUD crud = new CRUD();
                crud.Show();
                this.Hide();
            }
            else if (tblCustomerB.Visible == false)
            {
                Application.UserAppDataRegistry.SetValue("Header", "Customers");
                CRUD crud = new CRUD();
                crud.Show();
                this.Hide();
            }
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tblEmployeeB.Visible == false)
            {
                SqlCommand Delete = new SqlCommand("Delete from tblEmployeeExam where EmployeeID = " + Convert.ToInt64(SearchTBox.Text) + ";", con);
                SqlDataAdapter da = new SqlDataAdapter(Delete);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand Show = new SqlCommand("Select * from tblEmployeeExam", con);
                SqlDataAdapter da1 = new SqlDataAdapter(Show);
                da1.Fill(dt);
                GridView.DataSource = dt;
            }
            else if (tblCustomerB.Visible == false)
            {
                SqlCommand Delete = new SqlCommand("Delete from tblCustomerExam where CustomerID = " + Convert.ToInt64(SearchTBox.Text) + ";", con);
                SqlDataAdapter da = new SqlDataAdapter(Delete);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand Show = new SqlCommand("Select * from tblCustomerExam", con);
                SqlDataAdapter da1 = new SqlDataAdapter(Show);

                da1.Fill(dt);
                GridView.DataSource = dt;
            }
            con.Close();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tblEmployeeB.Visible == false)
            {
                SqlCommand Search = new SqlCommand
                                ("select * from tblEmployeeExam where (EmployeeID like '%" + SearchTBox.Text + "%' or" +
                                " Name like '%" + SearchTBox.Text + "%' or" +
                                " Address like '%" + SearchTBox.Text + "%' or " +
                                "Email like'%" + SearchTBox.Text + "%' or " +
                                "Gender like '%" + SearchTBox.Text + "%' or " +
                                "DateOfBirth like'%" + SearchTBox.Text + "%' or " +
                                "Nationality like'%" + SearchTBox.Text + "%' or " +
                                "Position like'%" + SearchTBox.Text + "%' or " +
                                "StartDate like '%" + SearchTBox.Text + "%')", con);
                SqlDataAdapter da = new SqlDataAdapter(Search);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
            }
            else if (tblCustomerB.Visible == false)
            {
                SqlCommand Search = new SqlCommand
                                ("select * from tblCustomerExam where (CustomerID like '%" + SearchTBox.Text + "%' or" +
                                " Name like '%" + SearchTBox.Text + "%' or" +
                                " Address like '%" + SearchTBox.Text + "%' or " +
                                "Email like'%" + SearchTBox.Text + "%' or " +
                                "Gender like '%" + SearchTBox.Text + "%' or " +
                                "DateOfBirth like'%" + SearchTBox.Text + "%' or " +
                                "Nationality like'%" + SearchTBox.Text + "%' or " +
                                "Salary like'%" + SearchTBox.Text + "%' or " +
                                "Position like'%" + SearchTBox.Text + "%' or " +
                                "StartDate like '%" + SearchTBox.Text + "%')", con);
                SqlDataAdapter da = new SqlDataAdapter(Search);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
            }
            con.Close();
        }

        private void AscB_Click(object sender, EventArgs e)
        {
            if (tblCustomerB.Visible == false)
            {
                con.Open();
                SqlCommand Show = new SqlCommand("Select * from tblCustomerExam order by Name asc", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                con.Close();
            }
            else if (tblEmployeeB.Visible == false)
            {
                con.Open();
                SqlCommand Show = new SqlCommand("Select * from tblEmployeeExam order by Name asc", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                con.Close();
            }


        }

        private void DscB_Click(object sender, EventArgs e)
        {
            if (tblCustomerB.Visible == false)
            {
                con.Open();
                SqlCommand Show = new SqlCommand("Select * from tblCustomerExam order by Name desc", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                con.Close();
            }
            else if (tblEmployeeB.Visible == false)
            {
                con.Open();
                SqlCommand Show = new SqlCommand("Select * from tblEmployeeExam order by Name desc", con);
                SqlDataAdapter da = new SqlDataAdapter(Show);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                con.Close();
            }
        }
    }
}
//CustomerID bigint	Unchecked
//Name	varchar(50)	Unchecked
//Address	varchar(50)	Unchecked
//PhoneNumber	int	Unchecked
//Email	varchar(50)	Unchecked
//Age	int	Unchecked
//Gender	char(2)	Unchecked
//DateOfBirth	datetime	Unchecked
//Nationality	varchar(50)	Unchecked
//Salary	float	Unchecked
//Position	varchar(50)	Unchecked
//StartDate	datetime	Unchecked
