namespace lab04
{
    partial class frmSystem
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
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripCongCu = new System.Windows.Forms.ToolStrip();
            this.toolStripbtnQuanLy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuQuanLy = new System.Windows.Forms.MenuStrip();
            this.toolStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.grpQuanLy = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.toolStripCongCu.SuspendLayout();
            this.menuQuanLy.SuspendLayout();
            this.grpQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuanLy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuanLy.Location = new System.Drawing.Point(265, 42);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(211, 16);
            this.lblQuanLy.TabIndex = 25;
            this.lblQuanLy.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(718, 328);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 36);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtTongNu
            // 
            this.txtTongNu.Enabled = false;
            this.txtTongNu.Location = new System.Drawing.Point(498, 343);
            this.txtTongNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(71, 22);
            this.txtTongNu.TabIndex = 23;
            this.txtTongNu.Text = "0";
            // 
            // lblTongNu
            // 
            this.lblTongNu.AutoSize = true;
            this.lblTongNu.Location = new System.Drawing.Point(408, 348);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(80, 16);
            this.lblTongNu.TabIndex = 22;
            this.lblTongNu.Text = "Tổng SV Nữ";
            // 
            // txtTongNam
            // 
            this.txtTongNam.Enabled = false;
            this.txtTongNam.Location = new System.Drawing.Point(329, 343);
            this.txtTongNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.ReadOnly = true;
            this.txtTongNam.Size = new System.Drawing.Size(73, 22);
            this.txtTongNam.TabIndex = 21;
            this.txtTongNam.Text = "0";
            // 
            // lblTongNam
            // 
            this.lblTongNam.AutoSize = true;
            this.lblTongNam.Location = new System.Drawing.Point(228, 348);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(92, 16);
            this.lblTongNam.TabIndex = 20;
            this.lblTongNam.Text = "Tổng SV Nam";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(88, 289);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 27);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(159, 289);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 27);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 289);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 27);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm\r\n";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSex,
            this.colScore,
            this.colKhoa});
            this.dgvSinhVien.Location = new System.Drawing.Point(268, 59);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(540, 257);
            this.dgvSinhVien.TabIndex = 13;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick_1);
            // 
            // colID
            // 
            this.colID.FillWeight = 50F;
            this.colID.HeaderText = "Mã SV";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ và tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colSex
            // 
            this.colSex.FillWeight = 50F;
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            // 
            // colScore
            // 
            this.colScore.FillWeight = 50F;
            this.colScore.HeaderText = "Điểm";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Tên khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            // 
            // toolStripCongCu
            // 
            this.toolStripCongCu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnQuanLy,
            this.toolStripButton2});
            this.toolStripCongCu.Location = new System.Drawing.Point(0, 28);
            this.toolStripCongCu.Name = "toolStripCongCu";
            this.toolStripCongCu.Size = new System.Drawing.Size(808, 27);
            this.toolStripCongCu.TabIndex = 16;
            this.toolStripCongCu.Text = "toolStrip1";
            // 
            // toolStripbtnQuanLy
            // 
            this.toolStripbtnQuanLy.Image = global::lab04.Properties.Resources.Screenshot_2023_07_23_115730;
            this.toolStripbtnQuanLy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnQuanLy.Name = "toolStripbtnQuanLy";
            this.toolStripbtnQuanLy.Size = new System.Drawing.Size(119, 24);
            this.toolStripbtnQuanLy.Text = "Quản lý khoa";
            this.toolStripbtnQuanLy.Click += new System.EventHandler(this.toolStripbtnQuanLy_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::lab04.Properties.Resources.Screenshot__107_;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 24);
            this.toolStripButton2.Text = "Tìm kiếm";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHeThong,
            this.toolStripThongKe});
            this.menuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuQuanLy.Size = new System.Drawing.Size(808, 28);
            this.menuQuanLy.TabIndex = 15;
            this.menuQuanLy.Text = "menuStrip1";
            // 
            // toolStripHeThong
            // 
            this.toolStripHeThong.Name = "toolStripHeThong";
            this.toolStripHeThong.Size = new System.Drawing.Size(88, 24);
            this.toolStripHeThong.Text = "Hệ Thống";
            // 
            // toolStripThongKe
            // 
            this.toolStripThongKe.Name = "toolStripThongKe";
            this.toolStripThongKe.Size = new System.Drawing.Size(84, 24);
            this.toolStripThongKe.Text = "Thống kê";
            // 
            // grpQuanLy
            // 
            this.grpQuanLy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpQuanLy.Controls.Add(this.rdNu);
            this.grpQuanLy.Controls.Add(this.rdNam);
            this.grpQuanLy.Controls.Add(this.lblSex);
            this.grpQuanLy.Controls.Add(this.lblKhoa);
            this.grpQuanLy.Controls.Add(this.cmbKhoa);
            this.grpQuanLy.Controls.Add(this.txtScore);
            this.grpQuanLy.Controls.Add(this.lblScore);
            this.grpQuanLy.Controls.Add(this.txtName);
            this.grpQuanLy.Controls.Add(this.lblName);
            this.grpQuanLy.Controls.Add(this.txtID);
            this.grpQuanLy.Controls.Add(this.lblID);
            this.grpQuanLy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpQuanLy.Location = new System.Drawing.Point(11, 59);
            this.grpQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuanLy.Name = "grpQuanLy";
            this.grpQuanLy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuanLy.Size = new System.Drawing.Size(252, 215);
            this.grpQuanLy.TabIndex = 14;
            this.grpQuanLy.TabStop = false;
            this.grpQuanLy.Text = "Thông tin sinh viên";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(146, 99);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 10;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(80, 99);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 9;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(14, 102);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 16);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Giới tính";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(14, 131);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 7;
            this.lblKhoa.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(80, 125);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(152, 24);
            this.cmbKhoa.TabIndex = 6;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(80, 160);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(111, 22);
            this.txtScore.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 165);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 16);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Điểm TB";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 26);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(152, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã SV";
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 404);
            this.Controls.Add(this.lblQuanLy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTongNu);
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.toolStripCongCu);
            this.Controls.Add(this.menuQuanLy);
            this.Controls.Add(this.grpQuanLy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSystem";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.toolStripCongCu.ResumeLayout(false);
            this.toolStripCongCu.PerformLayout();
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.grpQuanLy.ResumeLayout(false);
            this.grpQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTongNu;
        private System.Windows.Forms.Label lblTongNu;
        private System.Windows.Forms.TextBox txtTongNam;
        private System.Windows.Forms.Label lblTongNam;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.ToolStrip toolStripCongCu;
        private System.Windows.Forms.ToolStripButton toolStripbtnQuanLy;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem toolStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripThongKe;
        private System.Windows.Forms.GroupBox grpQuanLy;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}

