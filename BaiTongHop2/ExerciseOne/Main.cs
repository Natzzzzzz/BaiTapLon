using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ExerciseOne
{
    public partial class Main : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public Main()
        {
            InitializeComponent();
        }


        //Main_load
        private void Main_Load(object sender, EventArgs e)
        {
            loadDataProducts();
            loadDataAgents();
            loadDataOrder();
            loadOrderID();
            loadDataOrderDetail(null);
            btnPrint.Hide();
        }


        //Products


        private void loadItemID()
        {
            cbItemID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Items";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbItemID.Items.Add(dataReader["ItemID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void loadDataProducts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Items";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
                da.Dispose();
                conn.Close();
                loadItemID();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || txtSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm");
            }
            
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "exec InsertItem '" + txtItemName.Text + "', " + txtSize.Text;
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cbItemID.ResetText();
                    txtItemName.ResetText();
                    txtSize.ResetText();
                    loadDataProducts();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbItemID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "update Items set ItemName = '" + txtItemName.Text + "', Size = " + Convert.ToInt32(txtSize.Text) + " where ItemID = '" + cbItemID.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cbItemID_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void cbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Hide();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Items where ItemID = '" + cbItemID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
                da.Dispose();
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    txtItemName.Text = row["ItemName"].ToString();
                    txtSize.Text = row["Size"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
            else
            {
                try
                {
                    DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                    string ItemID = Convert.ToString(selectedRow.Cells["ItemID"].Value);
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    SqlCommand anotherCmd = new SqlCommand("delete from OrderDetail where ItemID = @ItemID", conn);
                    anotherCmd.Parameters.AddWithValue("@ItemID", ItemID);
                    anotherCmd.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("delete from Items where ItemID = @ItemID", conn);
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    btnAdd.Show();
                    cbItemID.ResetText();
                    txtItemName.ResetText();
                    txtSize.ResetText();
                    loadDataProducts();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAdd.Show();
            cbItemID.ResetText();
            txtItemName.ResetText();
            txtSize.ResetText();
            loadDataProducts();
        }



        //Agents

        private void loadAgentID()
        {
            cbAgentID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agents";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbAgentID.Items.Add(dataReader["AgentID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void loadDataAgents()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agents";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAgents.DataSource = dt;
                da.Dispose();
                conn.Close();
                loadAgentID();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (txtAgentName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "exec InsertAgent '" + txtAgentName.Text + "', '" + txtAddress.Text + "'";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cbAgentID.ResetText();
                    txtAgentName.ResetText();
                    txtAddress.ResetText();
                    loadDataAgents();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (dgvAgents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa!!!");
            }
            else
            {
                try
                {
                    DataGridViewRow selectedRow = dgvAgents.SelectedRows[0];
                    string AgentID = Convert.ToString(selectedRow.Cells["AgentID"].Value);
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();

                    SqlCommand getOrderIDCmd = new SqlCommand("select OrderDetail.OrderID from OrderDetail, Orders, Agents where Agents.AgentID = @AgentID and Agents.AgentID = Orders.AgentID and OrderDetail.OrderID = Orders.OrderID", conn);
                    getOrderIDCmd.Parameters.AddWithValue("@AgentID", AgentID);
                    SqlDataReader dataReader = getOrderIDCmd.ExecuteReader();
                    string OrderID = "";
                    while (dataReader.Read())
                    {
                        OrderID = dataReader["OrderID"].ToString();
                    }
                    dataReader.Close();
                    SqlCommand differentAnotherCmd = new SqlCommand("delete from OrderDetail where OrderID = @OrderID", conn);
                    differentAnotherCmd.Parameters.AddWithValue("@OrderID", OrderID);
                    differentAnotherCmd.ExecuteNonQuery();
                    SqlCommand anotherCmd = new SqlCommand("delete from Orders where AgentID = @AgentID", conn);
                    anotherCmd.Parameters.AddWithValue("@AgentID", AgentID);
                    anotherCmd.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("delete from Agents where AgentID = @AgentID", conn);
                    cmd.Parameters.AddWithValue("@AgentID", AgentID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    btnAdd.Show();
                    cbAgentID.ResetText();
                    txtAgentName.ResetText();
                    txtAddress.ResetText();
                    loadDataAgents();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (cbAgentID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ID cần sửa");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "update Agents set AgentName = '" + txtAgentName.Text + "', Address = '" + txtAddress.Text + "' where AgentID = '" + cbAgentID.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cbAgentID_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        private void cbAgentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Hide();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Agents where AgentID = '" + cbAgentID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAgents.DataSource = dt;
                da.Dispose();
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    txtAgentName.Text = row["AgentName"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnAdd2.Show();
            cbAgentID.ResetText();
            txtAgentName.ResetText();
            txtAddress.ResetText();
            loadDataAgents();
        }


        //Oders

        private void loadDataOrder()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Orders";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrder.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void loadDataOrderDetail(string str)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from OrderDetail where OrderID = '" + str + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrderDetail.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void loadOrderID()
        {
            cbOrderID.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Orders";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    cbOrderID.Items.Add(dataReader["OrderID"].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataOrderDetail(cbOrderID.SelectedItem.ToString());
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select * from Orders where OrderID = '" + cbOrderID.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrder.DataSource = dt;
                da.Dispose();
                conn.Close();
                btnPrint.Show();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnAll3_Click(object sender, EventArgs e)
        {
            loadOrderID();
            loadDataOrder();
            loadDataOrderDetail(null);
            btnPrint.Hide();
        }
        Bitmap bitmap;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 25,300);
            bitmap.Dispose();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(762, 440, graphics);
            Graphics _graphics = Graphics.FromImage(bitmap);
            _graphics.CopyFromScreen(this.Location.X + 190 , this.Location.Y + 40, 0,0, new Size(762, 440));
            bitmap.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
            bitmap = new Bitmap(Application.StartupPath + @"\Bill.Png");
            if (printDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select Agents.AgentID, Agents.AgentName, count(Orders.OrderID) as TotalOrders from Agents left join Orders on Agents.AgentID = Orders.AgentID group by Agents.AgentID, Agents.AgentName order by TotalOrders desc";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShowOutput.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select Items.ItemID, Items.ItemName, sum(OrderDetail.Quantity) as TotalQuantity from Items inner join OrderDetail on Items.ItemID = OrderDetail.ItemID group by Items.ItemID, Items.ItemName order by TotalQuantity desc";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShowOutput.DataSource = dt;
                da.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
