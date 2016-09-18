using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangSieuThi.FrDMHangHoa
{
    public partial class frmLoaiMatHang : DevComponents.DotNetBar.Office2007Form
    {
        public frmLoaiMatHang()
        {
            InitializeComponent();
        }

        private void frmLoaiMatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrDMHangHoa.FrmAdd_Edit.frmAdd_EditDVT frm = new FrmAdd_Edit.frmAdd_EditDVT();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrDMHangHoa.FrmAdd_Edit.frmAdd_EditDVT frm = new FrmAdd_Edit.frmAdd_EditDVT();
        }
    }
}
