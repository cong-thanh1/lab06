using lab04.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;

namespace lab04
{
    public partial class frmSearch : Form
    {
        Model1 context = new Model1();
        private DataTable _sinhVienData;

        public frmSearch(DataTable sinhVienData)
        {
            InitializeComponent();
            _sinhVienData = sinhVienData;
            List<Student> listStudent = context.Students.ToList();
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbKhoaTim.DataSource = listFalcultys;
            this.cmbKhoaTim.DisplayMember = "FacultyName"; // Hiển thị tên khoa
            this.cmbKhoaTim.ValueMember = "FacultyID"; // Giá trị khoa
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            rdNu1.Checked = true;
            txtKetQuaTimKiem.Text = "0";
            txtKetQuaTimKiem.ReadOnly = true;
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                FillFalcultyCombobox(listFalcultys);
            }
            catch (Exception)
            {

                throw;
            }
            BindGrid(_sinhVienData);
        }

        private void BindGrid(DataTable sinhVienData)
        {
            dgvKetQua.Rows.Clear();
            foreach (DataRow row in sinhVienData.Rows)
            {
                int index = dgvKetQua.Rows.Add();
                for (int i = 0; i < sinhVienData.Columns.Count; i++)
                {
                    dgvKetQua.Rows[index].Cells[i].Value = row[i];
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSV = txtIDTim.Text.Trim(); // Lấy mã sinh viên từ TextBox
            string hoTen = txtNameTim.Text.Trim(); // Lấy họ tên từ TextBox
            string gioiTinh = rdNam1.Checked ? "Male" : rdNu1.Checked ? "Female" : null; // Lấy giới tính, nếu không chọn giới tính thì để null
            string khoa = cmbKhoaTim.SelectedItem?.ToString(); // Nếu không chọn khoa sẽ là null

            try
            {
                // Tìm kiếm trong DataTable
                var foundRows = _sinhVienData.AsEnumerable()
                    .Where(row =>
                        (string.IsNullOrEmpty(maSV) ||
                         (row[0] != DBNull.Value && row.Field<string>("Mã SV").Contains(maSV))) && // Kiểm tra null
                        (string.IsNullOrEmpty(hoTen) ||
                         (row[1] != DBNull.Value && row.Field<string>("HoTen").Contains(hoTen))) && // Kiểm tra null
                        (gioiTinh == null ||
                         (row[2] != DBNull.Value && row.Field<string>("GioiTinh") == gioiTinh)) && // Kiểm tra null
                        (string.IsNullOrEmpty(khoa) ||
                         (row["Khoa"] != DBNull.Value && row.Field<string>("Khoa") == khoa)) // Kiểm tra null
                    );

                // Kiểm tra kết quả tìm kiếm
                if (!foundRows.Any())
                {
                    MessageBox.Show("Không tìm thấy kết quả!");
                    txtKetQuaTimKiem.Text = "0"; // Hiển thị số lượng kết quả là 0
                }
                else
                {
                    // Hiển thị thông tin tìm thấy
                    BindGrid(foundRows.CopyToDataTable()); // Hiển thị kết quả tìm kiếm trong DataGridView
                    txtKetQuaTimKiem.Text = foundRows.Count().ToString(); // Hiển thị số lượng kết quả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình tìm kiếm: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtIDTim.Text.Trim();

            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã khoa cần xóa.");
                return;
            }

            var existingRow = dgvKetQua.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[0].Value.ToString() == maKhoa);

            if (existingRow == null)
            {
                MessageBox.Show("Mã khoa không tồn tại trong hệ thống.");
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvKetQua.Rows.Remove(existingRow);
                    MessageBox.Show("Xóa khoa thành công!");
                    txtIDTim.Clear();
                    txtNameTim.Clear();
                    cmbKhoaTim.SelectedIndex = -1; // Nếu có combo box
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
