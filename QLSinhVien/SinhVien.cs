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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = SinhVienBUS.GetDS_SinhVien();

            // load dL Malop
            cmbMaLop.DataSource = LopBUS.GetDS_Lop();
            cmbMaLop.DisplayMember = "MaLop";
            cmbMaLop.ValueMember = "MaLop";
            //load dl MaKhoa
            cmbKhoa.DataSource = KhoaBUS.GetDS_Khoa();
            cmbKhoa.DisplayMember = "MaKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }
    
        //dvg luu thong tin
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoSV.Text = row.Cells[1].Value.ToString();
                txtTenSV.Text = row.Cells[2].Value.ToString();
                dtpNgaySinh.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                cmbMaLop.Text =row .Cells[5].Value.ToString();
                cmbKhoa.Text = row.Cells[6].Value.ToString();  
        }

        //them csdl 
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                string hoSV = txtHoSV.Text;
                string tenSV = txtTenSV.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string maLop = cmbMaLop.Text;
                string maKhoa = cmbKhoa.Text;
                SinhVienDTO sinhVien = new SinhVienDTO(maSV, hoSV, tenSV, ngaySinh, diaChi, maLop, maKhoa);
                SinhVienBUS.InsertSV(sinhVien);
                MessageBox.Show("Bạn đã thêm sinh viên  " + tenSV + " thành công ");
                dgvSinhVien.DataSource = SinhVienBUS.GetDS_SinhVien();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên");
            }
        }
        //thoát chương trình 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        // sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                string hoSV = txtHoSV.Text;
                string tenSV = txtTenSV.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string maLop = cmbMaLop.Text;
                string maKhoa = cmbKhoa.Text;
                SinhVienDTO sinhVien = new SinhVienDTO(maSV, hoSV, tenSV, ngaySinh, diaChi, maLop, maKhoa);
                SinhVienBUS.UpdateSinhVien(sinhVien);
                MessageBox.Show("Bạn đã sửa " + tenSV + " thành công ");
                dgvSinhVien.DataSource = SinhVienBUS.GetDS_SinhVien();
            }
            catch
            {
                MessageBox.Show("Lỗi!!Sửa Không Thành Công");
            }
        }
        //xoa 

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                string hoSV = txtHoSV.Text;
                string tenSV = txtTenSV.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string maLop = cmbMaLop.Text;
                string maKhoa = cmbKhoa.Text;
                SinhVienDTO sinhVien = new SinhVienDTO(maSV, hoSV, tenSV, ngaySinh, diaChi, maLop, maKhoa);
                SinhVienBUS.deleteSinhVien(maSV);
                MessageBox.Show("Bạn đã xóa  " + tenSV + " thành công ");
                dgvSinhVien.DataSource = SinhVienBUS.GetDS_SinhVien();
            }
            catch
            {
                MessageBox.Show("Lỗi!!Không Thực Hiện Được");
            }
        }
    }
}
