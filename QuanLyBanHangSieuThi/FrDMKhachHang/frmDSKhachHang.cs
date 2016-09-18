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
    public partial class frmDSKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public frmDSKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd_Edit.frmAdd frm = new FrmAdd_Edit.frmAdd();
            frm.ShowDialog();
        }
        SQLConnect cnn = new SQLConnect(@".\SQLEXPRESS", "sa", "sa2012", "QuanLySieuThi");
        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmAdd_Edit.frmAdd frm = new FrmAdd_Edit.frmAdd();
            frm.ShowDialog();

        }

        private void frmDSKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = cnn.CreateDataTable("select TenLoaiKhachHang from TB_LOAI_KHACH_HANG");
            foreach ( DataRow item in dt.Rows)
            {
                trV.Nodes.Add(item[0].ToString());
            }

            
            
        }
    }
}
