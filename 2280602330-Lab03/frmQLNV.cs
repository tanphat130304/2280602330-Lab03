using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280602330_Lab03
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void dgvwQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmNV form = new frmNV("", "", ""); // Form thêm mới
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu mới vào DataGridView
                dgvQLNV.Rows.Add(form.MSNV, form.Ten, form.Luong);
            }
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            dgvQLNV.ColumnCount = 3;
            dgvQLNV.Columns[0].Name = "MSNV:";
            dgvQLNV.Columns[1].Name = "Tên nhân viên:";
            dgvQLNV.Columns[2].Name = "Lương căn bản:";

            dgvQLNV.Rows.Add("333", "Nguyen Van Troi", "1000");
            dgvQLNV.Rows.Add("169", "Tran Thi Na", "1500");

            dgvQLNV.RowHeadersVisible = false; 
            dgvQLNV.ReadOnly = true; 
            dgvQLNV.AllowUserToAddRows = false; 
            dgvQLNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow != null)
            {
                // Lấy dữ liệu từ hàng hiện tại
                string msnv = dgvQLNV.CurrentRow.Cells[0].Value.ToString();
                string ten = dgvQLNV.CurrentRow.Cells[1].Value.ToString();
                string luong = dgvQLNV.CurrentRow.Cells[2].Value.ToString();

                frmNV form = new frmNV(msnv, ten, luong); // Form sửa
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật dữ liệu hàng hiện tại
                    dgvQLNV.CurrentRow.Cells[0].Value = form.MSNV;
                    dgvQLNV.CurrentRow.Cells[1].Value = form.Ten;
                    dgvQLNV.CurrentRow.Cells[2].Value = form.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow != null)
            {
                dgvQLNV.Rows.RemoveAt(dgvQLNV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}