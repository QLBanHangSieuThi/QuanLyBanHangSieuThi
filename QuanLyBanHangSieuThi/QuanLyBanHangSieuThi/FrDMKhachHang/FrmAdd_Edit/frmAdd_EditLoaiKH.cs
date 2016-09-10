using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLRlib;
using CLRlib.Common;
using CLRlib.TT_DEV.Data;
using System.Collections;

namespace QuanLyBanHangSieuThi.FrDMKhachHang.FrmAdd_Edit
{
    public partial class frmAdd_EditLoaiKH : Form
    {
        public frmAdd_EditLoaiKH()
        {
            InitializeComponent();
        }
        public frmAdd_EditLoaiKH( string a)
        {
            InitializeComponent();
            txtTen.Text = a;
        }
        public static string temp;
        SQLConnect cnn = new SQLConnect(".\\SQLEXPRESS", "sa", "sa2012", "QuanLySieuThi");
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdd_EditLoaiKH_Load(object sender, EventArgs e)
        {
            
                   
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == string.Empty)
            {
                MsgBox.Show("Bạn Chưa Nhập Tên Loại Khách Hàng", "Thông Báo");
                return;
            }
            Hashtable Val = new Hashtable();
            Val.Add("TenLoaiKhachHang", txtTen.Text);
            if(!cnn.InsertNewRow(Val, "TB_LOAI_KHACH_HANG"))
            {
                MsgBox.Show("Không thêm đc");
                return;
            }
            temp = txtTen.Text;
            DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
