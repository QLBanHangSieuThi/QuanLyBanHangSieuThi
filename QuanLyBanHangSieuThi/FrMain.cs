using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangSieuThi
{
    public partial class FrMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            //tabStrip1.Dock = DockStyle.Top;
        }
        #region Hàm tìm Form con trong Form cha
        private int FindMdiChildren(string FormName)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
                if (MdiChildren[i].Name.Equals(FormName))
                    return i;
            return -1;

        }
        #endregion
        #region Hàm kiểm tra Form con có được mở trong from cha chưa
        public bool FormIsActive(string FormName)
        {
            int i = FindMdiChildren(FormName);
            if (i >= 0)
            {
                MdiChildren[i].Activate();
                return true;
            }
            return false;
        }
        #endregion
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (FormIsActive("frmDSKhachHang")) return;
            FrDMKhachHang.frmDSKhachHang frm = new FrDMKhachHang.frmDSKhachHang();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            if (FormIsActive("frmDSHangHoa")) return;
            FrDMHangHoa.frmDSHangHoa frm = new FrDMHangHoa.frmDSHangHoa();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnLoaiKhachHang_Click(object sender, EventArgs e)
        {
            FrDMKhachHang.frmLoaiKhachHang frm = new FrDMKhachHang.frmLoaiKhachHang();
            frm.ShowDialog();
        }

        private void btnLoaiMatHang_Click(object sender, EventArgs e)
        {
            FrDMHangHoa.frmLoaiMatHang frm = new FrDMHangHoa.frmLoaiMatHang();
            frm.ShowDialog();
        }

        private void LoaiNhanVien_Click(object sender, EventArgs e)
        {
            FrDMNhanVien.frmLoaiNhanVien frm = new FrDMNhanVien.frmLoaiNhanVien();
            frm.ShowDialog();
        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {
            FrDMHangHoa.frmDonViTinh frm = new FrDMHangHoa.frmDonViTinh();
            frm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (FormIsActive("frmDSNhanVien")) return;
            FrDMNhanVien.frmDSNhanVien frm = new FrDMNhanVien.frmDSNhanVien();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (FormIsActive("frmDSNhaCungCap")) return;
            FrDMNhaCungCap.frmDSNhaCungCap frm = new FrDMNhaCungCap.frmDSNhaCungCap();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnPTTT_Click(object sender, EventArgs e)
        {

        }
    }
}
