using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QLSinhVien
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = KhoaBUS.GetDS_Khoa();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhoa.Rows[e.RowIndex];
            txtMaKhoa.Text = row.Cells[0].Value.ToString();
            txtTenKhoa.Text = row.Cells[1].Value.ToString();
        }
        //them
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhoa = txtMaKhoa.Text;
                string tenKhoa = txtTenKhoa.Text;
                KhoaDTO khoa = new KhoaDTO( maKhoa,tenKhoa);
                KhoaBUS.InsertKhoa(khoa);
                MessageBox.Show("Bạn đã thêm thành công ");
                dgvKhoa.DataSource = KhoaBUS.GetDS_Khoa();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }
        }
        //sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhoa = txtMaKhoa.Text;
                string tenKhoa = txtTenKhoa.Text;
                KhoaDTO khoa = new KhoaDTO(maKhoa, tenKhoa);
                KhoaBUS.UpdateKhoa(khoa);
                MessageBox.Show("Bạn đã update thành công ");
                dgvKhoa.DataSource = KhoaBUS.GetDS_Khoa();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }
        }
        //xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string maKhoa = txtTenKhoa.Text;
                string tenKhoa = txtTenKhoa.Text;
                KhoaDTO khoa = new KhoaDTO(maKhoa, tenKhoa);
                KhoaBUS.delete_Khoa(maKhoa);
                MessageBox.Show("Bạn đã xóa thành công ");
                dgvKhoa.DataSource = KhoaBUS.GetDS_Khoa();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
