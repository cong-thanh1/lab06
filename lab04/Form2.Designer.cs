namespace lab04
{
    partial class frmKhoa
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
            this.grpFunc = new System.Windows.Forms.GroupBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.lblQuanLyGS = new System.Windows.Forms.Label();
            this.btnExitKhoa = new System.Windows.Forms.Button();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.lblTongGS = new System.Windows.Forms.Label();
            this.btnXoaGS = new System.Windows.Forms.Button();
            this.btnSuaGS = new System.Windows.Forms.Button();
            this.btnThemGS = new System.Windows.Forms.Button();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.colIDkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgpKhoaGS = new System.Windows.Forms.GroupBox();
            this.txtScoreGS = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblNameKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblIDKhoa = new System.Windows.Forms.Label();
            this.grpFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.rgpKhoaGS.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFunc
            // 
            this.grpFunc.Controls.Add(this.cmbFunc);
            this.grpFunc.Controls.Add(this.lblSapXep);
            this.grpFunc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpFunc.Location = new System.Drawing.Point(11, 185);
            this.grpFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunc.Name = "grpFunc";
            this.grpFunc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunc.Size = new System.Drawing.Size(236, 71);
            this.grpFunc.TabIndex = 34;
            this.grpFunc.TabStop = false;
            this.grpFunc.Text = "Chức năng";
            // 
            // cmbFunc
            // 
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(61, 25);
            this.cmbFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(152, 24);
            this.cmbFunc.TabIndex = 6;
            this.cmbFunc.SelectedIndexChanged += new System.EventHandler(this.cmbFunc_SelectedIndexChanged);
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Location = new System.Drawing.Point(5, 27);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(57, 16);
            this.lblSapXep.TabIndex = 7;
            this.lblSapXep.Text = "Sắp xếp";
            // 
            // lblQuanLyGS
            // 
            this.lblQuanLyGS.AutoSize = true;
            this.lblQuanLyGS.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuanLyGS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuanLyGS.Location = new System.Drawing.Point(260, 14);
            this.lblQuanLyGS.Name = "lblQuanLyGS";
            this.lblQuanLyGS.Size = new System.Drawing.Size(182, 16);
            this.lblQuanLyGS.TabIndex = 33;
            this.lblQuanLyGS.Text = "QUẢN LÝ THÔNG TIN KHOA";
            // 
            // btnExitKhoa
            // 
            this.btnExitKhoa.Location = new System.Drawing.Point(681, 306);
            this.btnExitKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitKhoa.Name = "btnExitKhoa";
            this.btnExitKhoa.Size = new System.Drawing.Size(67, 36);
            this.btnExitKhoa.TabIndex = 32;
            this.btnExitKhoa.Text = "Thoát";
            this.btnExitKhoa.UseVisualStyleBackColor = true;
            this.btnExitKhoa.Click += new System.EventHandler(this.btnExitKhoa_Click);
            // 
            // txtTongGS
            // 
            this.txtTongGS.Enabled = false;
            this.txtTongGS.Location = new System.Drawing.Point(297, 313);
            this.txtTongGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(73, 22);
            this.txtTongGS.TabIndex = 31;
            this.txtTongGS.Text = "0";
            // 
            // lblTongGS
            // 
            this.lblTongGS.AutoSize = true;
            this.lblTongGS.Location = new System.Drawing.Point(208, 315);
            this.lblTongGS.Name = "lblTongGS";
            this.lblTongGS.Size = new System.Drawing.Size(79, 16);
            this.lblTongGS.TabIndex = 30;
            this.lblTongGS.Text = "Tổng số GS";
            // 
            // btnXoaGS
            // 
            this.btnXoaGS.Location = new System.Drawing.Point(77, 261);
            this.btnXoaGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaGS.Name = "btnXoaGS";
            this.btnXoaGS.Size = new System.Drawing.Size(66, 27);
            this.btnXoaGS.TabIndex = 29;
            this.btnXoaGS.Text = "Xóa";
            this.btnXoaGS.UseVisualStyleBackColor = true;
            this.btnXoaGS.Click += new System.EventHandler(this.btnXoaGS_Click);
            // 
            // btnSuaGS
            // 
            this.btnSuaGS.Location = new System.Drawing.Point(157, 261);
            this.btnSuaGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaGS.Name = "btnSuaGS";
            this.btnSuaGS.Size = new System.Drawing.Size(66, 27);
            this.btnSuaGS.TabIndex = 28;
            this.btnSuaGS.Text = "Sửa";
            this.btnSuaGS.UseVisualStyleBackColor = true;
            this.btnSuaGS.Click += new System.EventHandler(this.btnSuaGS_Click);
            // 
            // btnThemGS
            // 
            this.btnThemGS.Location = new System.Drawing.Point(6, 262);
            this.btnThemGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGS.Name = "btnThemGS";
            this.btnThemGS.Size = new System.Drawing.Size(66, 27);
            this.btnThemGS.TabIndex = 27;
            this.btnThemGS.Text = "Thêm\r\n";
            this.btnThemGS.UseVisualStyleBackColor = true;
            this.btnThemGS.Click += new System.EventHandler(this.btnThemGS_Click);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDkhoa,
            this.colNameKhoa,
            this.colTongGS});
            this.dgvKhoa.Location = new System.Drawing.Point(263, 32);
            this.dgvKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(484, 257);
            this.dgvKhoa.TabIndex = 25;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // colIDkhoa
            // 
            this.colIDkhoa.HeaderText = "Mã Khoa";
            this.colIDkhoa.MinimumWidth = 6;
            this.colIDkhoa.Name = "colIDkhoa";
            // 
            // colNameKhoa
            // 
            this.colNameKhoa.HeaderText = "Tên Khoa";
            this.colNameKhoa.MinimumWidth = 6;
            this.colNameKhoa.Name = "colNameKhoa";
            // 
            // colTongGS
            // 
            this.colTongGS.HeaderText = "Tổng số GS";
            this.colTongGS.MinimumWidth = 6;
            this.colTongGS.Name = "colTongGS";
            // 
            // rgpKhoaGS
            // 
            this.rgpKhoaGS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rgpKhoaGS.Controls.Add(this.txtScoreGS);
            this.rgpKhoaGS.Controls.Add(this.lblTong);
            this.rgpKhoaGS.Controls.Add(this.txtTenKhoa);
            this.rgpKhoaGS.Controls.Add(this.lblNameKhoa);
            this.rgpKhoaGS.Controls.Add(this.txtMaKhoa);
            this.rgpKhoaGS.Controls.Add(this.lblIDKhoa);
            this.rgpKhoaGS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rgpKhoaGS.Location = new System.Drawing.Point(11, 32);
            this.rgpKhoaGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rgpKhoaGS.Name = "rgpKhoaGS";
            this.rgpKhoaGS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rgpKhoaGS.Size = new System.Drawing.Size(236, 149);
            this.rgpKhoaGS.TabIndex = 26;
            this.rgpKhoaGS.TabStop = false;
            this.rgpKhoaGS.Text = "Thông tin Khoa";
            // 
            // txtScoreGS
            // 
            this.txtScoreGS.Location = new System.Drawing.Point(91, 102);
            this.txtScoreGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScoreGS.Name = "txtScoreGS";
            this.txtScoreGS.Size = new System.Drawing.Size(110, 22);
            this.txtScoreGS.TabIndex = 5;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(5, 102);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(79, 16);
            this.lblTong.TabIndex = 4;
            this.lblTong.Text = "Tổng số GS";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(78, 76);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(152, 22);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // lblNameKhoa
            // 
            this.lblNameKhoa.AutoSize = true;
            this.lblNameKhoa.Location = new System.Drawing.Point(13, 66);
            this.lblNameKhoa.Name = "lblNameKhoa";
            this.lblNameKhoa.Size = new System.Drawing.Size(65, 16);
            this.lblNameKhoa.TabIndex = 2;
            this.lblNameKhoa.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(80, 26);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(152, 22);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // lblIDKhoa
            // 
            this.lblIDKhoa.AutoSize = true;
            this.lblIDKhoa.Location = new System.Drawing.Point(13, 31);
            this.lblIDKhoa.Name = "lblIDKhoa";
            this.lblIDKhoa.Size = new System.Drawing.Size(60, 16);
            this.lblIDKhoa.TabIndex = 0;
            this.lblIDKhoa.Text = "Mã Khoa";
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 384);
            this.Controls.Add(this.grpFunc);
            this.Controls.Add(this.lblQuanLyGS);
            this.Controls.Add(this.btnExitKhoa);
            this.Controls.Add(this.txtTongGS);
            this.Controls.Add(this.lblTongGS);
            this.Controls.Add(this.btnXoaGS);
            this.Controls.Add(this.btnSuaGS);
            this.Controls.Add(this.btnThemGS);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.rgpKhoaGS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.grpFunc.ResumeLayout(false);
            this.grpFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.rgpKhoaGS.ResumeLayout(false);
            this.rgpKhoaGS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFunc;
        private System.Windows.Forms.ComboBox cmbFunc;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.Label lblQuanLyGS;
        private System.Windows.Forms.Button btnExitKhoa;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.Label lblTongGS;
        private System.Windows.Forms.Button btnXoaGS;
        private System.Windows.Forms.Button btnSuaGS;
        private System.Windows.Forms.Button btnThemGS;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongGS;
        private System.Windows.Forms.GroupBox rgpKhoaGS;
        private System.Windows.Forms.TextBox txtScoreGS;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblNameKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblIDKhoa;
    }
}