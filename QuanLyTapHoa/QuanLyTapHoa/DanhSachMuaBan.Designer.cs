
namespace QuanLyTapHoa
{
    partial class DanhSachMuaBan
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dbMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbDaiLy = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenhh = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.lvTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvmaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbMaHang,
            this.dbTenLoaiHang,
            this.dbTenHang,
            this.dbDonVi,
            this.dbDonGia});
            this.dataGridView2.Location = new System.Drawing.Point(535, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 255);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // dbMaHang
            // 
            this.dbMaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbMaHang.DataPropertyName = "MaHang";
            this.dbMaHang.HeaderText = "Mã hàng";
            this.dbMaHang.Name = "dbMaHang";
            this.dbMaHang.Width = 74;
            // 
            // dbTenLoaiHang
            // 
            this.dbTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbTenLoaiHang.DataPropertyName = "TenLoai";
            this.dbTenLoaiHang.HeaderText = "Tên loại hàng";
            this.dbTenLoaiHang.Name = "dbTenLoaiHang";
            // 
            // dbTenHang
            // 
            this.dbTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbTenHang.DataPropertyName = "TenHang";
            this.dbTenHang.HeaderText = "Tên hàng hóa";
            this.dbTenHang.Name = "dbTenHang";
            // 
            // dbDonVi
            // 
            this.dbDonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbDonVi.DataPropertyName = "DonVi";
            this.dbDonVi.HeaderText = "Đơn vị tính";
            this.dbDonVi.Name = "dbDonVi";
            this.dbDonVi.Width = 85;
            // 
            // dbDonGia
            // 
            this.dbDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbDonGia.DataPropertyName = "DonGia";
            this.dbDonGia.HeaderText = "Đơn giá";
            this.dbDonGia.Name = "dbDonGia";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(32, 102);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(182, 27);
            this.txtMaKH.TabIndex = 45;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã khách hàng";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(1183, 604);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(399, 583);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(159, 583);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 36);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thanh toán";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbTT.Location = new System.Drawing.Point(193, 33);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(156, 21);
            this.cbTT.TabIndex = 51;
            this.cbTT.Text = "Khách hàng thân thiết";
            this.cbTT.UseVisualStyleBackColor = true;
            this.cbTT.CheckedChanged += new System.EventHandler(this.cbTT_CheckedChanged);
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.AutoSize = true;
            this.cbDaiLy.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbDaiLy.Location = new System.Drawing.Point(31, 33);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Size = new System.Drawing.Size(134, 21);
            this.cbDaiLy.TabIndex = 50;
            this.cbDaiLy.Text = "Khách hàng đại lý";
            this.cbDaiLy.UseVisualStyleBackColor = true;
            this.cbDaiLy.CheckedChanged += new System.EventHandler(this.cbDaiLy_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Giá tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên hàng hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Mã hàng hóa";
            // 
            // txtGiatien
            // 
            this.txtGiatien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(296, 229);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(182, 27);
            this.txtGiatien.TabIndex = 56;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(300, 305);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(182, 27);
            this.txtSoLuong.TabIndex = 55;
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
            // 
            // txtTenhh
            // 
            this.txtTenhh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhh.Location = new System.Drawing.Point(32, 305);
            this.txtTenhh.Name = "txtTenhh";
            this.txtTenhh.Size = new System.Drawing.Size(182, 27);
            this.txtTenhh.TabIndex = 54;
            // 
            // txtMahang
            // 
            this.txtMahang.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahang.Location = new System.Drawing.Point(32, 229);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(182, 27);
            this.txtMahang.TabIndex = 53;
            // 
            // lvTen
            // 
            this.lvTen.Text = "Tên hàng hóa";
            this.lvTen.Width = 115;
            // 
            // lvSoluong
            // 
            this.lvSoluong.Text = "Số lượng";
            this.lvSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvSoluong.Width = 81;
            // 
            // lvGia
            // 
            this.lvGia.Text = "Giá tiền";
            this.lvGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvGia.Width = 72;
            // 
            // lvThanhTien
            // 
            this.lvThanhTien.Text = "Thành tiền";
            this.lvThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvThanhTien.Width = 119;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvmaHang,
            this.lvTen,
            this.lvSoluong,
            this.lvGia,
            this.lvThanhTien});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(708, 343);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 240);
            this.listView1.TabIndex = 61;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvmaHang
            // 
            this.lvmaHang.Text = "Mã hàng";
            this.lvmaHang.Width = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(159, 352);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(297, 27);
            this.txtThanhTien.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Tổng hóa đơn";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHoaDon.Location = new System.Drawing.Point(227, 419);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(297, 27);
            this.txtTongHoaDon.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(927, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 36);
            this.button1.TabIndex = 66;
            this.button1.Text = "Xem tổng số hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTenKH
            // 
            this.cbTenKH.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(285, 102);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(199, 31);
            this.cbTenKH.TabIndex = 67;
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.cbTenKH_SelectedIndexChanged);
            this.cbTenKH.SelectionChangeCommitted += new System.EventHandler(this.cbTenKH_SelectionChangeCommitted);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(173, 150);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 36);
            this.btnCreate.TabIndex = 68;
            this.btnCreate.Text = "Tạo hóa đơn";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Trả lại khách";
            // 
            // txtTraLai
            // 
            this.txtTraLai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraLai.Location = new System.Drawing.Point(227, 517);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.ReadOnly = true;
            this.txtTraLai.Size = new System.Drawing.Size(297, 27);
            this.txtTraLai.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Khách đưa";
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhach.Location = new System.Drawing.Point(227, 465);
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(297, 27);
            this.txtTienKhach.TabIndex = 71;
            this.txtTienKhach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTienKhach_KeyDown);
            // 
            // DanhSachMuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 652);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTienKhach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTraLai);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbTenKH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenhh);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.cbTT);
            this.Controls.Add(this.cbDaiLy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.Name = "DanhSachMuaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachMuaBan";
            this.Load += new System.EventHandler(this.DanhSachMuaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDonGia;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbDaiLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenhh;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.ColumnHeader lvTen;
        private System.Windows.Forms.ColumnHeader lvSoluong;
        private System.Windows.Forms.ColumnHeader lvGia;
        private System.Windows.Forms.ColumnHeader lvThanhTien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader lvmaHang;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienKhach;
    }
}