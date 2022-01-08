using QLKTX.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmNV_CreateBill : Form
    {
        string manv = "";
        DateTime date;
        KTXDBContext context = new KTXDBContext();
        int maHoaDon = 0;
        public frmNV_CreateBill(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void FillRoomCombobox(List<PHONGSV> listRoom)
        {

            this.cmbRoom.DataSource = listRoom;
            this.cmbRoom.DisplayMember = "TENPHONG";
            this.cmbRoom.ValueMember = "MAPHONG";
        }
        private void FillBuildingCombobox(List<TOANHA> listBuilding)
        {
            this.cmbBuilding.DataSource = listBuilding;
            this.cmbBuilding.DisplayMember = "TENTOA";
            this.cmbBuilding.ValueMember = "MATOA";
        }
        private void BindGrid(List<HOADONDIENNUOC> listHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var item in listHoaDon)
            {
                {
                    double tongGia = 0;
                    int index = dgvHoaDon.Rows.Add();
                    dgvHoaDon.Rows[index].Cells[0].Value = item.MAHDDIENNUOC;   
                    dgvHoaDon.Rows[index].Cells[1].Value = item.MANV!=null?item.NHANVIEN.HOTENNV:" ";
                    dgvHoaDon.Rows[index].Cells[2].Value = item.MAPHONG != null ?item.PHONGSV.TOANHA.TENTOA:" ";
                    dgvHoaDon.Rows[index].Cells[3].Value = item.MAPHONG != null ? item.PHONGSV.TENPHONG: " ";
                    dgvHoaDon.Rows[index].Cells[4].Value = item.NGAYLAP;
                    List<CTHOADONDIENNUOC> listCTHoaDon = context.CTHOADONDIENNUOC.Where(p => p.MAHDDIENNUOC == item.MAHDDIENNUOC).ToList();
                    foreach (var ctHoaDon in listCTHoaDon)
                    {
                        tongGia += ctHoaDon.CHISOSUDUNG * ctHoaDon.BANGGIADIENNUOC.GIATHANH;
                    }
                    dgvHoaDon.Rows[index].Cells[5].Value = tongGia + "VNĐ";
                    dgvHoaDon.Rows[index].Cells[6].Value = item.TRANGTHAI;
                }
            }
        }
        private void reloadDGV()
        {
            List<HOADONDIENNUOC> listHoaDon = context.HOADONDIENNUOC.ToList();
            BindGrid(listHoaDon);
        }

        private void setNull()
        {
            txtChiSoDien.Text = "";
            txtChiSoNuoc.Text = "";
            cmbBuilding.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
        }
        private void frmNV_CreateBill_Load(object sender, EventArgs e)
        {
            try
            {
                //Tab hóa đơn điện nước
                List<TOANHA> listBuilding = context.TOANHA.ToList();
                List<PHONGSV> listRoom = context.PHONGSV.ToList();
                List<HOADONDIENNUOC> listHoaDon = context.HOADONDIENNUOC.ToList();
                FillRoomCombobox(listRoom);
                FillBuildingCombobox(listBuilding);
                BindGrid(listHoaDon);
                setNull();
                //Tab Bảng giá điện nước
                List<BANGGIADIENNUOC> banggia = context.BANGGIADIENNUOC.ToList();
                BindGridBangGia(banggia);
                //Tab bảng hóa đơn chi phi
                List<HOADONLEPHI> lephi = context.HOADONLEPHI.ToList();
                BindGridLePhi(lephi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HOADONDIENNUOC hDN = new HOADONDIENNUOC()
            {
                MAPHONG = cmbRoom.SelectedValue.ToString(),
                NGAYLAP = DateTime.Now,
                TRANGTHAI = "Chưa thanh toán",
                MANV=manv,
                TONGTIEN = 0,
            };           
            context.HOADONDIENNUOC.Add(hDN);
            context.SaveChanges();
            CTHOADONDIENNUOC ctDien = new CTHOADONDIENNUOC()
            {
                MABANGGIA = "DIEN",
                CHISOSUDUNG =float.Parse(txtChiSoDien.Text),              
                MAHDDIENNUOC = hDN.MAHDDIENNUOC
            };
            context.CTHOADONDIENNUOC.Add(ctDien);
            context.SaveChanges();
            CTHOADONDIENNUOC ctNuoc = new CTHOADONDIENNUOC()
            {
                MABANGGIA = "NUOC",
                CHISOSUDUNG = float.Parse(txtChiSoNuoc.Text),
                MAHDDIENNUOC = hDN.MAHDDIENNUOC
            };
            context.CTHOADONDIENNUOC.Add(ctNuoc);
            context.SaveChanges();
            reloadDGV();
            setNull();
            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HOADONDIENNUOC dbUpdate = context.HOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text);
            if (dbUpdate != null)
            {
                dbUpdate.PHONGSV.TOANHA.MATOA = cmbBuilding.SelectedValue.ToString();
                dbUpdate.MAPHONG = cmbRoom.SelectedValue.ToString();
                context.SaveChanges(); //Lưu thay đổi
                MessageBox.Show("Cập nhật dữ liệu thành công!”.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã HĐ cần sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            if (txtChiSoDien.Text != "")
            {
                CTHOADONDIENNUOC dbUpdateDien = context.CTHOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text && p.MABANGGIA == "DIEN");
                dbUpdateDien.CHISOSUDUNG = float.Parse(txtChiSoDien.Text);
                context.SaveChanges();
            }
            if (txtChiSoNuoc.Text != "")
            {
                CTHOADONDIENNUOC dbUpdateNuoc = context.CTHOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text && p.MABANGGIA == "NUOC");
                dbUpdateNuoc.CHISOSUDUNG = float.Parse(txtChiSoNuoc.Text);
                context.SaveChanges();
            }           
            reloadDGV();
            setNull();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HOADONDIENNUOC dbDelete = context.HOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text);
            if (dbDelete != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xoá?", "Yes/No", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.HOADONDIENNUOC.Remove(dbDelete);
                    context.SaveChanges(); //Lưu thay dổi
                    if (txtChiSoDien.Text != "")
                    {
                        CTHOADONDIENNUOC dbDeleteDien = context.CTHOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text && p.MABANGGIA == "DIEN");
                        context.CTHOADONDIENNUOC.Remove(dbDeleteDien);
                        context.SaveChanges();
                    }
                    if (txtChiSoNuoc.Text != "")
                    {
                        CTHOADONDIENNUOC dbDeleteNuoc = context.CTHOADONDIENNUOC.FirstOrDefault(p => p.MAHDDIENNUOC.ToString() == txtMaHD.Text && p.MABANGGIA == "NUOC");
                        context.CTHOADONDIENNUOC.Remove(dbDeleteNuoc);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                    reloadDGV();
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã HĐ cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }                      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setNull();
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvHoaDon.CurrentRow.Selected = true;
                    txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cmbBuilding.SelectedIndex = cmbBuilding.FindString(dgvHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmbRoom.SelectedIndex = cmbRoom.FindString(dgvHoaDon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Code xử lý Tab Bảng hóa đơn lệ phí
        private void setNullLePhi()
        {
            lbMaHD.Text = "";
            lbHoTenSV.Text = "";
            lbCCCD.Text = "";
            lbNguoiLap.Text = "";
            lbNgayLap.Text = "";
            lbHanCuoi.Text = "";
            lbTongTien.Text = "";
            lbTrangThai.Text = "";
        }
        private void BindGridLePhi(List<HOADONLEPHI> lephi)
        {
            dgvDSLePhi.Rows.Clear();
            foreach (var item in lephi)
            {
                {
           
                    int index = dgvDSLePhi.Rows.Add();
                    dgvDSLePhi.Rows[index].Cells[0].Value = item.MAHDLEPHI;
                    dgvDSLePhi.Rows[index].Cells[1].Value = item.SINHVIEN.HOTEN;
                    dgvDSLePhi.Rows[index].Cells[2].Value = item.SINHVIEN.CCCD;
                    dgvDSLePhi.Rows[index].Cells[3].Value = item.MANV!=null?item.NHANVIEN.HOTENNV:"Chưa có";
                    dgvDSLePhi.Rows[index].Cells[4].Value = item.NGAYLAP;
                    CTHOADONLEPHI ctietlephi = context.CTHOADONLEPHI.FirstOrDefault(p => p.MAHDLEPHI == item.MAHDLEPHI);
                    dgvDSLePhi.Rows[index].Cells[5].Value = item.HANCUOI;
                    dgvDSLePhi.Rows[index].Cells[6].Value = ctietlephi.SOTHANG*ctietlephi.PHONGSV.GIAPHONG+" VNĐ";
                    dgvDSLePhi.Rows[index].Cells[7].Value = item.TRANGTHAI;
                }
            }
        }
        private void dgvDSLePhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSLePhi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSLePhi.CurrentRow.Selected = true;
                    lbMaHD.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    lbHoTenSV.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    lbCCCD.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    lbNguoiLap.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    lbNgayLap.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    lbHanCuoi.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    lbTongTien.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    lbTrangThai.Text = dgvDSLePhi.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbViewListLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<HOADONLEPHI> listLePhi = context.HOADONLEPHI.ToList();
            if (cmbViewListLP.Text == "Chưa Thanh Toán")
            {
                dgvDSLePhi.Rows.Clear();
                foreach (var item in listLePhi)
                {
                    if (item.TRANGTHAI == "Chưa Thanh Toán")
                    {
                        int index = dgvDSLePhi.Rows.Add();
                        dgvDSLePhi.Rows[index].Cells[0].Value = item.MAHDLEPHI;
                        dgvDSLePhi.Rows[index].Cells[1].Value = item.SINHVIEN.HOTEN;
                        dgvDSLePhi.Rows[index].Cells[2].Value = item.SINHVIEN.CCCD;
                        dgvDSLePhi.Rows[index].Cells[3].Value = item.MANV == null ? item.NHANVIEN.HOTENNV : "";
                        dgvDSLePhi.Rows[index].Cells[4].Value = item.NGAYLAP;
                        dgvDSLePhi.Rows[index].Cells[5].Value = item.HANCUOI;
                        dgvDSLePhi.Rows[index].Cells[6].Value = item.TONGTIEN;
                        dgvDSLePhi.Rows[index].Cells[7].Value = item.TRANGTHAI;
                    }
                }
            }
            else if (cmbViewListLP.Text == "Đã Thanh Toán")
            {
                dgvDSLePhi.Rows.Clear();
                foreach (var item in listLePhi)
                {
                    if (item.TRANGTHAI == "Đã Thanh Toán")
                    {
                        int index = dgvDSLePhi.Rows.Add();
                        dgvDSLePhi.Rows[index].Cells[0].Value = item.MAHDLEPHI;
                        dgvDSLePhi.Rows[index].Cells[1].Value = item.SINHVIEN.HOTEN;
                        dgvDSLePhi.Rows[index].Cells[2].Value = item.SINHVIEN.CCCD;
                        dgvDSLePhi.Rows[index].Cells[3].Value = item.MANV == null? item.NHANVIEN.HOTENNV:"" ;
                        dgvDSLePhi.Rows[index].Cells[4].Value = item.NGAYLAP;
                        dgvDSLePhi.Rows[index].Cells[5].Value = item.HANCUOI;
                        dgvDSLePhi.Rows[index].Cells[6].Value = item.TONGTIEN;
                        dgvDSLePhi.Rows[index].Cells[7].Value = item.TRANGTHAI;                        
                    }
                }
            }
            else
            {
                dgvDSLePhi.Rows.Clear();
                foreach (var item in listLePhi)
                {
                    if (item.TRANGTHAI == "Đã Thanh Toán")
                    {
                        int index = dgvDSLePhi.Rows.Add();
                        dgvDSLePhi.Rows[index].Cells[0].Value = item.MAHDLEPHI;
                        dgvDSLePhi.Rows[index].Cells[1].Value = item.SINHVIEN.HOTEN;
                        dgvDSLePhi.Rows[index].Cells[2].Value = item.SINHVIEN.CCCD;
                        dgvDSLePhi.Rows[index].Cells[3].Value = item.MANV == null ? item.NHANVIEN.HOTENNV : "";
                        dgvDSLePhi.Rows[index].Cells[4].Value = item.NGAYLAP;
                        dgvDSLePhi.Rows[index].Cells[5].Value = item.HANCUOI;
                        dgvDSLePhi.Rows[index].Cells[6].Value = item.TONGTIEN;
                        dgvDSLePhi.Rows[index].Cells[7].Value = item.TRANGTHAI;
                    }
                }
            }
        }
        private void txtTimKiemLePhi_TextChanged(object sender, EventArgs e)
        {
            List<HOADONLEPHI> listLPSearch = new List<HOADONLEPHI>();
            List<HOADONLEPHI> listLePhi = context.HOADONLEPHI.ToList();
            string search = txtTimKiemLePhi.Text;
            if (search != "")
            {
                foreach (HOADONLEPHI item in listLePhi)
                {
                    if (item.SINHVIEN.HOTEN.ToLower().Contains(search.ToLower()) || item.SINHVIEN.CCCD.ToLower().Contains(search.ToLower()) || item.MAHDLEPHI.Equals(search.ToLower()))
                    {
                        listLPSearch.Add(item);
                    }
                }
                BindGridLePhi(listLPSearch);
            }
            else
            {
                BindGridLePhi(listLePhi);
            }
        }
        private void reloadDGVLePhi()
        {
            List<HOADONLEPHI> listLePhi = context.HOADONLEPHI.ToList();
            BindGridLePhi(listLePhi);
        }
        private void btnThanhToanLePhi_Click(object sender, EventArgs e)
        {
            HOADONLEPHI hoadon = context.HOADONLEPHI.FirstOrDefault(p => p.MAHDLEPHI.ToString() == lbMaHD.Text);
            if (hoadon != null)
            {
                DialogResult noti = MessageBox.Show("Bạn có muốn thanh toán?", "Thông Báo", MessageBoxButtons.YesNo);
                if (noti == DialogResult.Yes)
                {
                    hoadon.TRANGTHAI = "Đã Thanh Toán";
                    context.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK);
                    reloadDGVLePhi();
                    setNullLePhi();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần Xóa ", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Code xử lý Tab Bảng giá điện nước
        private void FillGiaDVCombobox(List<BANGGIADIENNUOC> banggia)
        {

            this.cmbTenDichVu.DataSource = banggia;
            this.cmbTenDichVu.DisplayMember = "TENDICHVU";
            this.cmbTenDichVu.ValueMember = "MABANGGIA";
        }
        private void BindGridBangGia(List<BANGGIADIENNUOC> banggia)
        {
            FillGiaDVCombobox(banggia);
            dgvBangGia.Rows.Clear();
            foreach (var item in banggia)
            {
                {
                    int index = dgvBangGia.Rows.Add();
                    dgvBangGia.Rows[index].Cells[0].Value = item.TENDICHVU;
                    dgvBangGia.Rows[index].Cells[1].Value = item.GIATHANH;
                }
            }
        }
        private void reloadDGVBangGia()
        {
            List<BANGGIADIENNUOC> banggia = context.BANGGIADIENNUOC.ToList();
            BindGridBangGia(banggia);
        }
        private void btnUpdateGia_Click(object sender, EventArgs e)
        {
            if (txtGiaThanh.Text == "")
            {
                BANGGIADIENNUOC dbUpdate = context.BANGGIADIENNUOC.FirstOrDefault(p => p.MABANGGIA == cmbTenDichVu.SelectedValue.ToString());
                if (dbUpdate != null)
                {
                    dbUpdate.GIATHANH = float.Parse(txtGiaThanh.Text);
                    context.SaveChanges(); //Lưu thay đổi
                    reloadDGVBangGia();
                    txtGiaThanh.Text = "";
                    MessageBox.Show("Cập nhật dữ liệu thành công!”.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnCancelGia_Click(object sender, EventArgs e)
        {
            txtGiaThanh.Text = "";
        }

        
    }
}
