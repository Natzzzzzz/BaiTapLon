using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExerciseOne
{
    public partial class SignUp : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        private string setFormatDate(string datetime)
        {
            string[] temp = datetime.Split('/');
            string result = temp[2] + "-" + temp[0] + "-" + temp[1];
            return result;
        }
        private void setFormatDateOfBirth()
        {
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
        }
        private void loadProvinceName()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from ProvinceList"; 
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbHome.Items.Add(dataReader["Province"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            setFormatDateOfBirth();
            loadProvinceName();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserPassword.Text == "" || txtFullName.Text == "" || txtPhoneNumber.Text == "" || cbHome.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            if (txtPhoneNumber.MaxLength != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!!!");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "select * from DataLogin where UserName='" + txtUserName.Text + "'";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("Tài khoản đã được đăng ký!");
                    }
                    else
                    {
                        String anotherStringSQL = "insert into DataLogin values ('" + txtUserName.Text + "', '" + txtUserPassword.Text + "', '" + txtFullName.Text + "', '" + setFormatDate(dtpDateOfBirth.Value.ToShortDateString()) + "', '" + txtPhoneNumber.Text + "', N'" + cbHome.SelectedItem.ToString() + "')";
                        SqlCommand anotherCmd = new SqlCommand(anotherStringSQL, conn);
                        anotherCmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký tài khoản thành công!");
                        this.Hide();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
            
        }
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
