using QLKTX.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmSV_InfoBill : Form
    {
        KTXDBContext context = new KTXDBContext();
        private string cCCD;
        public frmSV_InfoBill(string cCCD)
        {
            InitializeComponent();
            this.cCCD = cCCD;
        }
        private void BindGrid(List<HOADONDIENNUOC> listHoaDon)
        {
            dgvSVDienNuoc.Rows.Clear();
            foreach (var item in listHoaDon)
            {
                {
                    double tongGia = 0;
                    int index = dgvSVDienNuoc.Rows.Add();
                    dgvSVDienNuoc.Rows[index].Cells[0].Value = item.MAHDDIENNUOC;
                    dgvSVDienNuoc.Rows[index].Cells[1].Value = item.MANV != null ? item.NHANVIEN.HOTENNV : " ";
                    dgvSVDienNuoc.Rows[index].Cells[2].Value = item.MAPHONG != null ? item.PHONGSV.TOANHA.TENTOA : " ";
                    dgvSVDienNuoc.Rows[index].Cells[3].Value = item.MAPHONG != null ? item.PHONGSV.TENPHONG : " ";
                    dgvSVDienNuoc.Rows[index].Cells[4].Value = item.NGAYLAP;
                    List<CTHOADONDIENNUOC> listCTHoaDon = context.CTHOADONDIENNUOC.Where(p => p.MAHDDIENNUOC == item.MAHDDIENNUOC).ToList();
                    foreach (var ctHoaDon in listCTHoaDon)
                    {
                        tongGia += ctHoaDon.CHISOSUDUNG * ctHoaDon.BANGGIADIENNUOC.GIATHANH;
                    }
                    dgvSVDienNuoc.Rows[index].Cells[5].Value = tongGia + "VNĐ";
                    dgvSVDienNuoc.Rows[index].Cells[6].Value = item.TRANGTHAI;
                }
            }
        }

        private void BindGridCT(List<CTHOADONDIENNUOC> listCTHoaDon)
        {
            dgvSVCTDienNuoc.Rows.Clear();
            foreach (var item in listCTHoaDon)
            {
                {
                    int index = dgvSVCTDienNuoc.Rows.Add();
                    dgvSVCTDienNuoc.Rows[index].Cells[0].Value = item.MABANGGIA != null ? item.BANGGIADIENNUOC.TENDICHVU: "";
                    dgvSVCTDienNuoc.Rows[index].Cells[1].Value = item.CHISOSUDUNG;
                    dgvSVCTDienNuoc.Rows[index].Cells[2].Value = item.BANGGIADIENNUOC.GIATHANH;
                    dgvSVCTDienNuoc.Rows[index].Cells[3].Value = item.CHISOSUDUNG*item.BANGGIADIENNUOC.GIATHANH;
                }
            }
        }
        private void LoadDienNuoc()
        {
            SINHVIEN dbPhong = context.SINHVIEN.FirstOrDefault(p => p.CCCD == cCCD);
            List<HOADONDIENNUOC> listHoaDon = context.HOADONDIENNUOC.Where(p => p.MAPHONG == dbPhong.MAPHONG).ToList();               
            BindGrid(listHoaDon);
        }
        private void LoadLePhi()
        {
            int hoaDonMax = context.HOADONLEPHI.Where(p => p.CCCD == cCCD).Max(p => p.MAHDLEPHI);
            HOADONLEPHI dbSinhVien = context.HOADONLEPHI.FirstOrDefault(p => p.CCCD == cCCD
            && p.MAHDLEPHI == hoaDonMax);
            CTHOADONLEPHI dbCTHD = context.CTHOADONLEPHI.FirstOrDefault(p => p.MAHDLEPHI == dbSinhVien.MAHDLEPHI
            && p.HOADONLEPHI.SINHVIEN.CCCD == cCCD);
            lbHoTenSV.Text = dbCTHD.HOADONLEPHI.SINHVIEN.HOTEN;
            lbCCCD.Text = cCCD;
            lbHanCuoi.Text = dbSinhVien.HANCUOI.ToString();
            lbTongTien.Text = (dbCTHD.SOTHANG * dbCTHD.PHONGSV.GIAPHONG).ToString();
            lbTrangThai.Text = dbCTHD.HOADONLEPHI.TRANGTHAI;
        }
        DateTime today = DateTime.Now;
        private void frmSV_InfoBill_Load(object sender, EventArgs e)
        {
            LoadDienNuoc();
            LoadLePhi();
            int hoaDonMax = context.HOADONLEPHI.Where(p=>p.CCCD==cCCD).Max(p=>p.MAHDLEPHI);  
            HOADONLEPHI dbSinhVien = context.HOADONLEPHI.FirstOrDefault(p => p.CCCD == cCCD
            &&p.TRANGTHAI=="Đã Thanh Toán"&& p.MAHDLEPHI==hoaDonMax);           
            if (dbSinhVien != null)// đã thanh toán hết
            {
                DateTime ngayGiam = dbSinhVien.HANCUOI.AddDays(-10);
                HOADONLEPHI dbCheckDate = context.HOADONLEPHI.FirstOrDefault(p => p.MAHDLEPHI == dbSinhVien.MAHDLEPHI
                && DbFunctions.TruncateTime(ngayGiam) <= DbFunctions.TruncateTime(today));
                if (dbCheckDate!=null)
                {
                    cmbSoThang.Enabled = true;
                    btnGiaHan.Enabled = true;
                }
            }
        }

        private void dgvSVDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CTHOADONDIENNUOC> listCTHoaDon = context.CTHOADONDIENNUOC.ToList();
            BindGridCT(listCTHoaDon);
        }
        //Xử Lý Lệ Phí
        private void cmbSoThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SINHVIEN dbPhong = context.SINHVIEN.FirstOrDefault(p => p.CCCD == cCCD);
            txtTongTien.Text = (int.Parse(cmbSoThang.SelectedItem.ToString()) * dbPhong.PHONGSV.GIAPHONG).ToString();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            int hoaDonMax = context.HOADONLEPHI.Where(p => p.CCCD == cCCD).Max(p => p.MAHDLEPHI);
            HOADONLEPHI dbSinhVien = context.HOADONLEPHI.FirstOrDefault(p => p.CCCD == cCCD
            && p.TRANGTHAI == "Đã Thanh Toán" && p.MAHDLEPHI == hoaDonMax);// kierm tra còn thằng nào nợnkhoong

            if (dbSinhVien != null)// hết nợ
            {
                HOADONLEPHI lephi = new HOADONLEPHI()
                {
                    CCCD = cCCD,
                    NGAYLAP = DateTime.Now,
                  //  MANV = manv,
                    TRANGTHAI = "Chưa Thanh Toán",
                    TONGTIEN = 0,
                    HANCUOI = dbSinhVien.HANCUOI.AddMonths(int.Parse(cmbSoThang.SelectedItem.ToString()))
                };
                context.HOADONLEPHI.Add(lephi);
                context.SaveChanges();
                CTHOADONLEPHI ctiethoadon = new CTHOADONLEPHI()
                {
                    SOTHANG = int.Parse(cmbSoThang.SelectedItem.ToString()),
                    MAPHONG = dbSinhVien.SINHVIEN.MAPHONG,
                    MAHDLEPHI = lephi.MAHDLEPHI
                };
                context.CTHOADONLEPHI.Add(ctiethoadon);
                context.SaveChanges();
            }
            HOADONLEPHI dbsv = context.HOADONLEPHI.FirstOrDefault(p => p.CCCD == cCCD
            && p.MAHDLEPHI == hoaDonMax + 1);
            CTHOADONLEPHI dbCTHD = context.CTHOADONLEPHI.FirstOrDefault(p => p.MAHDLEPHI == dbsv.MAHDLEPHI
            && p.HOADONLEPHI.SINHVIEN.CCCD == cCCD);
            lbHoTenSV.Text = dbCTHD.HOADONLEPHI.SINHVIEN.HOTEN;
            lbCCCD.Text = cCCD;
            lbHanCuoi.Text = dbSinhVien.HANCUOI.ToString();
            lbTongTien.Text = (dbCTHD.SOTHANG * dbCTHD.PHONGSV.GIAPHONG).ToString();
            lbTrangThai.Text = dbCTHD.HOADONLEPHI.TRANGTHAI;
            cmbSoThang.Enabled = false;
            btnGiaHan.Enabled = false;
        }
    }
}
