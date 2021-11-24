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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private int CheckAccount()
        {
            List<string> Acount1 = new List<string>();
            Acount1.Add("admin");
            Acount1.Add("1");

           List<string> Acount2 = new List<string>();
            Acount2.Add("user");
            Acount2.Add("2");   
            bool checkAcount1 = Acount1.Contains(tb_TenTaiKhoan.Text);
            bool checkAcount2 = Acount2.Contains(tb_TenTaiKhoan.Text);
            bool checkPass1 = Acount1.Contains(tb_MatKhau.Text);
            bool checkPass2 = Acount2.Contains(tb_MatKhau.Text);
            if (checkAcount1)
            {
                if (checkPass1)
                {
                    return 1;
                }
            }
            if (checkAcount2)
            {
                if (checkPass2)
                {
                    return 2;
                }
            }
            return 0;
        }

        public static string SelectedText = "";

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Main main   = new Main();
           
            if (CheckAccount() == 1)
            {
                //SelectedText = tb_TenTaiKhoan.Text; //lấy text từ tbAccount truyền vô string SelectedText
                this.Hide();
                main.Show();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error", "Thông tin nhập sai mời bạn thử lại", MessageBoxButtons.OK); //messageBox khi nhập sai
                if (dialog == DialogResult.OK)
                    Application.Restart();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
