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

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class PhieuThuTien : Form
    {
        public int luusotienthu;
        public  string makh;
        KhanhHangDAO khDAO = new KhanhHangDAO();
        PhieuThuDAO ptDAO = new PhieuThuDAO();

        public PhieuThuTien()
        {
            InitializeComponent();
        }

        private void PhieuThuTien_Load(object sender, EventArgs e)
        {
            colcmbkh.DataSource = khDAO.SelectKhachHang();
            colcmbkh.ValueMember = "MaKhachHang";
            colcmbkh.DisplayMember = "HoTenKhachHang";
            hienthiphieuthu();
        }
        public void hienthiphieuthu()
        {
            dgvphieuthutien.DataSource = ptDAO.SelectAllPhieuThu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            DanhSachKhanhHang f = new DanhSachKhanhHang();
            f.ShowDialog();
            hienthimakhachhang();
        }
        public void hienthimakhachhang()
        {
            txtmakh.Text = makh;
        }
    }
}
