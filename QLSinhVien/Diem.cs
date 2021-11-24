using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLSinhVien
{
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }
        private void Diem_Load(object sender, EventArgs e)
        {

            dgvKetQuaDiem.DataSource = DiemBUS.GetDS_Diem();


            cbbMaHK.DataSource = HocKiBUS.GetDS_HocKi();
            cbbMaHK.DisplayMember = "MaHK";
            cbbMaHK.ValueMember = "MaHK";
            
            cbbMaSV.DataSource = SinhVienBUS.GetDS_SinhVien();
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.ValueMember = "MaSV";
            
            cbbMaMH.DataSource = MonHocBUS.GetDataDS_MonHoc();
            cbbMaMH.DisplayMember = "MaMH";
            cbbMaMH.ValueMember = "MaMH";

            cbbMaGV.DataSource = GiangVienBUS.GetDS_GiangVien();
            cbbMaGV.DisplayMember = "MaGV";
            cbbMaGV.ValueMember = "MaGV";


        }

        private void dgvKetQuaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dgvKetQuaDiem.Rows[e.RowIndex];
            
            cbbMaSV.Text = row.Cells[0].Value.ToString();
            cbbMaMH.Text = row.Cells[1].Value.ToString();
            txtDiemCC.Text = row.Cells[2].Value.ToString();
            txtDiemKT.Text = row.Cells[3].Value.ToString();
            txtDiemThi.Text = row.Cells[4].Value.ToString();
            txtDiemTB.Text = row.Cells[5].Value.ToString();
            cbbMaGV.Text = row.Cells[6].Value.ToString();
            cbbMaHK.Text = row.Cells[7].Value.ToString();

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
              try
              { 
                 string maSV = cbbMaSV.Text;
                 string maMH = cbbMaMH.Text;
                 int  diemCC = int.Parse(txtDiemCC.Text);
                 float diemKT = float.Parse(txtDiemKT.Text);
                 float diemThi = float.Parse(txtDiemThi.Text);
                 float diemTB = float.Parse(txtDiemTB.Text);             
                 string maGV = cbbMaGV.Text;
                 string maHK= cbbMaHK.Text;
                 DiemDTO diem = new DiemDTO(maSV, maMH, diemCC, diemKT, diemThi, diemTB, maGV, maHK);
                 DiemBUS.InsertDiem(diem);
                 MessageBox.Show("Bạn đã update thành công ");
                 dgvKetQuaDiem.DataSource = DiemBUS.GetDS_Diem();
              }
             catch
              {
                 MessageBox.Show("Lỗi CSDL");
              }
        }


        



    }
}
