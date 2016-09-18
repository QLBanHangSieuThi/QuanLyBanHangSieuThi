namespace QuanLyBanHangSieuThi.FrDMKhachHang.FrmAdd_Edit
{
    partial class frmAdd
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
            this.btnQuit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.chbKhThanThiet = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CbxLoaiKhachHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtMaSoThue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTaiKhoanNH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtSoDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TxtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.CbxPTThanhToan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuit.Location = new System.Drawing.Point(148, 317);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 36;
            this.btnQuit.Text = "Hủy";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(38, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Đồng Ý";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chbKhThanThiet
            // 
            this.chbKhThanThiet.Location = new System.Drawing.Point(46, 57);
            this.chbKhThanThiet.Name = "chbKhThanThiet";
            this.chbKhThanThiet.Size = new System.Drawing.Size(155, 23);
            this.chbKhThanThiet.TabIndex = 34;
            this.chbKhThanThiet.Text = "Khách Hàng Thân Thiết";
            // 
            // CbxLoaiKhachHang
            // 
            this.CbxLoaiKhachHang.DisplayMember = "Text";
            this.CbxLoaiKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxLoaiKhachHang.FormattingEnabled = true;
            this.CbxLoaiKhachHang.ItemHeight = 14;
            this.CbxLoaiKhachHang.Location = new System.Drawing.Point(115, 86);
            this.CbxLoaiKhachHang.Name = "CbxLoaiKhachHang";
            this.CbxLoaiKhachHang.Size = new System.Drawing.Size(121, 20);
            this.CbxLoaiKhachHang.TabIndex = 33;
            // 
            // txtMaSoThue
            // 
            // 
            // 
            // 
            this.txtMaSoThue.Border.Class = "TextBoxBorder";
            this.txtMaSoThue.Location = new System.Drawing.Point(115, 258);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(121, 20);
            this.txtMaSoThue.TabIndex = 32;
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(22, 255);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 31;
            this.labelX8.Text = "Mã Số Thuế";
            // 
            // txtTaiKhoanNH
            // 
            // 
            // 
            // 
            this.txtTaiKhoanNH.Border.Class = "TextBoxBorder";
            this.txtTaiKhoanNH.Location = new System.Drawing.Point(115, 229);
            this.txtTaiKhoanNH.Name = "txtTaiKhoanNH";
            this.txtTaiKhoanNH.Size = new System.Drawing.Size(121, 20);
            this.txtTaiKhoanNH.TabIndex = 30;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(22, 226);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "Số TKNH";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(22, 84);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "Loại Khách Hàng";
            // 
            // txtSoDT
            // 
            // 
            // 
            // 
            this.txtSoDT.Border.Class = "TextBoxBorder";
            this.txtSoDT.Location = new System.Drawing.Point(115, 200);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(121, 20);
            this.txtSoDT.TabIndex = 27;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(22, 197);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(115, 171);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChi.TabIndex = 25;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(22, 168);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Địa Chỉ";
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Location = new System.Drawing.Point(115, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(121, 20);
            this.txtHoTen.TabIndex = 23;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(22, 139);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Họ Và Tên";
            // 
            // TxtMaKH
            // 
            // 
            // 
            // 
            this.TxtMaKH.Border.Class = "TextBoxBorder";
            this.TxtMaKH.Location = new System.Drawing.Point(115, 113);
            this.TxtMaKH.Name = "TxtMaKH";
            this.TxtMaKH.Size = new System.Drawing.Size(121, 20);
            this.TxtMaKH.TabIndex = 21;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(22, 110);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Mã Khách Hàng";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(22, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(208, 55);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Thêm Khách Hàng";
            // 
            // CbxPTThanhToan
            // 
            this.CbxPTThanhToan.DisplayMember = "Text";
            this.CbxPTThanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxPTThanhToan.FormattingEnabled = true;
            this.CbxPTThanhToan.ItemHeight = 14;
            this.CbxPTThanhToan.Location = new System.Drawing.Point(115, 286);
            this.CbxPTThanhToan.Name = "CbxPTThanhToan";
            this.CbxPTThanhToan.Size = new System.Drawing.Size(121, 20);
            this.CbxPTThanhToan.TabIndex = 38;
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(22, 284);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(99, 23);
            this.labelX9.TabIndex = 37;
            this.labelX9.Text = "HT Thanh Toán";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 351);
            this.ControlBox = false;
            this.Controls.Add(this.CbxPTThanhToan);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chbKhThanThiet);
            this.Controls.Add(this.CbxLoaiKhachHang);
            this.Controls.Add(this.txtMaSoThue);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtTaiKhoanNH);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.TxtMaKH);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khách Hàng";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnQuit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbKhThanThiet;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxLoaiKhachHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSoThue;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoanNH;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoDT;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtMaKH;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxPTThanhToan;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}