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
using DoAnQuanLyNhaSach.GUI;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class PhieuNhapSach : Form
    {
        PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        public PhieuNhapSach()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HienThiDanhSach()
        {
            dgvsach.DataSource = pnDAO.SelectAllPhieuNhapCHITIET();
            dsphieunhap.DataSource = pnDAO.SelectAllPhieuNhap();


        }

        private void PhieuNhapSach_Load(object sender, EventArgs e)
        {
            this.Size = new Size(369, 511);
            colcmbsach.DataSource = SachDAO.SelectSachAll();
            colcmbsach.ValueMember = "MaSach";
            colcmbsach.DisplayMember = "TenSach";
            colcbmtacgia.DataSource = SachDAO.SelectSachAll();
            colcbmtacgia.ValueMember = "MaSach";
            colcbmtacgia.DisplayMember = "TacGia";
    
            HienThiDanhSach();
            dtpick.Value = DateTime.Now;
        }
    }
}
