using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNhaSach.GUI
{
    public partial class BaoCaoCongNo : Form
    {
        public BaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(txtthang.Text);
                if (thang > 12)
                {
                    MessageBox.Show("Không có tháng nào lớn hơn 12");
                    return;

                }
                if (thang < 1)
                {
                    MessageBox.Show("Không có tháng nhỏ hơn tháng 1");
                    return;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Tháng không được bỏ trống và phải điền bằng số");
                return;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
