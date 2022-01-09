using QLKTX.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmSV_Info : Form
    {
        KTXDBContext context = new KTXDBContext();
        private string cCCD = "";
        public frmSV_Info(string cCCD)
        {
            InitializeComponent();
            this.cCCD = cCCD;
        }

        private void frmSV_Info_Load(object sender, EventArgs e)
        {
            SINHVIEN sv = context.SINHVIEN.FirstOrDefault(p => p.CCCD == cCCD);
            lbHoVaTenSV.Text = sv.HOTEN;
            lbCCCDSV.Text = cCCD;
            lbMSSV.Text = sv.MSSV;
            lbNgaySinh.Text = sv.NAMSINH.ToString();
            lbGioiTinh.Text = sv.GIOITINH;
            lbTruong.Text = sv.TRUONGHOC.TENTRUONG;
            lbDiaChi.Text = sv.DIACHI;
            lbEmail.Text = sv.EMAIL;
            lbSDT.Text = sv.SDT;
            //thân nhân
            NGUOITHANSV nguoithan = context.NGUOITHANSV.FirstOrDefault(p => p.CCCD == cCCD);
            lbTenThanNhan.Text = nguoithan.TENNGUOITHAN;
            lbQuanHeVoiSV.Text = nguoithan.QUANHEVOISV;
            lbDiaChiThanNhan.Text = nguoithan.DIACHI;
            lbSDTThanNhan.Text = nguoithan.SDT;
        }
    }
}
