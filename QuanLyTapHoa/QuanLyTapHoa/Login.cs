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

namespace QuanLyTapHoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {
            label4.Hide();
            txtConfirmPass.Hide();
            txt_user.Focus();
        }
        bool Check()
        {
                string user = txt_user.Text;
                SqlCommand cmd = new SqlCommand("ChecKRole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", user);
                string check = cmd.ExecuteScalar().ToString();
                if (check == "admin")
                    return true;
                return false;
        }
        private void btn_log_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", txt_user.Text);
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                string check = cmd.ExecuteScalar().ToString();

                if (check == "1")
                {
                    String role = DataAccess.CountData("Select Quyen from NhanVien where MaNV = '" + txt_user.Text + "'");
                    QuanLyChung f =  new QuanLyChung(role, txt_user.Text);
                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong username or password!");
            }

        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_role_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("CheckLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", txt_user.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                    string check = cmd.ExecuteScalar().ToString();

                    if (check == "1")
                    {
                        string role = DataAccess.CountData("Select Quyen from NhanVien where MaNV = '" + txt_user.Text + "'");

                        QuanLyChung f = new QuanLyChung(role, txt_user.Text);
                        f.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Wrong username or password!");
                
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Show();
            txtConfirmPass.Show();
            Boolean check = false, check1 = false;
            string count = "Select count (*) from NhanVien where MaNV = '" + txt_user.Text + "' and MatKhau = '" + txt_pass.Text + "'";
            int dem = Convert.ToInt32(DataAccess.CountData(count));
            if (dem > 0)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "Update NhanVien set MatKhau = '" + txt_pass.Text + "' where MaNV = '"+txt_user.Text+"'";
                if (txt_pass.Text == txtConfirmPass.Text && txt_pass.Text != "" && txtConfirmPass.Text != "")
                {
                    if (txt_pass.Text != txtConfirmPass.Text)
                        check1 = true;
                    else
                    {
                        DataAccess.AddEditDelete(sql);
                        check = true;
                    }
                }
            }
            if (check == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(check1 == true)
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_pass.PasswordChar = (char)0;
                txt_pass.UseSystemPasswordChar = false;
                
                
                
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_pass.UseSystemPasswordChar = true;
                
                
            }
        }
    }
}
