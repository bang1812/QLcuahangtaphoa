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
    public partial class TongKet : Form
    {
        string role;
        public TongKet(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void TongKet_Load(object sender, EventArgs e)
        {
            string sql = "select NhanVien.MaNV, NhanVien.TenNV, HoaDon.NgayBan, HoaDon.TongTien from NhanVien inner join HoaDon on NhanVien.MaNV = HoaDon.MaNV";
            dataGridView1.DataSource = DataAccess.GetTable(sql);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QuanLyChung f = new QuanLyChung(role, " ");
            f.Show();
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select sum(TongTien) from HoaDon where NgayBan Like N'%" + dateTimePicker1.Value.ToShortDateString() + "%'";
            string Result = DataAccess.CountData(sql);
            MessageBox.Show("Tổng doanh thu ngày " + dateTimePicker1.Value.ToShortDateString() + " là: " + Result, "Tổng doanh thu", MessageBoxButtons.OK);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = -1;
            i = dataGridView1.CurrentRow.Index;
            if (i > 0)
            {
                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            }
        }
    }
}
