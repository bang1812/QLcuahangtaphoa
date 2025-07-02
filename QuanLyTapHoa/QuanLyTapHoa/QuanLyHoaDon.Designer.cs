
namespace QuanLyTapHoa
{
    partial class QuanLyHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quanLyTapHoaDataSet1 = new QuanLyTapHoa.QuanLyTapHoaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dbHD = new System.Windows.Forms.DataGridView();
            this.dbMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbNgayXuatHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbmaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaMatHang = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTapHoaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHD)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyTapHoaDataSet1
            // 
            this.quanLyTapHoaDataSet1.DataSetName = "QuanLyTapHoaDataSet";
            this.quanLyTapHoaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(607, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(611, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập thông tin tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnTim.Location = new System.Drawing.Point(1223, 116);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(196, 58);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Search";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dbHD
            // 
            this.dbHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbMaHD,
            this.dbKhachHang,
            this.dbTenhang,
            this.dbSoLuong,
            this.dbDongia,
            this.dbMaNV,
            this.dbNgayXuatHD});
            this.dbHD.Location = new System.Drawing.Point(649, 192);
            this.dbHD.Margin = new System.Windows.Forms.Padding(4);
            this.dbHD.Name = "dbHD";
            this.dbHD.RowHeadersWidth = 51;
            this.dbHD.Size = new System.Drawing.Size(1133, 449);
            this.dbHD.TabIndex = 4;
            this.dbHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbHD_CellDoubleClick);
            this.dbHD.SelectionChanged += new System.EventHandler(this.dbHD_SelectionChanged);
            // 
            // dbMaHD
            // 
            this.dbMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbMaHD.DataPropertyName = "SoHD";
            this.dbMaHD.HeaderText = "Mã hóa đơn";
            this.dbMaHD.MinimumWidth = 6;
            this.dbMaHD.Name = "dbMaHD";
            this.dbMaHD.Width = 103;
            // 
            // dbKhachHang
            // 
            this.dbKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbKhachHang.DataPropertyName = "TenKH";
            this.dbKhachHang.HeaderText = "Khách hàng";
            this.dbKhachHang.MinimumWidth = 6;
            this.dbKhachHang.Name = "dbKhachHang";
            // 
            // dbTenhang
            // 
            this.dbTenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbTenhang.DataPropertyName = "TenHang";
            this.dbTenhang.HeaderText = "Tên mặt hàng";
            this.dbTenhang.MinimumWidth = 6;
            this.dbTenhang.Name = "dbTenhang";
            this.dbTenhang.Width = 115;
            // 
            // dbSoLuong
            // 
            this.dbSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbSoLuong.DataPropertyName = "SoLuong";
            this.dbSoLuong.HeaderText = "Số lượng";
            this.dbSoLuong.MinimumWidth = 6;
            this.dbSoLuong.Name = "dbSoLuong";
            this.dbSoLuong.Width = 86;
            // 
            // dbDongia
            // 
            this.dbDongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbDongia.DataPropertyName = "DonGia";
            this.dbDongia.HeaderText = "Đơn giá";
            this.dbDongia.MinimumWidth = 6;
            this.dbDongia.Name = "dbDongia";
            this.dbDongia.Width = 63;
            // 
            // dbMaNV
            // 
            this.dbMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbMaNV.DataPropertyName = "MaNV";
            this.dbMaNV.HeaderText = "Mã nhân viên";
            this.dbMaNV.MinimumWidth = 6;
            this.dbMaNV.Name = "dbMaNV";
            this.dbMaNV.Width = 112;
            // 
            // dbNgayXuatHD
            // 
            this.dbNgayXuatHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbNgayXuatHD.DataPropertyName = "NgayBan";
            this.dbNgayXuatHD.HeaderText = "Ngày tạo hóa đơn";
            this.dbNgayXuatHD.MinimumWidth = 6;
            this.dbNgayXuatHD.Name = "dbNgayXuatHD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(49, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(52, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày xuất hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(51, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(51, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.Location = new System.Drawing.Point(361, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label8.Location = new System.Drawing.Point(361, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.Location = new System.Drawing.Point(361, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã mặt hàng";
            // 
            // txtmaHD
            // 
            this.txtmaHD.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtmaHD.Location = new System.Drawing.Point(47, 215);
            this.txtmaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(221, 36);
            this.txtmaHD.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtGia.Location = new System.Drawing.Point(367, 219);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(233, 36);
            this.txtGia.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtSoLuong.Location = new System.Drawing.Point(367, 300);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(233, 36);
            this.txtSoLuong.TabIndex = 15;
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Enabled = false;
            this.dtNgayXuat.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.dtNgayXuat.Location = new System.Drawing.Point(81, 460);
            this.dtNgayXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(507, 36);
            this.dtNgayXuat.TabIndex = 16;
            // 
            // cbmaKH
            // 
            this.cbmaKH.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cbmaKH.FormattingEnabled = true;
            this.cbmaKH.Location = new System.Drawing.Point(55, 300);
            this.cbmaKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbmaKH.Name = "cbmaKH";
            this.cbmaKH.Size = new System.Drawing.Size(221, 37);
            this.cbmaKH.TabIndex = 17;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(53, 378);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(221, 37);
            this.cbMaNV.TabIndex = 18;
            // 
            // cbMaMatHang
            // 
            this.cbMaMatHang.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cbMaMatHang.FormattingEnabled = true;
            this.cbMaMatHang.Location = new System.Drawing.Point(367, 382);
            this.cbMaMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaMatHang.Name = "cbMaMatHang";
            this.cbMaMatHang.Size = new System.Drawing.Size(233, 37);
            this.cbMaMatHang.TabIndex = 19;
            this.cbMaMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMaMatHang_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnXoa.Location = new System.Drawing.Point(243, 560);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 58);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnExit.Location = new System.Drawing.Point(1641, 666);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 58);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnPrint.Location = new System.Drawing.Point(1127, 666);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(196, 58);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtTim.Location = new System.Drawing.Point(769, 127);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(384, 36);
            this.txtTim.TabIndex = 2;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 738);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbMaMatHang);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.cbmaKH);
            this.Controls.Add(this.dtNgayXuat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtmaHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbHD);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTapHoaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyTapHoaDataSet quanLyTapHoaDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dbHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.ComboBox cbmaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaMatHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbNgayXuatHD;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtTim;
    }
}