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
    public partial class DanhSachMuaBan : Form
    {
        
        string role, maNV, tenKH;

        public DanhSachMuaBan(string role, string maNV, string tenKH)
        {
            this.role = role;
            this.maNV = maNV;
            this.tenKH = tenKH;
            InitializeComponent();
        }
        void displayData()
        {
            dataGridView2.DataSource = DataAccess.getStoredProceduced("getHangHoaData");
            dataGridView2.Columns[0].HeaderText = "Mã hàng";
            dataGridView2.Columns[1].HeaderText = "Tên loại hàng";
            dataGridView2.Columns[2].HeaderText = "Tên hàng hóa";
            dataGridView2.Columns[4].HeaderText = "Đơn vị tính";
            dataGridView2.Columns[3].HeaderText = "Giá tiền";

            dataGridView2.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            txtMaKH.Text = tenKH;


        }
        void tableSelected()
        {
            int i = -1;
            i = dataGridView2.CurrentRow.Index;
            if (i > 0)
            {
                txtMahang.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
                txtTenhh.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                txtGiatien.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
               
            }
        }
        void TinhThanhTien()
        {
            double tongtien = 0;
            int num, cost;

            if (int.TryParse(txtSoLuong.Text, out num))
                if (int.TryParse(txtGiatien.Text, out cost))
                    tongtien = (double)cost * num;
                else
                    MessageBox.Show("Dữ liệu nhập vào sai định dạng",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtThanhTien.Text = tongtien.ToString();
        }
        double Total()
        {
            double tonghoadon = 0;
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                tonghoadon += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
            }
            return tonghoadon;
        }
        void AddProductToCart()
        {
            ListViewItem it = new ListViewItem(txtMahang.Text);
            it.SubItems.Add(txtTenhh.Text);
            it.SubItems.Add(txtSoLuong.Text);
            it.SubItems.Add(txtGiatien.Text);
            it.SubItems.Add(txtThanhTien.Text);
            listView1.Items.Add(it);
            MessageBox.Show("Đã thêm vào giỏ hàng",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        void cbBoxAddData()
        {
            string sql = "select * from KhachHang";
            SqlConnection conn = DataAccess.TaoKetNoi(); ;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbTenKH.DataSource = dataTable;
            cbTenKH.DisplayMember = "TenKH";
            cbTenKH.ValueMember = "MaKH";
            cbTenKH.SelectedIndex = -1;
        }
        private void DanhSachMuaBan_Load(object sender, EventArgs e)
        {
            displayData();
            cbBoxAddData();
            txtSoLuong.Enabled = false;
            txtMaKH.Text = "";
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }
        string maHD ;
        int countNum()
        {
            string sql = "select count(*) from CTHD where SoHD = '" + maHD + "' and MaHang = '" + txtMahang.Text + "'";
            int count = 0;
            count = Convert.ToInt32(DataAccess.CountData(sql));
            return count;
        }
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TinhThanhTien();
                string CTHD = "";
               if (countNum() >0)
                {
                    
                    CTHD = "update  CTHD set soluong = N'" + txtSoLuong.Text + "'where SoHD = '" + maHD + "' and MaHang = '" + txtMahang.Text + "'";
                    DataAccess.AddEditDelete(CTHD);
                    //ListViewItem item = listView1.SelectedItems[0];
                    //item.SubItems[0].Text = txtMahang.Text;
                    //item.SubItems[1].Text = txtTenhh.Text;
                    //item.SubItems[2].Text = txtSoLuong.Text;
                    //item.SubItems[3].Text = txtGiatien.Text;
                    //item.SubItems[4].Text = txtThanhTien.Text;

                }
                    
                else
                {
                    CTHD = "insert into CTHD (SoHD, MaHang, SoLuong, DonGia) values(N'" + maHD + "'" +
                       ", N'" + txtMahang.Text + "'" +
                       ", N'" + txtSoLuong.Text + "'" +
                       ", N'" + txtGiatien.Text + "'" + ")";
                    DataAccess.AddEditDelete(CTHD);
                    AddProductToCart();
                    
                }
                txtTongHoaDon.Text = Total().ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count >0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtMahang.Text = item.Text;
                txtTenhh.Text = item.SubItems[1].Text;
                txtSoLuong.Text = item.SubItems[2].Text;
                txtGiatien.Text = item.SubItems[3].Text;
            }
        }
        void Delete()
        {
            string sql = "delete from CTHD where SoHD = '" + maHD + "' and MaHang = '" + txtMahang.Text + "'";
            DataAccess.AddEditDelete(sql);
            int t = -1;
            for (int i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].SubItems[0].Text.Trim() == txtMahang.Text.Trim())
                {
                    t = i;
                    break;
                }
            if (t != -1)
            {
                listView1.Items.RemoveAt(t);
                MessageBox.Show("Đã xóa thông tin mặt hàng lựa chọn!",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyChung f = new QuanLyChung(role, "");
            f.Show();
            this.Close();
        }

        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
                
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string dl_sql = "update HoaDon set TongTien = N'" + txtTongHoaDon.Text + "' where SoHD = N'" + maHD+"'";
            DataAccess.AddEditDelete(dl_sql);
            MessageBox.Show("Đã thanh toán thành công!",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbDaiLy_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTT_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTenKH.SelectedItem != null)
            {
                txtMaKH.Text = cbTenKH.SelectedValue.ToString();
                if (txtMaKH.Text.Contains("KHDL"))
                    cbDaiLy.Checked = true;
                else if (txtMaKH.Text.Contains("KHTT"))
                    cbTT.Checked = true;
                else
                {
                    cbTT.Checked = false;
                    cbDaiLy.Checked = false;
                }
                txtSoLuong.Enabled = true;
            }

        }

        private void cbTenKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string sql_count = "";
            int count = 0;
            if (cbDaiLy.Checked && !cbTT.Checked)
            {
                sql_count = "select Count(*) from HoaDon  where SoHD like N'%HDDL%'";
                count = Convert.ToInt32(DataAccess.CountData(sql_count));
                maHD = "HDDL" + (count + 1);
            }

            else if (!cbDaiLy.Checked && cbTT.Checked)
            {
                sql_count = "select Count(*) from HoaDon  where SoHD like N'%HDTT%'";
                count = Convert.ToInt32(DataAccess.CountData(sql_count));
                maHD = "HDTT" + (count + 1);
            }

            string dl_sql = "insert into HoaDon values(N'" + maHD + "'" +
                        ", N'" + DateTime.Now.ToString() + "'" +
                        ", N'" + txtMaKH.Text + "'" +
                        ", N'" + maNV + "'" +
                        ", N'" + txtTongHoaDon.Text + "')";
            DataAccess.AddEditDelete(dl_sql);
            MessageBox.Show("Đã tạo hóa đơn thành công! \n Mã hóa đơn: " + maHD,
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTienKhach_KeyDown(object sender, KeyEventArgs e)
        {
            int tienKhach;
            if(e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtTienKhach.Text, out tienKhach))
                {
                    int traLai = 0;
                    traLai = tienKhach - Convert.ToInt32(txtTongHoaDon.Text);
                    txtTraLai.Text = traLai.ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin nhập sai, mời nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    txtTienKhach.Focus();
                    txtTienKhach.SelectAll();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon f = new QuanLyHoaDon(role);
            f.Show();
            this.Close();
        }
    }
}
