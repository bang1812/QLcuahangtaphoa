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
    public partial class QuanLyKhachHang : Form
    {
        public string _text { get; set; }
        string role, maNV;
        public QuanLyKhachHang(string role, string maNV, string _text)
        {
            InitializeComponent();
            this.role = role;
            this.maNV = maNV;
            this._text = _text;
        }
        #region Hằng xâu 
        string THEM = "Thêm";
        string HUY = "Hủy";
        string LUUSUA = "Lưu sửa";
        string LUUBANGHI = "Lưu thêm";
        string SUA = "Sửa";
        string XOA = "Xóa";
        string THOAT = "Thoát";
        string TIMKIEM = "Tìm kiếm";
        #endregion
        bool CheckMa(string text)
        {
            string sql = "select count(*) from KhachHang where MaKH like N'%" + text + "%'";
            int count = -1;
            count = Convert.ToInt32(DataAccess.CountData(sql));
            if (count <= 0)
                return true;
            return false;
        }
        void displayData()
        {
            dataGridView1.DataSource = DataAccess.GetTable("select * from KhachHang");

            dbMaKH.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbTenKh.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbDiaChi.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbEmail.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbDienThoai.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }
        private int cr;
        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            btnThem.Text = THEM;
            btnSua.Text = SUA;
            btnXoa.Text = XOA;
            btnExit.Text = THOAT;
            btnTim.Text = TIMKIEM;

            
            txtEmail.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            displayData();
            


        }
        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from KhachHang where MaKH like N'" + txtMaKH.Text + "'";
                DataAccess.AddEditDelete(sql);
                displayData();
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void them()
        {
            if (btnThem.Text == THEM)
            {
                txtEmail.Enabled = true;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();

                btnSua.Enabled = false;
                btnTim.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = LUUBANGHI;
            }
            else
            {
                if (txtEmail.Text != " " && txtTenKH.Text != " " && txtSDT.Text != " " && txtDiaChi.Text != " ")
                {
                    if(CheckMa(txtMaKH.Text))
                    {
                        string sql = "insert into KhachHang values(N'" + txtMaKH.Text + "'" +
                        ", N'" + txtTenKH.Text + "'" +
                        ", N'" + txtDiaChi.Text + "'" +
                        ", N'" + txtEmail.Text + "'" +
                        ", N'" + txtSDT.Text + "')";
                        DataAccess.AddEditDelete(sql);
                        displayData();
                        txtEmail.Enabled = false;
                        txtTenKH.Enabled = false;
                        txtSDT.Enabled = false;
                        txtDiaChi.Enabled = false;


                        btnThem.Text = THEM;
                        btnXoa.Enabled = true;
                        btnTim.Enabled = true;
                        btnSua.Enabled = true;
                        MessengerNotify();
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại trong cơ sở dữ liệu, mời nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaKH.Focus();
                        txtMaKH.SelectAll();
                    }
                    
                }
            }
        }
        public void sua()
        {
            if (btnSua.Text == SUA)
            {
                txtEmail.Enabled = true;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                
                btnSua.Text = LUUSUA;
                txtEmail.Focus();
            }
            else
            {
                string sql = "update KhachHang set TenKH =N'" + txtTenKH.Text + "'" +
                    ", DienThoai =N'" +  txtSDT.Text + "'" +
                    ", DiaChi =N'" + txtDiaChi.Text +    "' " +
                    ", Email =N'" + txtEmail.Text + "' " +
                    "where MaKH=N'" +
                    txtMaKH.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("SELECT  * from KhachHang");

                txtEmail.Enabled = false;
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;

                btnSua.Text = SUA;
                btnXoa.Enabled = true;
                btnTim.Enabled = true;
                btnExit.Enabled = true;
                KhoiPhuc(cr);
                MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void MessengerNotify()
        {
            DialogResult rs = MessageBox.Show("Thêm thông tin khách hàng thành công, Bạn có muốn quay lại chương trình hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DanhSachMuaBan f = new DanhSachMuaBan(role, maNV, txtMaKH.Text);
                f.Show();
                this.Hide();
            }
            else if (rs == DialogResult.No)
            {
                KhoiPhuc(cr);
            }
        }
        public void thoat()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
            else if (rs == DialogResult.No)
            {
                KhoiPhuc(cr);
            }
        }
        private void TimKiem()
        {
            if (btnTim.Text == TIMKIEM)
            {
                txtMaKH.Clear();
                txtEmail.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();

                txtMaKH.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtTenKH.Focus();
                txtTenKH.Enabled = true;

                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnTim.Text = "Tìm";

            }
            else
            {
                string sql;
                if (txtTenKH.Text.Trim() == "")
                    sql = "SELECT  * from KhachHang";
                else
                    sql = "SELECT  * from KhachHang where TenKH like N'%" +
                    txtTenKH.Text + "'";

                dataGridView1.DataSource = DataAccess.GetTable(sql);

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTim.Text = TIMKIEM;
                KhoiPhuc(cr);
            }
        }
        private void KhoiPhuc(int i)
        {
            txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        void tableSelected()
        {
            int i = -1;
            i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them();
            
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            displayData();
            cbDaiLy.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyChung f = new QuanLyChung(role, " ");
            f.Show();
            this.Close();
        }

        private void cbDaiLy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDaiLy.Checked)
            {
                txtMaKH.Text = "KHDL";
                cbTT.Checked = false;
            }
        }

        private void cbTT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTT.Checked)
            {
                txtMaKH.Text = "KHTT";
                cbDaiLy.Checked = false;
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTenKH.Focus();
        }

        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSDT.Focus();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DanhSachMuaBan f = new DanhSachMuaBan(role, maNV, txtMaKH.Text);
            f.Show();
            this.Hide();
        }
    }
}
