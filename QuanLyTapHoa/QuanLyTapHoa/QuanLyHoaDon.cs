using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTapHoa
{
    public partial class QuanLyHoaDon : Form
    {
        string role;
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
        public QuanLyHoaDon(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        void displayData()
        {
            string sql = " SELECT  HoaDon.SoHD,  KhachHang.TenKH,  HangHoa.TenHang,  CTHD.SoLuong,  CTHD.DonGia,  HoaDon.MaNV , HoaDon.NgayBan" +
                " FROM HoaDon  " +
                " INNER JOIN CTHD ON CTHD.SoHD = HoaDon.SoHD  " +
                " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
                " INNER JOIN HangHoa ON CTHD.MaHang = HangHoa.MaHang";
            dbHD.DataSource =
                DataAccess.GetTable(sql);
        }
        
        
        private int cr;

        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from CTHD where SOHD=N'" + txtmaHD.Text + "'";
                DataAccess.AddEditDelete(sql);
                string newSQL = "delete from HoaDon where SOHD=N'" + txtmaHD.Text + "'";
                DataAccess.AddEditDelete(newSQL);
                displayData();
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //public void them()
        //{
        //    bool trangthai = true;
        //    if (btnThem.Text == THEM)
        //    {
                
        //        btnThem.Text = THEM;
        //        btnSua.Text = SUA;
        //        btnXoa.Text = XOA;
        //        btnExit.Text = THOAT;
        //        btnTim.Text = TIMKIEM;

        //        txtmaHD.Enabled = trangthai;
        //        cbmaKH.Enabled = trangthai;
        //        cbMaMatHang.Enabled = trangthai;
        //        txtSoLuong.Enabled = trangthai;
        //        txtGia.Enabled = trangthai;
        //        cbMaNV.Enabled = trangthai;


               
        //        txtmaHD.Clear();
        //        txtGia.Clear();
        //        txtSoLuong.Clear();

                
        //        btnTim.Enabled = false;
        //        btnXoa.Enabled = false;
               
        //    }
        //    else
        //    {
        //        if (txtmaHD.Text != " " && txtGia.Text != " " && txtSoLuong.Text != " ")
        //        {
        //            string hDsql = "insert into HoaDon values(N'" +
        //                          txtmaHD.Text + "', N'" +
        //                          dtNgayXuat.Value.ToString() + "', N'" +
        //                          cbmaKH.SelectedItem.ToString() + "', N'" +
        //                          cbMaNV.SelectedItem.ToString() + "')";
        //            DataAccess.AddEditDelete(hDsql);
        //            string CTHD = "insert into CT_HD values(N'" +
        //                          txtmaHD.Text + "', N'" +
        //                          cbMaMatHang.SelectedItem.ToString() + "', N'" +
        //                          txtSoLuong.Text + "', N'" +
        //                          txtGia.Text + "')";
        //            DataAccess.AddEditDelete(CTHD);
        //            displayData();
        //            txtmaHD.Enabled = !trangthai;
        //            cbmaKH.Enabled = !trangthai;
        //            cbMaMatHang.Enabled = !trangthai;
        //            txtSoLuong.Enabled = !trangthai;
        //            txtGia.Enabled = !trangthai;
        //            cbMaNV.Enabled = !trangthai;

        //            btnThem.Text = THEM;
        //            btnXoa.Enabled = true;
        //            btnTim.Enabled = true;
        //            btnSua.Enabled = true;
        //            KhoiPhuc(cr);
        //        }
        //    }
        //}
        
        //public void thoat()
        //{
        //    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (rs == DialogResult.Yes)
        //    {
        //        this.Close();
        //    }
        //    else if (rs == DialogResult.No)
        //    {
        //        KhoiPhuc(cr);
        //    }
        //}
        //private void TimKiem()
        //{
        //    if (btnTim.Text == TIMKIEM)
        //    {
        //        txtMahang.Clear();
        //        txtTenhh.Clear();
        //        txtGiatien.Clear();
        //        txtDonvitinh.Clear();

        //        txtMahang.Enabled = false;
        //        txtGiatien.Enabled = false;
        //        txtDonvitinh.Enabled = false;
        //        txtTenhh.Focus();
        //        txtTenhh.Enabled = true;

        //        btnSua.Enabled = false;
        //        btnThem.Enabled = false;
        //        btnXoa.Enabled = false;
        //        btnTim.Text = "Tìm";

        //    }
        //    else
        //    {
        //        string sql;
        //        if (txtTenhh.Text.Trim() == "")
        //            sql = "SELECT  HangHoa.MaHang, LoaiHang.TenLoai, HangHoa.TenHang,  HangHoa.DonVi, HangHoa.DonGia FROM HangHoa" +
        //                " INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai";
        //        else
        //            sql = "SELECT  HangHoa.MaHang, LoaiHang.TenLoai, HangHoa.TenHang, HangHoa.DonVi, HangHoa.DonGia FROM HangHoa" +
        //                " INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai where TenHang like N'%" +
        //            txtTenhh.Text + "'";

        //        dataGridView1.DataSource = DataAccess.GetTable(sql);

        //        btnSua.Enabled = true;
        //        btnThem.Enabled = true;
        //        btnXoa.Enabled = true;
        //        btnTim.Text = TIMKIEM;
        //        KhoiPhuc(cr);
        //    }
        //}
        private void KhoiPhuc(int i)
        {
            string makh = DataAccess.CountData("select MaKH from KhachHang where TenKH like N'%" + dbHD.Rows[i].Cells[1].Value.ToString() + "%'");
            txtmaHD.Text = dbHD.Rows[i].Cells[0].Value.ToString();
            cbmaKH.DisplayMember = makh;
            cbMaMatHang.Text = dbHD.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dbHD.Rows[i].Cells[3].Value.ToString();
            txtGia.Text = dbHD.Rows[i].Cells[4].Value.ToString();
            cbMaNV.Text = dbHD.Rows[i].Cells[5].Value.ToString();
            dtNgayXuat.Value = (DateTime)dbHD.Rows[i].Cells[6].Value;
        }
        void tableSelected()
        {
            int i = -1;
            i = dbHD.CurrentRow.Index;
            if (i >= 0)
            {
                txtmaHD.Text = dbHD.Rows[i].Cells[0].Value.ToString();

            }
        }
        void Combobox_Item()
        {
            string sql = "select maNV from NhanVien";
            cbMaNV.Items.AddRange(DataAccess.cbBoxAddData(sql).ToArray());
            string sqls = "select maKH from KhachHang";
            cbmaKH.Items.AddRange(DataAccess.cbBoxAddData(sqls).ToArray());
            string sqlss = "select MaHang from HangHoa";
            cbMaMatHang.Items.AddRange(DataAccess.cbBoxAddData(sqlss).ToArray());

            cbMaNV.SelectedIndex = 0;
            cbmaKH.SelectedIndex = 0;
            cbMaMatHang.SelectedIndex = 0;
        }
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            displayData();
            //btnThem.Text = THEM;
            //btnSua.Text = SUA;
            btnXoa.Text = XOA;
            btnExit.Text = THOAT;
            btnTim.Text = TIMKIEM;

            txtmaHD.Enabled = false;
            cbmaKH.Enabled = false;
            cbMaMatHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = false;
            cbMaNV.Enabled = false;
            if (role == "admin")
            {
                btnXoa.Enabled = true;
            }
            else
                btnXoa.Enabled = false;
            Combobox_Item();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            QuanLyChung f = new QuanLyChung(role, " ");
            f.Show();
            this.Close();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select DonGia from HangHoa where MaHang like N'%" + cbMaMatHang.Text + "%'";
            txtGia.Text = DataAccess.CountData(sql);
        }

        private void dbHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "exported_data.xlsx"; // Tên mặc định cho file Excel

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Ghi dữ liệu từ DataGridView vào file Excel
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 1, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                        }
                    }

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Export completed successfully.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcel(dbHD);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void dbHD_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() == "")
            {
                string sql = " SELECT  HoaDon.SoHD,  KhachHang.TenKH,  HangHoa.TenHang,  CTHD.SoLuong,  CTHD.DonGia,  HoaDon.MaNV , HoaDon.NgayBan" +
                " FROM HoaDon  " +
                " INNER JOIN CTHD ON CTHD.SoHD = HoaDon.SoHD  " +
                " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
                " INNER JOIN HangHoa ON CTHD.MaHang = HangHoa.MaHang";
                dbHD.DataSource =
                    DataAccess.GetTable(sql);
            }
            else
            {
                string sql = " SELECT  HoaDon.SoHD,  KhachHang.TenKH,  HangHoa.TenHang,  CTHD.SoLuong,  CTHD.DonGia,  HoaDon.MaNV , HoaDon.NgayBan" +
                " FROM HoaDon  " +
                " INNER JOIN CTHD ON CTHD.SoHD = HoaDon.SoHD  " +
                " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
                " INNER JOIN HangHoa ON CTHD.MaHang = HangHoa.MaHang where KhachHang.TenKH like N'%"+txtTim.Text+"%'";
                dbHD.DataSource =
                    DataAccess.GetTable(sql);
            }
               

            
               
            
                
            
        }
    }
}
