using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyNhaSach.GUI;
using System.Diagnostics;

namespace DoAnQuanLyNhaSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phiếuNhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuNhapSach f = new PhieuNhapSach();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnBánSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonBanSach f = new HoaDonBanSach();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachSach f = new DanhSachSach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach f = new QuanLySach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang f = new QuanLyKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhanhHang f = new DanhSachKhanhHang();
            f.MdiParent = this;
            f.Show();
        }

        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuThuTien f = new PhieuThuTien();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTheLoai f = new QuanLyTheLoai();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSach f = new DanhSachSach();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachKhanhHang f = new DanhSachKhanhHang();
            f.MdiParent = this;
            f.Show();
        }

        private void lậpBáoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTon f = new BaoCaoTon();
            f.MdiParent = this;
            f.Show();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoCongNo f = new BaoCaoCongNo();
            f.MdiParent = this;
            f.Show();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh f = new ThayDoiQuyDinh();
            f.MdiParent = this;
            f.Show();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("help.htm");
        }

        private void vềChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin f = new ThongTin();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
