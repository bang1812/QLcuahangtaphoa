
namespace QuanLyTapHoa
{
    partial class QuanLyHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTapHoaDataSet = new QuanLyTapHoa.QuanLyTapHoaDataSet();
            this.hangHoaTableAdapter = new QuanLyTapHoa.QuanLyTapHoaDataSetTableAdapters.HangHoaTableAdapter();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTenhh = new System.Windows.Forms.TextBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbMaloai = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTapHoaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbMaHang,
            this.dbTenLoaiHang,
            this.dbTenHang,
            this.dbDonGia,
            this.dbDonVi});
            this.dataGridView1.Location = new System.Drawing.Point(395, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(771, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dbMaHang
            // 
            this.dbMaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbMaHang.DataPropertyName = "MaHang";
            this.dbMaHang.HeaderText = "Mã hàng";
            this.dbMaHang.MinimumWidth = 6;
            this.dbMaHang.Name = "dbMaHang";
            this.dbMaHang.Width = 92;
            // 
            // dbTenLoaiHang
            // 
            this.dbTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbTenLoaiHang.DataPropertyName = "TenLoai";
            this.dbTenLoaiHang.HeaderText = "Tên loại hàng";
            this.dbTenLoaiHang.MinimumWidth = 6;
            this.dbTenLoaiHang.Name = "dbTenLoaiHang";
            // 
            // dbTenHang
            // 
            this.dbTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbTenHang.DataPropertyName = "TenHang";
            this.dbTenHang.HeaderText = "Tên hàng hóa";
            this.dbTenHang.MinimumWidth = 6;
            this.dbTenHang.Name = "dbTenHang";
            // 
            // dbDonGia
            // 
            this.dbDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbDonGia.DataPropertyName = "DonGia";
            this.dbDonGia.HeaderText = "Đơn giá";
            this.dbDonGia.MinimumWidth = 6;
            this.dbDonGia.Name = "dbDonGia";
            this.dbDonGia.Width = 86;
            // 
            // dbDonVi
            // 
            this.dbDonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbDonVi.DataPropertyName = "DonVi";
            this.dbDonVi.HeaderText = "Đơn vị tính";
            this.dbDonVi.MinimumWidth = 6;
            this.dbDonVi.Name = "dbDonVi";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyTapHoaDataSet;
            // 
            // quanLyTapHoaDataSet
            // 
            this.quanLyTapHoaDataSet.DataSetName = "QuanLyTapHoaDataSet";
            this.quanLyTapHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // txtMahang
            // 
            this.txtMahang.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahang.Location = new System.Drawing.Point(64, 308);
            this.txtMahang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(241, 32);
            this.txtMahang.TabIndex = 1;
            // 
            // txtTenhh
            // 
            this.txtTenhh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhh.Location = new System.Drawing.Point(64, 394);
            this.txtTenhh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenhh.Name = "txtTenhh";
            this.txtTenhh.Size = new System.Drawing.Size(241, 32);
            this.txtTenhh.TabIndex = 3;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(64, 491);
            this.txtGiatien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(241, 32);
            this.txtGiatien.TabIndex = 4;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonvitinh.Location = new System.Drawing.Point(64, 586);
            this.txtDonvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(241, 32);
            this.txtDonvitinh.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(388, 574);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 44);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(569, 574);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 44);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(749, 574);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 44);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Loại hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 558);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quản lý thông tin hàng hóa";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1089, 574);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(133, 44);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbMaloai
            // 
            this.cbMaloai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaloai.FormattingEnabled = true;
            this.cbMaloai.Location = new System.Drawing.Point(64, 228);
            this.cbMaloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaloai.Name = "cbMaloai";
            this.cbMaloai.Size = new System.Drawing.Size(241, 33);
            this.cbMaloai.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(912, 574);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 44);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 746);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbMaloai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtTenhh);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHangHoa";
            this.Load += new System.EventHandler(this.QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTapHoaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyTapHoaDataSet quanLyTapHoaDataSet;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyTapHoaDataSetTableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTenhh;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbMaloai;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDonVi;
    }
}