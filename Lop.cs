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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = LopBUS.GetDS_Lop();
            //load dl MaKhoa
            cbbKhoa.DataSource = KhoaBUS.GetDS_Khoa();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";

            cbbGV.DataSource = GiangVienBUS.GetDS_GiangVien();
            cbbGV.DisplayMember = "TenGV";
            cbbGV.ValueMember = "MaGV";


        }
        //dvg luu thong tin
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dgvLop.Rows[e.RowIndex];
            txtMaLop.Text = row.Cells[0].Value.ToString();
            txtTenLop.Text = row.Cells[1].Value.ToString();
            cbbKhoa.Text = row.Cells[2].Value.ToString();
            cbbGV.Text = row.Cells[3].Value.ToString();
        }

        //them
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMaLop.Text;
                string tenLop = txtTenLop.Text;
                string maKhoa = cbbKhoa.Text;
                string maGV = cbbGV.Text;
                LopDTO lop = new LopDTO(maLop, tenLop, maKhoa, maGV);
                LopBUS.InsertLopSV(lop);
                MessageBox.Show("Bạn đã thêm thành công ");
                dgvLop.DataSource = LopBUS.GetDS_Lop();
                ClearTXT();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }
        }
        //thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        //sua
        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                string maLop = txtMaLop.Text;
                string tenLop = txtTenLop.Text;
                string maKhoa = cbbKhoa.Text;
                string maGV = cbbGV.Text;
                LopDTO lop = new LopDTO(maLop, tenLop, maKhoa, maGV);
                LopBUS.UpdateLopSV(lop);
                MessageBox.Show("Bạn đã update thành công ");
                dgvLop.DataSource = LopBUS.GetDS_Lop();
                ClearTXT();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string maLop = txtMaLop.Text;
                string tenLop = txtTenLop.Text;
                string maKhoa = cbbKhoa.Text;
                string maGV = cbbGV.Text;
                LopDTO lop = new LopDTO(maLop, tenLop, maKhoa, maGV);
              
                LopBUS.DeleteLop(maLop);
                MessageBox.Show("Bạn đã xóa thành công ");
                dgvLop.DataSource = LopBUS.GetDS_Lop();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }
        }
      
        private void ClearTXT()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cbbGV.Text = "";
            cbbKhoa.Text = "";
            
        }
    }
}
