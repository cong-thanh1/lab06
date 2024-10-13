using lab04;
using lab04.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab04
{
    public partial class frmSystem : Form
    {
        Model1 context = new Model1();

        public frmSystem()
        {
            InitializeComponent();
            List<Student> listStudent = context.Students.ToList();
        }
        private void LoadFacultyData()
        {
            var faculties = context.Faculties.ToList();
            dgvSinhVien.DataSource = faculties;
        }
        
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbKhoa.DataSource = listFalcultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvSinhVien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = item.StudentID;
                dgvSinhVien.Rows[index].Cells[1].Value = item.FullName;
                dgvSinhVien.Rows[index].Cells[2].Value = item.Gender;
                dgvSinhVien.Rows[index].Cells[3].Value = item.AverageScore;
                dgvSinhVien.Rows[index].Cells[4].Value = item.Faculty.FacultyName;
            }
        }
        private void dgvSinhVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Male")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            cmbKhoa.Text = dgvSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtScore.Text = dgvSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void frmSystem_Load(object sender, EventArgs e)
        {

            rdNu.Checked = true;
            txtTongNam.Text = "0";
            txtTongNu.Text = "0";
            txtTongNam.Enabled = false;
            txtTongNu.Enabled = false;
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception)
            {

                throw;
            }
            UpdateStudentCount();
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ResetForm()
        {
            txtID.Clear();
            txtName.Clear();
            rdNu.Checked = true;
            txtScore.Clear();
            if (cmbKhoa.Items.Count > 0)
            {
                cmbKhoa.SelectedIndex = 0;
            }
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!txtID.Text.All(char.IsDigit) || txtID.Text.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ.");
                return;
            }
            if (!decimal.TryParse(txtScore.Text, out decimal score) || score < 0 || score > 10)
            {
                MessageBox.Show("Điểm trung bình sinh viên không hợp lệ.");
                return;
            }
            if (!txtName.Text.All(char.IsLetter) || txtName.Text.Length < 3 || txtName.Text.Length > 100)
            {
                MessageBox.Show("Tên sinh viên không hợp lệ.");
                return;
            }

            try
            {
                if (dgvSinhVien.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtID.Text))
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại.");
                }
                else
                {
                    dgvSinhVien.Rows.Add(txtID.Text, txtName.Text, rdNam.Checked ? "Male" : "Female", txtScore.Text, cmbKhoa.Text);
                    MessageBox.Show("Thêm mới dữ liệu thành công!");

                    ResetForm();

                    UpdateStudentCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            var row = dgvSinhVien.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[0].Value.ToString() == txtID.Text);
            if (row != null)
            {
                row.Cells[1].Value = txtName.Text;
                row.Cells[2].Value = rdNam.Checked ? "Male" : "Female";
                row.Cells[4].Value = cmbKhoa.Text;
                row.Cells[3].Value = txtScore.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                ResetForm();
                UpdateStudentCount();
            }
            else
            {
                MessageBox.Show("Mã số sinh viên không tồn tại trong hệ thống.");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var row = dgvSinhVien.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[0].Value.ToString() == txtID.Text);
            if (row != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvSinhVien.Rows.Remove(row);
                    MessageBox.Show("Xóa sinh viên thành công!");
                    ResetForm();
                    UpdateStudentCount();
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống.");
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            DataTable sinhVienTable = new DataTable();
            foreach (DataGridViewColumn col in dgvSinhVien.Columns)
            {
                sinhVienTable.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                DataRow dRow = sinhVienTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                sinhVienTable.Rows.Add(dRow);
            }

            // Mở frmSearch và truyền DataTable
            frmSearch searchForm = new frmSearch(sinhVienTable);
            searchForm.Show();
        }

        private void toolStripbtnQuanLy_Click_1(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.ShowDialog();
        }
        private void UpdateStudentCount()
        {
            try
            {
                int dgvTongNam = dgvSinhVien.Rows.Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == "Male")
                                    .Count();

                int dgvTongNu = dgvSinhVien.Rows.Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == "Female")
                                    .Count();

                int totalNam = dgvTongNam;
                int totalNu = dgvTongNu;
                txtTongNam.Text = totalNam.ToString();
                txtTongNu.Text = totalNu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}