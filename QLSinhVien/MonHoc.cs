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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
           dgvMonHoc.DataSource = MonHocBUS.GetDataDS_MonHoc();

            cbbGiaoVien.DataSource = GiangVienBUS.GetDS_GiangVien();
            cbbGiaoVien.DisplayMember = "TenGV";
            cbbGiaoVien.ValueMember = "MaGV";
        }
        //them
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text;
                string tenMH = txtTenMH.Text;
                string maGV= cbbGiaoVien.Text;

                MonHocDTO monHoc = new MonHocDTO(maMH, tenMH, maGV);
                MonHocBUS.InsertMonHoc(monHoc);
                MessageBox.Show("Bạn đã thêm môn học thành công ");
                dgvMonHoc.DataSource = MonHocBUS.GetDataDS_MonHoc();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL");
            }


        }
        //
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dgvMonHoc.Rows[e.RowIndex];
            txtMaMH.Text = row.Cells[0].Value.ToString();
            txtTenMH.Text = row.Cells[1].Value.ToString();
            cbbGiaoVien.Text = row.Cells[2].Value.ToString();
         

        }
        //update
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text;
                string tenMH = txtTenMH.Text;
                string maGV = cbbGiaoVien.Text;

                MonHocDTO monHoc = new MonHocDTO(maMH, tenMH, maGV);
                MonHocBUS.UpdateMonHoc(monHoc);
                MessageBox.Show("Bạn đã thêm môn học thành công ");
                dgvMonHoc.DataSource = MonHocBUS.GetDataDS_MonHoc();
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
                string maMH = txtMaMH.Text;
                string tenMH = txtTenMH.Text;
                string maGV = cbbGiaoVien.Text;

                MonHocDTO monHoc = new MonHocDTO(maMH, tenMH, maGV);
                MonHocBUS.deleteMonHoc(maMH);
                MessageBox.Show("Bạn đã thêm môn học thành công ");
                dgvMonHoc.DataSource = MonHocBUS.GetDataDS_MonHoc();
            }
            catch
            {
                MessageBox.Show("Lỗi!!");
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
