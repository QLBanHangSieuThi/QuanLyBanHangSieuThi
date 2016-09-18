namespace QuanLyBanHangSieuThi.FrDMKhachHang.FrmAdd_Edit
{
    partial class frmAdd_EditLoaiKH
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
            this.btnAgr = new DevComponents.DotNetBar.ButtonX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuit.Location = new System.Drawing.Point(169, 38);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Hủy";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAgr
            // 
            this.btnAgr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgr.Location = new System.Drawing.Point(88, 38);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(75, 23);
            this.btnAgr.TabIndex = 4;
            this.btnAgr.Text = "Đồng Ý";
            this.btnAgr.Click += new System.EventHandler(this.btnAgr_Click);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Location = new System.Drawing.Point(12, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(232, 20);
            this.txtTen.TabIndex = 3;
            // 
            // frmAdd_EditLoaiKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 67);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAgr);
            this.Controls.Add(this.txtTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdd_EditLoaiKH";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdd_EditLoaiKH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnQuit;
        private DevComponents.DotNetBar.ButtonX btnAgr;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
    }
}