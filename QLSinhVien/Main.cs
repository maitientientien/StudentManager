using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<SinhVien>().FirstOrDefault();
            if (frmchild == null)
            {
                SinhVien f = new SinhVien();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<MonHoc>().FirstOrDefault();
            if (frmchild == null)
            {
                MonHoc f = new MonHoc();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<Diem>().FirstOrDefault();
            if (frmchild == null)
            {
                Diem f = new Diem();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<Lop>().FirstOrDefault();
            if (frmchild == null)
            {
                Lop f = new Lop();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void quảnLÝKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<Khoa>().FirstOrDefault();
            if (frmchild == null)
            {
                Khoa f = new Khoa();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void tìmKiếmTheoMSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<TimKiemMaSV>().FirstOrDefault();
            if (frmchild == null)
            {
                TimKiemMaSV f = new TimKiemMaSV();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void tìmKiếmTheoTênSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<TimKiemTenSV>().FirstOrDefault();
            if (frmchild == null)
            {
                TimKiemTenSV f = new TimKiemTenSV();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inDanhSachSVTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<SVtheoLop>().FirstOrDefault();
            if (frmchild == null)
            {
                SVtheoLop f = new SVtheoLop();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }

        private void inDanhSachSVTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmchild = this.MdiChildren.OfType<SVtheoKhoa>().FirstOrDefault();
            if (frmchild == null)
            {
                SVtheoKhoa f = new SVtheoKhoa();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                frmchild.Activate();
            }
        }
    }
}
