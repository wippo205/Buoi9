namespace Buoi9
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.button_TaoPhieuNhap = new System.Windows.Forms.Button();
            this.button_LuuPhieuNhap = new System.Windows.Forms.Button();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_NgayNhap = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_InPhieuNhap = new System.Windows.Forms.Button();
            this.button_ThemSanPham = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_MaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.comboBox_MaSanPham = new System.Windows.Forms.ComboBox();
            this.label_SoLuong = new System.Windows.Forms.Label();
            this.label_MaSanPhan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_MaPhieuNhap);
            this.groupBox1.Controls.Add(this.button_TaoPhieuNhap);
            this.groupBox1.Controls.Add(this.button_LuuPhieuNhap);
            this.groupBox1.Controls.Add(this.textBox_ThanhTien);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox_NgayNhap);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox_NhaCungCap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // textBox_MaPhieuNhap
            // 
            this.textBox_MaPhieuNhap.Enabled = false;
            this.textBox_MaPhieuNhap.Location = new System.Drawing.Point(197, 19);
            this.textBox_MaPhieuNhap.Name = "textBox_MaPhieuNhap";
            this.textBox_MaPhieuNhap.Size = new System.Drawing.Size(178, 22);
            this.textBox_MaPhieuNhap.TabIndex = 12;
            this.textBox_MaPhieuNhap.TextChanged += new System.EventHandler(this.textBox_MaPhieuNhap_TextChanged);
            // 
            // button_TaoPhieuNhap
            // 
            this.button_TaoPhieuNhap.Image = global::Buoi9.Properties.Resources.setting1;
            this.button_TaoPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaoPhieuNhap.Location = new System.Drawing.Point(221, 112);
            this.button_TaoPhieuNhap.Name = "button_TaoPhieuNhap";
            this.button_TaoPhieuNhap.Size = new System.Drawing.Size(170, 53);
            this.button_TaoPhieuNhap.TabIndex = 11;
            this.button_TaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.button_TaoPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_TaoPhieuNhap.UseVisualStyleBackColor = true;
            this.button_TaoPhieuNhap.Click += new System.EventHandler(this.button_TaoPhieuNhap_Click);
            // 
            // button_LuuPhieuNhap
            // 
            this.button_LuuPhieuNhap.Image = global::Buoi9.Properties.Resources.diskette;
            this.button_LuuPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LuuPhieuNhap.Location = new System.Drawing.Point(410, 112);
            this.button_LuuPhieuNhap.Name = "button_LuuPhieuNhap";
            this.button_LuuPhieuNhap.Size = new System.Drawing.Size(165, 53);
            this.button_LuuPhieuNhap.TabIndex = 10;
            this.button_LuuPhieuNhap.Text = "Lưu phiếu nhập";
            this.button_LuuPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_LuuPhieuNhap.UseVisualStyleBackColor = true;
            this.button_LuuPhieuNhap.Click += new System.EventHandler(this.button_LuuPhieuNhap_Click);
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Location = new System.Drawing.Point(539, 67);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(178, 22);
            this.textBox_ThanhTien.TabIndex = 8;
            this.textBox_ThanhTien.Text = "0";
            this.textBox_ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_ThanhTien.TextChanged += new System.EventHandler(this.textBox_ThanhTien_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox_NgayNhap
            // 
            this.textBox_NgayNhap.Location = new System.Drawing.Point(197, 67);
            this.textBox_NgayNhap.Name = "textBox_NgayNhap";
            this.textBox_NgayNhap.Size = new System.Drawing.Size(178, 22);
            this.textBox_NgayNhap.TabIndex = 7;
            this.textBox_NgayNhap.TextChanged += new System.EventHandler(this.textBox_NgayNhap_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(143, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_NhaCungCap
            // 
            this.comboBox_NhaCungCap.FormattingEnabled = true;
            this.comboBox_NhaCungCap.Items.AddRange(new object[] {
            "Điện máy xanh",
            "Thế giới di động",
            "Phong Vũ",
            "FPT Shop",
            "CellphoneS"});
            this.comboBox_NhaCungCap.Location = new System.Drawing.Point(539, 22);
            this.comboBox_NhaCungCap.Name = "comboBox_NhaCungCap";
            this.comboBox_NhaCungCap.Size = new System.Drawing.Size(178, 24);
            this.comboBox_NhaCungCap.TabIndex = 4;
            this.comboBox_NhaCungCap.SelectedIndexChanged += new System.EventHandler(this.comboBox_NhaCungCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_InPhieuNhap);
            this.groupBox2.Controls.Add(this.button_ThemSanPham);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.comboBox_MaPhieuNhap);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox_DonGia);
            this.groupBox2.Controls.Add(this.comboBox_MaSanPham);
            this.groupBox2.Controls.Add(this.label_SoLuong);
            this.groupBox2.Controls.Add(this.label_MaSanPhan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // button_InPhieuNhap
            // 
            this.button_InPhieuNhap.Image = global::Buoi9.Properties.Resources.printing;
            this.button_InPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_InPhieuNhap.Location = new System.Drawing.Point(25, 200);
            this.button_InPhieuNhap.Name = "button_InPhieuNhap";
            this.button_InPhieuNhap.Size = new System.Drawing.Size(166, 63);
            this.button_InPhieuNhap.TabIndex = 13;
            this.button_InPhieuNhap.Text = "In phiếu nhập";
            this.button_InPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_InPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // button_ThemSanPham
            // 
            this.button_ThemSanPham.Image = global::Buoi9.Properties.Resources.add;
            this.button_ThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThemSanPham.Location = new System.Drawing.Point(25, 113);
            this.button_ThemSanPham.Name = "button_ThemSanPham";
            this.button_ThemSanPham.Size = new System.Drawing.Size(166, 63);
            this.button_ThemSanPham.TabIndex = 12;
            this.button_ThemSanPham.Text = "Thêm sản phẩm";
            this.button_ThemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ThemSanPham.UseVisualStyleBackColor = true;
            this.button_ThemSanPham.Click += new System.EventHandler(this.button_ThemSanPham_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboBox_MaPhieuNhap
            // 
            this.comboBox_MaPhieuNhap.FormattingEnabled = true;
            this.comboBox_MaPhieuNhap.Location = new System.Drawing.Point(197, 22);
            this.comboBox_MaPhieuNhap.Name = "comboBox_MaPhieuNhap";
            this.comboBox_MaPhieuNhap.Size = new System.Drawing.Size(178, 24);
            this.comboBox_MaPhieuNhap.TabIndex = 9;
            this.comboBox_MaPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaPhieuNhap_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(539, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.Enabled = false;
            this.textBox_DonGia.Location = new System.Drawing.Point(197, 70);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(178, 22);
            this.textBox_DonGia.TabIndex = 7;
            this.textBox_DonGia.Text = "0";
            this.textBox_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_MaSanPham
            // 
            this.comboBox_MaSanPham.FormattingEnabled = true;
            this.comboBox_MaSanPham.Location = new System.Drawing.Point(539, 22);
            this.comboBox_MaSanPham.Name = "comboBox_MaSanPham";
            this.comboBox_MaSanPham.Size = new System.Drawing.Size(178, 24);
            this.comboBox_MaSanPham.TabIndex = 4;
            // 
            // label_SoLuong
            // 
            this.label_SoLuong.AutoSize = true;
            this.label_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoLuong.Location = new System.Drawing.Point(407, 70);
            this.label_SoLuong.Name = "label_SoLuong";
            this.label_SoLuong.Size = new System.Drawing.Size(72, 17);
            this.label_SoLuong.TabIndex = 3;
            this.label_SoLuong.Text = "Số lượng";
            // 
            // label_MaSanPhan
            // 
            this.label_MaSanPhan.AutoSize = true;
            this.label_MaSanPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaSanPhan.Location = new System.Drawing.Point(407, 22);
            this.label_MaSanPhan.Name = "label_MaSanPhan";
            this.label_MaSanPhan.Size = new System.Drawing.Size(104, 17);
            this.label_MaSanPhan.TabIndex = 2;
            this.label_MaSanPhan.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phiếu nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NgayNhap;
        private System.Windows.Forms.ComboBox comboBox_NhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Button button_LuuPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.ComboBox comboBox_MaSanPham;
        private System.Windows.Forms.Label label_SoLuong;
        private System.Windows.Forms.Label label_MaSanPhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_TaoPhieuNhap;
        private System.Windows.Forms.ComboBox comboBox_MaPhieuNhap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_InPhieuNhap;
        private System.Windows.Forms.Button button_ThemSanPham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_MaPhieuNhap;
    }
}

