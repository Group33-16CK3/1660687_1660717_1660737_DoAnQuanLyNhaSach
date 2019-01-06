namespace DoAnQuanLyNhaSach.GUI
{
    partial class PhieuNhapSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.latieude2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.colmaphieunhapct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcmbsach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colcbmtacgia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnmasach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaphieunhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsphieunhap = new System.Windows.Forms.DataGridView();
            this.colmaphieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbosungchitiet = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnbsct = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpick = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasachauto = new System.Windows.Forms.TextBox();
            this.latieude1 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsphieunhap)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // latieude2
            // 
            this.latieude2.AutoSize = true;
            this.latieude2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latieude2.Location = new System.Drawing.Point(458, 32);
            this.latieude2.Name = "latieude2";
            this.latieude2.Size = new System.Drawing.Size(218, 31);
            this.latieude2.TabIndex = 0;
            this.latieude2.Text = "Bổ Sung Chi Tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách:";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(113, 49);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(162, 20);
            this.txtmasach.TabIndex = 1;
            // 
            // dgvsach
            // 
            this.dgvsach.AllowUserToAddRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmaphieunhapct,
            this.colcmbsach,
            this.colcbmtacgia,
            this.colsoluong});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsach.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvsach.Location = new System.Drawing.Point(8, 21);
            this.dgvsach.MultiSelect = false;
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.ReadOnly = true;
            this.dgvsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsach.Size = new System.Drawing.Size(314, 150);
            this.dgvsach.TabIndex = 0;
            this.dgvsach.SelectionChanged += new System.EventHandler(this.dgvsach_SelectionChanged);
            // 
            // colmaphieunhapct
            // 
            this.colmaphieunhapct.DataPropertyName = "MaPhieuNhap";
            this.colmaphieunhapct.FillWeight = 65F;
            this.colmaphieunhapct.HeaderText = "Mã phiếu nhập";
            this.colmaphieunhapct.Name = "colmaphieunhapct";
            this.colmaphieunhapct.ReadOnly = true;
            this.colmaphieunhapct.Width = 65;
            // 
            // colcmbsach
            // 
            this.colcmbsach.DataPropertyName = "MaSach";
            this.colcmbsach.HeaderText = "Sách";
            this.colcmbsach.Name = "colcmbsach";
            this.colcmbsach.ReadOnly = true;
            this.colcmbsach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colcmbsach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colcbmtacgia
            // 
            this.colcbmtacgia.DataPropertyName = "MaSach";
            this.colcbmtacgia.HeaderText = "Tác giả";
            this.colcbmtacgia.Name = "colcbmtacgia";
            this.colcbmtacgia.ReadOnly = true;
            this.colcbmtacgia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colcbmtacgia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colsoluong
            // 
            this.colsoluong.DataPropertyName = "SoLuongNhap";
            this.colsoluong.HeaderText = "Số lượng";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvsach);
            this.groupBox1.Location = new System.Drawing.Point(401, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.btnmasach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmaphieunhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(412, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bổ sung";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(113, 75);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(162, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // btnmasach
            // 
            this.btnmasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasach.Location = new System.Drawing.Point(279, 47);
            this.btnmasach.Name = "btnmasach";
            this.btnmasach.Size = new System.Drawing.Size(21, 23);
            this.btnmasach.TabIndex = 3;
            this.btnmasach.Text = ">";
            this.btnmasach.UseVisualStyleBackColor = true;
            this.btnmasach.Click += new System.EventHandler(this.btnmasach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // txtmaphieunhap
            // 
            this.txtmaphieunhap.Location = new System.Drawing.Point(113, 19);
            this.txtmaphieunhap.Name = "txtmaphieunhap";
            this.txtmaphieunhap.ReadOnly = true;
            this.txtmaphieunhap.Size = new System.Drawing.Size(162, 20);
            this.txtmaphieunhap.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phiếu nhập:";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(265, 439);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(70, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsphieunhap);
            this.groupBox3.Location = new System.Drawing.Point(33, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // dsphieunhap
            // 
            this.dsphieunhap.AllowUserToAddRows = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsphieunhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dsphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmaphieunhap,
            this.colngaynhap});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsphieunhap.DefaultCellStyle = dataGridViewCellStyle24;
            this.dsphieunhap.Location = new System.Drawing.Point(8, 21);
            this.dsphieunhap.MultiSelect = false;
            this.dsphieunhap.Name = "dsphieunhap";
            this.dsphieunhap.ReadOnly = true;
            this.dsphieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsphieunhap.Size = new System.Drawing.Size(295, 150);
            this.dsphieunhap.TabIndex = 0;
            this.dsphieunhap.SelectionChanged += new System.EventHandler(this.dsphieunhap_SelectionChanged);
            // 
            // colmaphieunhap
            // 
            this.colmaphieunhap.DataPropertyName = "MaPhieuNhap";
            this.colmaphieunhap.HeaderText = "Mã phiếu nhập";
            this.colmaphieunhap.Name = "colmaphieunhap";
            this.colmaphieunhap.ReadOnly = true;
            // 
            // colngaynhap
            // 
            this.colngaynhap.DataPropertyName = "NgayNhap";
            this.colngaynhap.HeaderText = "Ngày nhập";
            this.colngaynhap.Name = "colngaynhap";
            this.colngaynhap.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnclear);
            this.groupBox6.Controls.Add(this.btnbosungchitiet);
            this.groupBox6.Location = new System.Drawing.Point(401, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(320, 53);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Các chức năng";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(101, 19);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Xóa trắng";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnbosungchitiet
            // 
            this.btnbosungchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbosungchitiet.Location = new System.Drawing.Point(11, 19);
            this.btnbosungchitiet.Name = "btnbosungchitiet";
            this.btnbosungchitiet.Size = new System.Drawing.Size(84, 23);
            this.btnbosungchitiet.TabIndex = 0;
            this.btnbosungchitiet.Text = "Bổ sung";
            this.btnbosungchitiet.UseVisualStyleBackColor = true;
            this.btnbosungchitiet.Click += new System.EventHandler(this.btnbosungchitiet_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnbsct);
            this.groupBox5.Controls.Add(this.btnthem);
            this.groupBox5.Location = new System.Drawing.Point(68, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 51);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các chức năng";
            // 
            // btnbsct
            // 
            this.btnbsct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbsct.Location = new System.Drawing.Point(97, 19);
            this.btnbsct.Name = "btnbsct";
            this.btnbsct.Size = new System.Drawing.Size(115, 23);
            this.btnbsct.TabIndex = 1;
            this.btnbsct.Text = "Bổ sung chi tiết";
            this.btnbsct.UseVisualStyleBackColor = true;
            this.btnbsct.Click += new System.EventHandler(this.btnbsct_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(16, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpick);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtmasachauto);
            this.groupBox4.Location = new System.Drawing.Point(42, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 95);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lập phiếu nhập";
            // 
            // dtpick
            // 
            this.dtpick.Location = new System.Drawing.Point(120, 45);
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(155, 20);
            this.dtpick.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập(Auto):";
            // 
            // txtmasachauto
            // 
            this.txtmasachauto.Location = new System.Drawing.Point(120, 19);
            this.txtmasachauto.Name = "txtmasachauto";
            this.txtmasachauto.ReadOnly = true;
            this.txtmasachauto.Size = new System.Drawing.Size(155, 20);
            this.txtmasachauto.TabIndex = 0;
            // 
            // latieude1
            // 
            this.latieude1.AutoSize = true;
            this.latieude1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latieude1.Location = new System.Drawing.Point(58, 38);
            this.latieude1.Name = "latieude1";
            this.latieude1.Size = new System.Drawing.Size(264, 31);
            this.latieude1.TabIndex = 0;
            this.latieude1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // btdong
            // 
            this.btdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdong.Location = new System.Drawing.Point(656, 437);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(70, 23);
            this.btdong.TabIndex = 7;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // PhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 484);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.latieude1);
            this.Controls.Add(this.latieude2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PhieuNhapSach";
            this.Opacity = 0.09D;
            this.Text = "Phiếu nhập sách";
            this.Load += new System.EventHandler(this.PhieuNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsphieunhap)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label latieude2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dsphieunhap;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnbosungchitiet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbsct;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label latieude1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasachauto;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btnmasach;
        public System.Windows.Forms.TextBox txtmaphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphieunhapct;
        private System.Windows.Forms.DataGridViewComboBoxColumn colcmbsach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colcbmtacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsoluong;
    }
}