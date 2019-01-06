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
using DoAnQuanLyNhaSach.BUS;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class PhieuThuTien : Form
    {
        public int luusotienthu;
        public  string makh;
        KhanhHangDAO khDAO = new KhanhHangDAO();
        PhieuThuDAO ptDAO = new PhieuThuDAO();
        ThamSoDAO tsDAO = new ThamSoDAO();
        PhieuThuBUS ptBUS = new PhieuThuBUS();
        BaoCaoCongNoDAO bccnDAO = new BaoCaoCongNoDAO();

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

        private void btnthem_Click(object sender, EventArgs e)
        {
            PhieuThuDTO ptDTO = new PhieuThuDTO();
            try
            {
                ptDTO.MaKhachHang = txtmakh.Text;
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                btnkh_Click(sender, e);
                return;
            }
            ptDTO.NgayThu = dtngaythutien.Value;

            DataTable dt = tsDAO.GetAllThamSo();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            DataTable dt2 = tsDAO.GetTienNoKH(txtmakh.Text);
            int tienno = int.Parse(dt2.Rows[0].ItemArray[5].ToString());
            int tienthu = int.Parse(txtsotien.Text);

            try
            {
                ptDTO.SoTienThu = int.Parse(txtsotien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            int tiennonew = tienno - tienthu;

            if (ptBUS.ThemPhieuThu(ptDTO) == false)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = txtmakh.Text;
                kh.TienNo = tiennonew;
                khDAO.UpdateTienNoKH(kh);
                BaoCaoCongNoDTO cn = new BaoCaoCongNoDTO();
                cn.MaKhachHang = kh.MaKhachHang;
                cn.NgayPhatSinh = ptDTO.NgayThu;
                cn.NoDau = tienno;
                cn.NoCuoi = tiennonew;
                cn.PhatSinh = "Phiếu thu tiền";
                bccnDAO.Insert(cn);
                MessageBox.Show("Thành công");
                hienthiphieuthu();
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieuThuDTO pt = new PhieuThuDTO();
            pt.MaPhieuThu = txtmaphieuthu.Text;
            if (ptBUS.XoaPhieuThu(pt) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            hienthiphieuthu();
        }

        private void dgvphieuthutien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvphieuthutien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvphieuthutien.SelectedRows.Count > 0)
            {
                txtmaphieuthu.Text = dgvphieuthutien.SelectedRows[0].Cells[0].Value.ToString();
                dtngaythutien.Text = dgvphieuthutien.SelectedRows[0].Cells[1].Value.ToString();
                txtsotien.Text = dgvphieuthutien.SelectedRows[0].Cells[2].Value.ToString();
                luusotienthu = int.Parse(dgvphieuthutien.SelectedRows[0].Cells[2].Value.ToString());
                txtmakh.Text = dgvphieuthutien.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PhieuThuDTO pt = new PhieuThuDTO();
            pt.MaPhieuThu = txtmaphieuthu.Text;
            pt.NgayThu = dtngaythutien.Value;
            try
            {
                string kh =txtmakh.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                btnkh_Click(sender, e);
                return;
            }
            DataTable dt = tsDAO.GetAllThamSo();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            DataTable dt2 = tsDAO.GetTienNoKH(txtmakh.Text);
            int tienno = int.Parse(dt2.Rows[0].ItemArray[5].ToString());
            int tienthu = int.Parse(txtsotien.Text);


            try
            {
                pt.SoTienThu = int.Parse(txtsotien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            int tienthunew = tienthu - luusotienthu;
            int tiennonew = tienno - tienthunew;


            if (ptBUS.SuaPhieuThu(pt) == false)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = txtmakh.Text;
                kh.TienNo = tiennonew;
                khDAO.UpdateTienNoKH(kh);
                BaoCaoCongNoDTO cn = new BaoCaoCongNoDTO();
                cn.MaKhachHang = kh.MaKhachHang;
                cn.NgayPhatSinh = pt.NgayThu;
                cn.NoDau = tienno;
                cn.NoCuoi = tiennonew;
                cn.PhatSinh = "Cập nhật phiếu thu tiền";
                bccnDAO.Insert(cn);
                MessageBox.Show("Thành công");

                hienthiphieuthu();
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsotien.Clear();
            txtmakh.Clear();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }
    }
}
