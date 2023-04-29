using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace ExerciseOne
{
    public partial class SignIn : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String strUserName = txtUserName.Text;
            String strUserPassword = txtUserPassword.Text;
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from DataLogin where UserName='" + strUserName + "' and UserPassword='" + strUserPassword + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Main main = new Main();
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    main.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp newSignUp = new SignUp();
            newSignUp.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
        }



    }
}
