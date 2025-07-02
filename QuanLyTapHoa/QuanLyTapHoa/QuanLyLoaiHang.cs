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
    public partial class QuanLyLoaiHang : Form
    {
        string role;
        public QuanLyLoaiHang(string role)
        {
            InitializeComponent();
            this.role = role;
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
        void dataDisplay()
        {
            dbloaihang.DataSource =
                DataAccess.GetTable("select * from LoaiHang");

            dbMaLoai.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbTenLoai.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from LoaiHang where MaLoai=N'" + txtmaLoai.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataDisplay();
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int cr;
        public void them()
        {
            if (btnAdd.Text == THEM)
            {
                txtmaLoai.Enabled = true;
                txtTenLoai.Enabled = true;
                txtmaLoai.Clear();
                txtTenLoai.Clear();

                btnUpdate.Enabled = false;
                btnSearch.Enabled = false;
                btnDel.Enabled = false;
                btnAdd.Text = LUUBANGHI;
            }
            else
            {
                if (txtmaLoai.Text != " " && txtTenLoai.Text != " ")
                {
                    string sql = "insert into LoaiHang values(N'" +
                                  txtmaLoai.Text + "', N'" +
                                  
                                  txtTenLoai.Text +  "')";
                    DataAccess.AddEditDelete(sql);
                    dataDisplay();
                    txtmaLoai.Enabled = false;
                    txtTenLoai.Enabled = false;

                    btnAdd.Text = THEM;
                    btnDel.Enabled = true;
                    btnSearch.Enabled = true;
                    btnUpdate.Enabled = true;
                    KhoiPhuc(cr);
                }
            }
        }
        public void sua()
        {
            if (btnUpdate.Text == SUA)
            {
                txtmaLoai.Enabled = true;
                txtTenLoai.Enabled = true;
                btnUpdate.Text = LUUSUA;
                txtmaLoai.Focus();
            }
            else
            {
                string sql = "update LoaiHang set TenLoai =N'" +
                    txtTenLoai.Text +  "' where MaLoai=N'" +
                    txtmaLoai.Text + "'";
                DataAccess.AddEditDelete(sql);
                dbloaihang.DataSource = DataAccess.GetTable("select * from LoaiHang");

                txtmaLoai.Enabled = false;
                txtTenLoai.Enabled = false;

                btnAdd.Text = THEM;
                btnDel.Enabled = true;
                btnSearch.Enabled = true;
                btnUpdate.Enabled = true;
                

                btnUpdate.Text = SUA;
                
                
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
            if (btnSearch.Text == TIMKIEM)
            {
                txtmaLoai.Clear();
                txtTenLoai.Clear();
                

                txtmaLoai.Enabled = false;
                txtTenLoai.Enabled = true;

                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnSearch.Text = "Tìm";

            }
            else
            {
                string sql;
                if (txtTenLoai.Text.Trim() == "")
                    sql = "select * from LoaiHang";
                else
                    sql = "SELECT  * from LoaiHang where TenLoai like N'%" +
                    txtTenLoai.Text + "%'";

                dbloaihang.DataSource = DataAccess.GetTable(sql);

                btnUpdate.Enabled = true;
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnSearch.Text = TIMKIEM;
                KhoiPhuc(cr);
            }
        }
        private void KhoiPhuc(int i)
        {
            txtmaLoai.Text = dbloaihang.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Text = dbloaihang.Rows[i].Cells[1].Value.ToString();
        }
        void tableSelected()
        {
            int i = -1;
            i = dbloaihang.CurrentRow.Index;
            if (i >= 0)
            {
                txtmaLoai.Text = dbloaihang.Rows[i].Cells[0].Value.ToString();
                txtTenLoai.Text = dbloaihang.Rows[i].Cells[1].Value.ToString();
            }
        }
        private void QuanLyLoaiHang_Load(object sender, EventArgs e)
        {
            dataDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            them();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyChung f = new QuanLyChung(role," ");
            f.Show();
            this.Close();
        }

        private void dbloaihang_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }
    }
}
