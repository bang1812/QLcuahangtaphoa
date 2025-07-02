using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTapHoa
{
    public partial class QuanLyChung : Form
    {
        string role;
        string maNV;
        public QuanLyChung(string role, string maNV)
        {
            InitializeComponent();
            this.role = role;
            this.maNV = maNV;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            DanhSachMuaBan f = new DanhSachMuaBan(role, maNV," ");
            f.Show();
            this.Close();
            
        }

        private void ptbLoai_Click(object sender, EventArgs e)
        {
            QuanLyLoaiHang f = new QuanLyLoaiHang(role);
            f.Show();
            this.Close();
            
        }

        private void ptbKhach_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang  f = new QuanLyKhachHang(role,maNV, "");
            f.Show();
            this.Close();
            
        }

        private void ptbSanpham_Click(object sender, EventArgs e)
        {
            QuanLyHangHoa f = new QuanLyHangHoa(role);
            f.Show();
            this.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void QuanLyChung_Load(object sender, EventArgs e)
        {
            if(role != "admin")
            {
                lbTongKet.Enabled = false;
                ptbTongket.Enabled = false;
                
            }
            else if(role.Equals("admin"))
            {
                lbTongKet.Enabled = true;
                ptbTongket.Enabled = true;
            }
            
        }

        private void ptbTongket_Click(object sender, EventArgs e)
        {
            TongKet f = new TongKet(role);
            f.Show();
            this.Hide();
        }
    }
}
