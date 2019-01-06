using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyNhaSach.BUS;
using DoAnQuanLyNhaSach.DAO;
using DoAnQuanLyNhaSach.DTO;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class QuanLySach : Form
    {
        TheLoaiDAO tlDAO = new TheLoaiDAO();
        SachDAO sDAO = new SachDAO();
        SachBUS sBUS = new SachBUS();
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dgvTheLoai.ValueMember = "MaTheLoai";
            dgvTheLoai.DisplayMember = "TenTheLoai";
            dgvTheLoai.DataSource = tlDAO.GetTheLoaiAll();
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.DataSource = tlDAO.GetTheLoaiAll();
            cbTimTheLoai.ValueMember = "MaTheLoai";
            cbTimTheLoai.DisplayMember = "TenTheLoai";
            cbTimTheLoai.DataSource = tlDAO.GetTheLoaiAll();
            HienThiDanhSach();
        }
        public void HienThiDanhSach()
        {
            dgvSach.DataSource = sDAO.SelectAllSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            try
            {
                s.SoLuongTon = int.Parse(txtSoLuongTon.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng tồn không được để trống và điền vào số");
                return;
            }
            s.GiaBan = int.Parse(txtGiaBan.Text);
            s.MaTheLoai = cbTheLoai.SelectedValue.ToString();

            if (sBUS.ThemSach(s) == false)
            {
                MessageBox.Show("Sách đã tồn tại trong CSDL");
            }
            HienThiDanhSach();

        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                txtMaSach.Text = dgvSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenSach.Text = dgvSach.SelectedRows[0].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvSach.SelectedRows[0].Cells[2].Value.ToString();
                txtSoLuongTon.Text = dgvSach.SelectedRows[0].Cells[3].Value.ToString();
                txtTacGia.Text = dgvSach.SelectedRows[0].Cells[4].Value.ToString();
                cbTheLoai.SelectedValue = dgvSach.SelectedRows[0].Cells[5].Value;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaBan.Clear();
            txtSoLuongTon.Clear();
            txtTacGia.Clear();
        }

        private void btnimport_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            try
            {
                s.MaSach =txtMaSach.Text;
            }
            catch
            {
                MessageBox.Show("Mã sách không được rỗng chọn từ danh sách bên dưới để cập nhật");
            }

            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            try
            {
                s.SoLuongTon = int.Parse(txtSoLuongTon.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng tồn không được để trống và điền vào số");
                return;
            }
            s.GiaBan = int.Parse(txtGiaBan.Text);
            s.MaTheLoai = cbTheLoai.SelectedValue.ToString();

            if (sBUS.CapNhatSach(s) == false)
            {
                MessageBox.Show("Mã sách không tồn tại trong CSDL");
            }
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thành công");
        }

       
        public void HienThiDanhSach2(string ma)
        {
            SachDTO s = new SachDTO();
            s.MaTheLoai = ma;
            dgvSach.DataSource = sDAO.SelectSachTheoMaTheLoai(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            try
            {
                s.MaSach = txtMaSach.Text;
            }
            catch
            {
                MessageBox.Show("Mã sách không được rỗng chọn từ danh sách bên dưới để cập nhật");
            }
            if (sBUS.XoaSach(s) == false)
            {
                MessageBox.Show("Mã sách không tồn tại trong CSDL");
            }
            HienThiDanhSach();
            MessageBox.Show("Xóa thành công");
        }

        private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cbTimTheLoai.SelectedValue.ToString();
            HienThiDanhSach2(i);
        }
    }
}
