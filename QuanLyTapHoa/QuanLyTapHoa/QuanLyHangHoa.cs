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
    public partial class QuanLyHangHoa : Form
    {
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
        string role;
        public QuanLyHangHoa(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private static string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTapHoa;Integrated Security=True";
        void cbBoxAddData()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from LoaiHang", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string value = read.GetString(0);
                cbMaloai.Items.Add(value);
                
            }
            cbMaloai.ValueMember = "TenLoai";
            cbMaloai.DisplayMember = "MaLoai";
            read.Close();
        }
        void displayData()
        {
            dataGridView1.DataSource = DataAccess.getStoredProceduced("getHangHoaData");
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên loại hàng";
            dataGridView1.Columns[2].HeaderText = "Tên hàng hóa";
            dataGridView1.Columns[4].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[3].HeaderText = "Giá tiền";

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode =
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

            txtMahang.Enabled = false;
            txtTenhh.Enabled = false;
            txtDonvitinh.Enabled = false;
            txtGiatien.Enabled = false;
            cbMaloai.Enabled = false;
            displayData();
            cbBoxAddData();
            

        }
        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from HangHoa where MaHang=N'" + txtMahang.Text + "'";
                DataAccess.AddEditDelete(sql);
                displayData();
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void them()
        {
            if (btnThem.Text == THEM)
            {
                txtMahang.Enabled = true;
                txtTenhh.Enabled = true;
                txtDonvitinh.Enabled = true;
                txtGiatien.Enabled = true;
                cbMaloai.Enabled = true;
                txtMahang.Clear();
                txtTenhh.Clear();
                txtDonvitinh.Clear();
                txtGiatien.Clear();

                btnSua.Enabled = false;
                btnTim.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = LUUBANGHI;
            }
            else
            {
                if (txtMahang.Text != " " && txtTenhh.Text != " " && txtDonvitinh.Text != " " && txtGiatien.Text != " ")
                {
                    string sql = "insert into HangHoa values(N'" +
                                  txtMahang.Text + "', N'" +
                                  cbMaloai.SelectedItem.ToString() + "', N'" +
                                  txtTenhh.Text + "', N'" +
                                   txtDonvitinh.Text + "', N'" +
                                   txtGiatien.Text + "')";
                    DataAccess.AddEditDelete(sql);
                    displayData();
                    txtMahang.Enabled = false;
                    txtTenhh.Enabled = false;
                    txtDonvitinh.Enabled = false;
                    txtGiatien.Enabled = false;
                    cbMaloai.Enabled = false;

                    btnThem.Text = THEM;
                    btnXoa.Enabled = true;
                    btnTim.Enabled = true;
                    btnSua.Enabled = true;
                    KhoiPhuc(cr);
                }
            }
        }
        public void sua()
        {
            if (btnSua.Text == SUA)
            {
                txtMahang.Enabled = true;
                txtTenhh.Enabled = true;
                txtDonvitinh.Enabled = true;
                txtGiatien.Enabled = true;
                cbMaloai.Enabled = true;
                btnSua.Text = LUUSUA;
                txtMahang.Focus();
            }
            else
            {
                string sql = "update HangHoa set TenHang =N'" +
                    txtTenhh.Text + "', DonGia =N'" +
                    txtGiatien.Text + "', DonVi =N'" +
                    txtDonvitinh.Text + "', MaLoai =N'"+
                    cbMaloai.SelectedItem.ToString() + "' where MaHang=N'" +
                    txtMahang.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("SELECT  HangHoa.MaHang, LoaiHang.TenLoai, HangHoa.TenHang,HangHoa.DonVi, HangHoa.DonGia FROM HangHoa" +
                        " INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai");

                txtMahang.Enabled = false;
                txtTenhh.Enabled = false;
                txtDonvitinh.Enabled = false;
                txtGiatien.Enabled = false;
                cbMaloai.Enabled = false;

                btnSua.Text = SUA;
                btnXoa.Enabled = true;
                btnTim.Enabled = true;
                btnExit.Enabled = true;
                KhoiPhuc(cr);
                MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtMahang.Clear();
                txtTenhh.Clear();
                txtDonvitinh.Clear();
                txtGiatien.Clear();

                txtMahang.Enabled = false;
                txtDonvitinh.Enabled = false;
                txtGiatien.Enabled = false;
                txtTenhh.Focus();
                txtTenhh.Enabled = true;

                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnTim.Text = "Tìm";

            }
            else
            {
                string sql;
                if (txtTenhh.Text.Trim() == "")
                    sql = "SELECT  HangHoa.MaHang, LoaiHang.TenLoai, HangHoa.TenHang,  HangHoa.DonVi, HangHoa.DonGia FROM HangHoa" +
                        " INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai";
                else
                    sql = "SELECT  HangHoa.MaHang, LoaiHang.TenLoai, HangHoa.TenHang, HangHoa.DonVi, HangHoa.DonGia FROM HangHoa" +
                        " INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai where TenHang like N'%" +
                    txtTenhh.Text + "%'";

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
            txtMahang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbMaloai.DisplayMember = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTenhh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDonvitinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGiatien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            
        }
        void tableSelected()
        {
            int i = -1;
            i = dataGridView1.CurrentRow.Index;
            if(i>=0)
            {
                string sql = "select MaLoai from LoaiHang where TenLoai = N'" + dataGridView1.Rows[i].Cells["dbTenLoaiHang"].Value.ToString() + "'";
                txtMahang.Text = dataGridView1.Rows[i].Cells["dbMaHang"].Value.ToString();
                //string maloai = DataAccess.DataReader(sql);
                //Console.WriteLine(maloai);
                cbMaloai.Text =/* dataGridView1.Rows[i].Cells[1].Value */DataAccess.DataReader(sql);
                txtTenhh.Text = dataGridView1.Rows[i].Cells["dbTenHang"].Value.ToString();
               
                txtGiatien.Text = dataGridView1.Rows[i].Cells["dbDonGia"].Value.ToString();
                txtDonvitinh.Text = dataGridView1.Rows[i].Cells["dbDonVi"].Value.ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyChung f = new QuanLyChung(role," ");
            f.Show();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
