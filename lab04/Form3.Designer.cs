namespace lab04
{
    partial class frmSearch
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
            this.txtKetQuaTimKiem = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdNu1 = new System.Windows.Forms.RadioButton();
            this.rdNam1 = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cmbKhoaTim = new System.Windows.Forms.ComboBox();
            this.txtNameTim = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIDTim = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKetQuaTimKiem
            // 
            this.txtKetQuaTimKiem.Enabled = false;
            this.txtKetQuaTimKiem.Location = new System.Drawing.Point(523, 374);
            this.txtKetQuaTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKetQuaTimKiem.Name = "txtKetQuaTimKiem";
            this.txtKetQuaTimKiem.Size = new System.Drawing.Size(89, 22);
            this.txtKetQuaTimKiem.TabIndex = 32;
            this.txtKetQuaTimKiem.Text = "0";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(405, 378);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(104, 16);
            this.lblKetQua.TabIndex = 31;
            this.lblKetQua.Text = "Kết quả tìm kiếm";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSex,
            this.colScore,
            this.colKhoa});
            this.dgvKetQua.Location = new System.Drawing.Point(11, 194);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(690, 175);
            this.dgvKetQua.TabIndex = 30;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(634, 156);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 34);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(458, 156);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 34);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSearch.Controls.Add(this.rdNu1);
            this.grpSearch.Controls.Add(this.rdNam1);
            this.grpSearch.Controls.Add(this.lblSex);
            this.grpSearch.Controls.Add(this.lblKhoa);
            this.grpSearch.Controls.Add(this.cmbKhoaTim);
            this.grpSearch.Controls.Add(this.txtNameTim);
            this.grpSearch.Controls.Add(this.lblName);
            this.grpSearch.Controls.Add(this.txtIDTim);
            this.grpSearch.Controls.Add(this.lblID);
            this.grpSearch.Location = new System.Drawing.Point(167, 10);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Size = new System.Drawing.Size(285, 186);
            this.grpSearch.TabIndex = 27;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Thông tin tìm kiếm";
            // 
            // rdNu1
            // 
            this.rdNu1.AutoSize = true;
            this.rdNu1.Location = new System.Drawing.Point(166, 121);
            this.rdNu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu1.Name = "rdNu1";
            this.rdNu1.Size = new System.Drawing.Size(45, 20);
            this.rdNu1.TabIndex = 19;
            this.rdNu1.TabStop = true;
            this.rdNu1.Text = "Nữ";
            this.rdNu1.UseVisualStyleBackColor = true;
            // 
            // rdNam1
            // 
            this.rdNam1.AutoSize = true;
            this.rdNam1.Location = new System.Drawing.Point(100, 121);
            this.rdNam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam1.Name = "rdNam1";
            this.rdNam1.Size = new System.Drawing.Size(57, 20);
            this.rdNam1.TabIndex = 18;
            this.rdNam1.TabStop = true;
            this.rdNam1.Text = "Nam";
            this.rdNam1.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(35, 124);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 16);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Giới tính";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(35, 153);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 16;
            this.lblKhoa.Text = "Khoa";
            // 
            // cmbKhoaTim
            // 
            this.cmbKhoaTim.FormattingEnabled = true;
            this.cmbKhoaTim.Location = new System.Drawing.Point(100, 146);
            this.cmbKhoaTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoaTim.Name = "cmbKhoaTim";
            this.cmbKhoaTim.Size = new System.Drawing.Size(152, 24);
            this.cmbKhoaTim.TabIndex = 15;
            // 
            // txtNameTim
            // 
            this.txtNameTim.Location = new System.Drawing.Point(100, 82);
            this.txtNameTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameTim.Name = "txtNameTim";
            this.txtNameTim.Size = new System.Drawing.Size(152, 22);
            this.txtNameTim.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Họ tên";
            // 
            // txtIDTim
            // 
            this.txtIDTim.Location = new System.Drawing.Point(100, 48);
            this.txtIDTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDTim.Name = "txtIDTim";
            this.txtIDTim.Size = new System.Drawing.Size(152, 22);
            this.txtIDTim.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 16);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Mã SV";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 404);
            this.Controls.Add(this.txtKetQuaTimKiem);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSearch";
            this.Text = "Tìm kiếm Sinh viên";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKetQuaTimKiem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdNu1;
        private System.Windows.Forms.RadioButton rdNam1;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cmbKhoaTim;
        private System.Windows.Forms.TextBox txtNameTim;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIDTim;
        private System.Windows.Forms.Label lblID;
    }
}