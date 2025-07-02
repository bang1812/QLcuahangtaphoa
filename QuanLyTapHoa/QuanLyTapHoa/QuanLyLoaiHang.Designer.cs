
namespace QuanLyTapHoa
{
    partial class QuanLyLoaiHang
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtmaLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbloaihang = new System.Windows.Forms.DataGridView();
            this.dbMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbloaihang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnExit.Location = new System.Drawing.Point(298, 374);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 58);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnDel.Location = new System.Drawing.Point(95, 374);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(119, 58);
            this.btnDel.TabIndex = 46;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnUpdate.Location = new System.Drawing.Point(298, 277);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 58);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnAdd.Location = new System.Drawing.Point(95, 277);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 58);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtmaLoai
            // 
            this.txtmaLoai.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtmaLoai.Location = new System.Drawing.Point(95, 120);
            this.txtmaLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmaLoai.Name = "txtmaLoai";
            this.txtmaLoai.Size = new System.Drawing.Size(371, 36);
            this.txtmaLoai.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(98, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã loại hàng";
            // 
            // dbloaihang
            // 
            this.dbloaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbloaihang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbMaLoai,
            this.dbTenLoai});
            this.dbloaihang.Location = new System.Drawing.Point(522, 106);
            this.dbloaihang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbloaihang.Name = "dbloaihang";
            this.dbloaihang.RowHeadersWidth = 51;
            this.dbloaihang.Size = new System.Drawing.Size(513, 260);
            this.dbloaihang.TabIndex = 28;
            this.dbloaihang.SelectionChanged += new System.EventHandler(this.dbloaihang_SelectionChanged);
            // 
            // dbMaLoai
            // 
            this.dbMaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dbMaLoai.DataPropertyName = "MaLoai";
            this.dbMaLoai.HeaderText = "Mã loại hàng";
            this.dbMaLoai.MinimumWidth = 6;
            this.dbMaLoai.Name = "dbMaLoai";
            this.dbMaLoai.Width = 118;
            // 
            // dbTenLoai
            // 
            this.dbTenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbTenLoai.DataPropertyName = "TenLoai";
            this.dbTenLoai.HeaderText = "Tên loại hàng";
            this.dbTenLoai.MinimumWidth = 6;
            this.dbTenLoai.Name = "dbTenLoai";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnSearch.Location = new System.Drawing.Point(183, 468);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 58);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(511, -63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtTenLoai.Location = new System.Drawing.Point(95, 207);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(371, 36);
            this.txtTenLoai.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(98, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tên loại hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 38);
            this.label6.TabIndex = 50;
            this.label6.Text = "Quản lý thông tin loại hàng";
            // 
            // QuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtmaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbloaihang);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "QuanLyLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyLoaiHang";
            this.Load += new System.EventHandler(this.QuanLyLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbloaihang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtmaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dbloaihang;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTenLoai;
    }
}