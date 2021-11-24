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
    public partial class TimKiemTenSV : Form
    {
        public TimKiemTenSV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

            SinhVienBUS.timkiem_TenSV(txtTenSV.Text);
            dgvKetQua.DataSource = SinhVienBUS.timkiem_TenSV(txtTenSV.Text);

        }
    }
}
