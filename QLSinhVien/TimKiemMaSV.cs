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
    public partial class TimKiemMaSV : Form
    {
        public TimKiemMaSV()
        {
            InitializeComponent();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            SinhVienBUS.timkiem_MaSV(txtMaSV.Text);
            dgvKetQua.DataSource = SinhVienBUS.timkiem_MaSV(txtMaSV.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
