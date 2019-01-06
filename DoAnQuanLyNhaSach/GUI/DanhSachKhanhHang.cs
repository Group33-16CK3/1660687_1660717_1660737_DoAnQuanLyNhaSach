using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyNhaSach.DAO;
using DoAnQuanLyNhaSach.DTO;
using System.Windows.Forms;
using DoAnQuanLyNhaSach.GUI;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class DanhSachKhanhHang : Form
    {
        KhanhHangDAO khDAO = new KhanhHangDAO();
        KhachHangDTO khDTO = new KhachHangDTO();
        PhieuThuTien pttGUI = new PhieuThuTien();
        public DanhSachKhanhHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhanhHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }
        public void HienThiDanhSachKhachHang()
        {
            
            dskhachhang.DataSource = khDAO.SelectKhachHang();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radtatca_CheckedChanged(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void raddienthoai_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Text = "0";
            timkiemdienthoai();

        }
        public void timkiemdienthoai()
        {
            
            try
            {
                khDTO.DienThoai = txttimkiem.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            dskhachhang.DataSource =khDAO.SelectKhachHangTheoDienThoai(khDTO) ;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (radtenkh.Checked == true)
            {
                timkiemtenkh();
            }
            if (raddiachi.Checked == true)
            {
                timkiemdiachi();
            }
            if (raddienthoai.Checked == true)
            {
                timkiemdienthoai();
            }
            if (rademail.Checked == true)
            {
                timkiememail();
            }
        }
        public void timkiemtenkh()
        {

            
            khDTO.HoTenKhachHang = txttimkiem.Text;
            dskhachhang.DataSource = khDAO.SelectKhachHangTheoTen(khDTO);
        }
        public void timkiemdiachi()
        {

            
            khDTO.DiaChi = txttimkiem.Text;
            dskhachhang.DataSource = khDAO.SelectKhachHangTheoDiaChi(khDTO);
        }
        public void timkiememail()
        {

            
            khDTO.Email = txttimkiem.Text;
            dskhachhang.DataSource = khDAO.SelectKhachHangTheoEmail(khDTO);
        }

        private void radtenkh_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtenkh();
        }

        private void raddiachi_CheckedChanged(object sender, EventArgs e)
        {
            timkiemdiachi();
        }

        private void rademail_CheckedChanged(object sender, EventArgs e)
        {
            timkiememail();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            if (dskhachhang.SelectedRows.Count > 0)
            {
                pttGUI.makh = dskhachhang.SelectedRows[0].Cells[0].Value.ToString();
                //frmhoadonbansach.makh = dskhachhang.SelectedRows[0].Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
