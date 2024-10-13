using lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab04
{
    public partial class frmKhoa : Form
    {
        Model1 context = new Model1();

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFacultyData();
                BindGrid();
                txtTongGS.ReadOnly = true;
                cmbFunc.Items.Add("Tăng dần");
                cmbFunc.Items.Add("Giảm dần");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadFacultyData()
        {
            var faculties = context.Faculties.ToList();
            txtTongGS.Text = faculties.Sum(f => f.TotalProfessor).ToString();
        }

        private void BindGrid()
        {
            try
            {
                dgvKhoa.Rows.Clear();
                var faculties = context.Faculties.ToList();

                foreach (var item in faculties)
                {
                    int index = dgvKhoa.Rows.Add();
                    dgvKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                    dgvKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                    dgvKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật DataGridView: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtScoreGS.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells[0].Value.ToString();
                txtTenKhoa.Text = row.Cells[1].Value.ToString();
                txtScoreGS.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnThemGS_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var existingRow = dgvKhoa.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value != null && r.Cells[0].Value.ToString() == txtMaKhoa.Text);

            if (existingRow == null)
            {
                dgvKhoa.Rows.Add(txtMaKhoa.Text, txtTenKhoa.Text, txtScoreGS.Text);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Mã khoa đã tồn tại! Vui lòng sử dụng mã khác.");
                return;
            }

            UpdateTotalProfessors();
        }

        private void btnSuaGS_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var existingRow = dgvKhoa.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value != null && r.Cells[0].Value.ToString() == txtMaKhoa.Text);

            if (existingRow == null)
            {
                MessageBox.Show("Mã khoa không tồn tại trong hệ thống.");
            }
            else
            {
                existingRow.Cells[1].Value = txtTenKhoa.Text;
                existingRow.Cells[2].Value = txtScoreGS.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                UpdateTotalProfessors();
            }
        }

        private void UpdateTotalProfessors()
        {
            int totalProfessors = dgvKhoa.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Cells[2].Value != null)
                .Sum(r => int.Parse(r.Cells[2].Value.ToString()));
            txtTongGS.Text = totalProfessors.ToString();
        }

        private void ClearInputFields()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtScoreGS.Clear();
        }

        private void cmbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var faculties = context.Faculties.ToList();

                if (cmbFunc.SelectedItem != null)
                {
                    List<Faculty> sortedData = cmbFunc.SelectedItem.ToString() == "Tăng dần" ?
                        faculties.OrderBy(f => f.TotalProfessor).ToList() :
                        faculties.OrderByDescending(f => f.TotalProfessor).ToList();

                    BindGrid(sortedData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sắp xếp dữ liệu: " + ex.Message);
            }
        }

        private void BindGrid(List<Faculty> faculties)
        {
            try
            {
                dgvKhoa.Rows.Clear();
                foreach (var item in faculties)
                {
                    int index = dgvKhoa.Rows.Add();
                    dgvKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                    dgvKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                    dgvKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật DataGridView: " + ex.Message);
            }
        }

        private void btnExitKhoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXoaGS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khoa cần xóa.");
                return;
            }

            var existingRow = dgvKhoa.Rows.Cast<DataGridViewRow>()
                              .FirstOrDefault(r => r.Cells[0].Value != null &&
                                                   r.Cells[0].Value.ToString() == txtMaKhoa.Text);

            if (existingRow == null)
            {
                MessageBox.Show("Mã khoa không tồn tại trong hệ thống.");
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvKhoa.Rows.Remove(existingRow);
                    MessageBox.Show("Xóa khoa thành công!");
                    ClearInputFields();
                    UpdateTotalProfessors();
                }
            }
        }
    }
}
