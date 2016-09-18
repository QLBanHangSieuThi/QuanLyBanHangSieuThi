using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLRlib.Common;
using CLRlib.TT_DEV.Data;
using System.Collections;

namespace QuanLyBanHangSieuThi.FrDMKhachHang
{
    public partial class frmLoaiKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public frmLoaiKhachHang()
        {
            InitializeComponent();
        }
        SQLConnect cnn = new SQLConnect(@".\SQLEXPRESS", "sa", "sa2012", "QuanLySieuThi");
        private void frmLoaiKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = cnn.CreateDataTable("select TenLoaiKhachHang from TB_LOAI_KHACH_HANG");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListLoaiKH.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            FrDMKhachHang.FrmAdd_Edit.frmAdd_EditLoaiKH frm = new FrmAdd_Edit.frmAdd_EditLoaiKH();
            if (frm.ShowDialog() == DialogResult.OK)
            ListLoaiKH.Items.Add(FrmAdd_Edit.frmAdd_EditLoaiKH.temp);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            FrDMKhachHang.FrmAdd_Edit.frmAdd_EditLoaiKH frm = new FrmAdd_Edit.frmAdd_EditLoaiKH(ListLoaiKH.SelectedItems[0].Text);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem eachItem in ListLoaiKH.SelectedItems)
            {
                Hashtable temp = new Hashtable();
                temp.Add("TenLoaiKhachHang", eachItem.Text);
                cnn.DeleteRows(temp, "TB_LOAI_KHACH_HANG");
                ListLoaiKH.Items.Remove(eachItem);
            }
        }
    }
}
