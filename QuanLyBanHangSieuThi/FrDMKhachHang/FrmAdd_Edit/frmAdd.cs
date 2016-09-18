using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLRlib.TT_DEV.Data;
using CLRlib.Common;
using System.Collections;

namespace QuanLyBanHangSieuThi.FrDMKhachHang.FrmAdd_Edit
{
     
    public partial class frmAdd : DevComponents.DotNetBar.Office2007Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        SQLConnect cnn = new SQLConnect(@".\SQLEXPRESS", "sa", "sa2012", "QuanLySieuThi");
        
        private void frmAdd_Load(object sender, EventArgs e)
        {
            DataTable dt = cnn.CreateDataTable("select * from TB_LOAI_KHACH_HANG");
            CbxLoaiKhachHang.DataSource = dt;
            CbxLoaiKhachHang.DisplayMember = "TenLoaiKhachHang";
            CbxLoaiKhachHang.ValueMember = "LoaiKhachHang_ID";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                //Hashtable Val = new Hashtable();
                //Val.Add("",)
                //cnn.InsertNewRow()
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
