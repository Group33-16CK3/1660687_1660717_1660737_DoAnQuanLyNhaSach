using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyNhaSach.DAO;
using DoAnQuanLyNhaSach.DTO;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class Login : Form
    {
        NguoiDungDAO ndDAO = new NguoiDungDAO();
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.UID = txtTaiKhoan.Text;
            nd.Password = txtMatKhau.Text;
            nd.PhanQuyen = cmbphanquyen.Text;
            bool isLogin = ndDAO.kiemTraNguoiDung(nd);
            if (isLogin == true)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên người dùng, mật khẩu hoặc quyền đăng nhập!", "Cảnh báo");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            cmbphanquyen.Items.Add("admin");
        }
    }
}
