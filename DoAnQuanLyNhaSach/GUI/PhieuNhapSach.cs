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
using DoAnQuanLyNhaSach.BUS;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class PhieuNhapSach : Form
    {
        PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        SachDAO sDAO = new SachDAO();
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        ThamSoDAO tsDAO = new ThamSoDAO();
        BaoCaoTonDAO bctDAO = new BaoCaoTonDAO();
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
            colcmbsach.DataSource = sDAO.SelectAllSach();
            colcmbsach.ValueMember = "MaSach";
            colcmbsach.DisplayMember = "TenSach";
            colcbmtacgia.DataSource = sDAO.SelectAllSach();
            colcbmtacgia.ValueMember = "MaSach";
            colcbmtacgia.DisplayMember = "TacGia";
    
            HienThiDanhSach();
            dtpick.Value = DateTime.Now;
        }

        private void dgvsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsach.SelectedRows.Count > 0)
            {
                txtmaphieunhap.Text = dgvsach.SelectedRows[0].Cells[0].Value.ToString();
                txtmasach.Text = dgvsach.SelectedRows[0].Cells[1].Value.ToString();
                txtsoluong.Text = dgvsach.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int dem = dsphieunhap.Rows.Count;
            this.Size = new Size(760, 511);
            PhieuNhapDTO p = new PhieuNhapDTO();
            p.NgayNhap = dtpick.Value;

            if (pnBUS.themphieunhap(p) == false)
            {
                MessageBox.Show("Tạo Phiếu Nhập thất bại");

            }
            HienThiDanhSach();
            txtmaphieunhap.Text = dsphieunhap.Rows[dem].Cells[0].Value.ToString();
        }

        private void dsphieunhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dsphieunhap.SelectedRows.Count > 0)
            {
                txtmaphieunhap.Text = dsphieunhap.SelectedRows[0].Cells[0].Value.ToString();
                txtmasachauto.Text = dsphieunhap.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            this.Size = new Size(760, 511);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmaphieunhap.Clear();
            txtmasach.Clear();
            txtsoluong.Clear();
        }

        private void btnbosungchitiet_Click(object sender, EventArgs e)
        {
            DataTable dt = tsDAO.GetAllThamSo();
            int nhapmin = int.Parse(dt.Rows[0].ItemArray[1].ToString());
            int luongtonmin = int.Parse(dt.Rows[0].ItemArray[2].ToString());

            PhieuNhapDTO p = new PhieuNhapDTO();
            try
            {

                if (txtmaphieunhap.Text != "")
                {
                    p.MaPhieuNhap = txtmaphieunhap.Text;

                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống");
                    return;
                }
                if (txtmasach.Text != "")
                {

                    p.MaSach = txtmasach.Text;


                }
                else
                {
                    MessageBox.Show("Mã sách không được để trống");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mã là số nguyên");
                return;
            }
            try
            {
                if (int.Parse(txtsoluong.Text) < nhapmin)
                {
                    MessageBox.Show("Số lượng phải lớn hơn số lượng quy định");
                    return;
                }
                else
                {

                    p.SoLuong = int.Parse(txtsoluong.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là kiểu số");
                return;
            }
            DataTable dt2 = tsDAO.SlectSoLuongTon(p.MaSach);
            int luongton = int.Parse(dt2.Rows[0].ItemArray[3].ToString());
            int soluongtonnew = luongton + int.Parse(txtsoluong.Text);
            if (luongton < luongtonmin)
            {
                if (pnBUS.themchitietphieunhap(p) == false)
                {
                    MessageBox.Show("Sách này đã có trong phiếu!");
                }
                else
                {

                    SachDTO s = new SachDTO();
                    s.MaSach = txtmasach.Text;
                    s.SoLuongTon = soluongtonnew;
                    sDAO.UpdateSoLuongTon(s);
                    HienThiDanhSach();
                    BaoCaoTonDTO bc = new BaoCaoTonDTO();
                    bc.MaSach = s.MaSach;
                    bc.NgayPhatSinh = dtpick.Value;
                    bc.PhatSinh = "Phiếu nhập sách";
                    bc.TonDau = luongton;
                    bc.TonCuoi = soluongtonnew;
                    bctDAO.Insert(bc);
                    MessageBox.Show("Thành công");
                }
            }
            else
            {
                MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định");

            }
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Size = new Size(369, 511);
        }

        private void btnmasach_Click(object sender, EventArgs e)
        {
            DanhSachSach f = new DanhSachSach();
            f.ShowDialog();
            HienThiDanhSach();
        }
    }
}
