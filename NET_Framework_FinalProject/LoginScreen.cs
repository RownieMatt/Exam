using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Framework_FinalProject
{
    public partial class LoginScreen : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            if (RegisterB.Text == "Register")
            {
                RegisterB.Text = "Cancel";
                LoginB.Text = "Register new account";
                CPassL.Visible = true;
                CPassTBox.Visible = true;
            }
            else if (RegisterB.Text == "Cancel")
            {
                LoginB.Text = "Login";
                RegisterB.Text = "Register";
                CPassL.Visible = false;
                CPassTBox.Visible = false;
            }
        }
        public void Insert_User()
        {

            try
            {
                SqlCommand Insert = new SqlCommand("Insert_tblUserExam", con);
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = UserNTBox.Text;
                Insert.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = PassTBox.Text;
                Insert.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {

            if (LoginB.Text == "Login")
            {

                string Validator = string.Empty;
                con.Open();
                SqlCommand Search = new SqlCommand("Select_tblUserExam", con);
                SqlDataAdapter da = new SqlDataAdapter(Search);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl_UserExam");

                for (int Row = 0; Row < ds.Tables[0].Rows.Count; Row++)
                {
                    if (UserNTBox.Text == ds.Tables[0].Rows[Row]["Username"].ToString() && PassTBox.Text == ds.Tables[0].Rows[Row]["Password"].ToString())
                    {
                        Validator = "Login";


                        break;

                    }

                }
                if(Validator =="Login")
                {
                    MainScreen mainScreen = new MainScreen();
                    Application.UserAppDataRegistry.SetValue("Username", UserNTBox.Text);
                    mainScreen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account does not exist");
                }

                con.Close();
            }
            else if (LoginB.Text == "Register new account")
            {
                con.Open();
                try
                {
                    SqlCommand Validate = new SqlCommand("Validate_tblUserExam", con);
                    Validate.CommandType = CommandType.StoredProcedure;
                    Validate.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = UserNTBox.Text;
                    SqlDataAdapter da1 = new SqlDataAdapter(Validate);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "tblUserExam");
                    ds1.Tables.Add();

                    if (ds1.Tables[0].Rows[0]["Users"].ToString() == "0")
                    {
                        if (PassTBox.Text == CPassTBox.Text)
                        {
                            Insert_User();
                            RegisterB.Text = "Register";
                            CPassL.Visible = false;
                            CPassTBox.Visible = false;
                            LoginB.Text = "Login";
                            SqlCommand Select = new SqlCommand("Select_tblUserExam", con);
                            SqlDataAdapter da2 = new SqlDataAdapter(Select);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            UserNTBox.Text = string.Empty;
                            PassTBox.Text = string.Empty;
                            CPassTBox.Text = string.Empty;
                            tblUser.DataSource = dt2;
                            tblUser.Visible = true;


                        }
                        else
                        {
                            MessageBox.Show("Please put in the correct password");

                        }
                    }
                    else
                    {
                        MessageBox.Show("User already exists");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand Select = new SqlCommand("Select_tblUserExam", con);
            SqlDataAdapter da = new SqlDataAdapter(Select);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                tblUser.DataSource = dt;
                tblUser.Visible = true;
            }
            con.Close();


        }
    }
}
