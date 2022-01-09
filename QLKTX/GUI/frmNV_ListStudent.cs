using FontAwesome.Sharp;
using QLKTX.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmNV_ListStudent : Form
    {
        frmLogin frmLogin = new frmLogin();
        string manv = frmLogin.userLogin;
        private readonly KTXDBContext context;
        public frmNV_ListStudent()
        {
            context = new KTXDBContext();
            InitializeComponent();
        }
        private void FillRoomCombobox(List<PHONGSV> listRoom)
        {

            this.cmbRoom.DataSource = listRoom;
            this.cmbRoom.DisplayMember = "TENPHONG";
            this.cmbRoom.ValueMember = "MAPHONG";
        }
        private void FillSchoolCombobox(List<TRUONGHOC> listSchool)
        {
            this.cmbSchool.DataSource = listSchool;
            this.cmbSchool.DisplayMember = "TENTRUONG";
            this.cmbSchool.ValueMember = "MATRUONG";
        }
        private void BindGrid(List<SINHVIEN> listStudent)
        {
            dgvStudent.Rows.Clear();
            dgvStudent.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            int i = 1;
            foreach (var item in listStudent)
            {
                if (item.TRANGTHAI == "Đang Ở")
                {
                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells[0].Value = i;
                    dgvStudent.Rows[index].Cells[1].Value = item.CCCD;
                    dgvStudent.Rows[index].Cells[2].Value = item.MSSV;
                    dgvStudent.Rows[index].Cells[3].Value = item.HOTEN;
                    dgvStudent.Rows[index].Cells[4].Value = item.NAMSINH;
                    dgvStudent.Rows[index].Cells[5].Value = item.GIOITINH;
                    dgvStudent.Rows[index].Cells[6].Value = item.SDT;
                    dgvStudent.Rows[index].Cells[7].Value = item.EMAIL;
                    dgvStudent.Rows[index].Cells[8].Value = item.DIACHI;
                    dgvStudent.Rows[index].Cells[9].Value = item.NGAYVAOKTX;
                    dgvStudent.Rows[index].Cells[10].Value = item.NGAYRAKTX;
                    dgvStudent.Rows[index].Cells[11].Value = item.PHONGSV.TENPHONG;
                    dgvStudent.Rows[index].Cells[12].Value = item.TRUONGHOC.TENTRUONG;
                    dgvStudent.Rows[index].Cells[13].Value = item.TRANGTHAI;
                    this.dgvStudent.Columns[10].Visible = false;
                    i++;
                }
            }
        }
        private void cmbViewListSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            List<SINHVIEN> listSV = context.SINHVIEN.ToList();
            if (cmbViewListSV.Text == "Đang Ở")
            {
                dgvStudent.Rows.Clear();
                foreach (var item in listSV)
                {
                    if (item.TRANGTHAI != "Đã Chuyển Đi")
                    {
                        int index = dgvStudent.Rows.Add();
                        dgvStudent.Rows[index].Cells[0].Value = i;
                        dgvStudent.Rows[index].Cells[1].Value = item.CCCD;
                        dgvStudent.Rows[index].Cells[2].Value = item.MSSV;
                        dgvStudent.Rows[index].Cells[3].Value = item.HOTEN;
                        dgvStudent.Rows[index].Cells[4].Value = item.NAMSINH;
                        dgvStudent.Rows[index].Cells[5].Value = item.GIOITINH;
                        dgvStudent.Rows[index].Cells[6].Value = item.SDT;
                        dgvStudent.Rows[index].Cells[7].Value = item.EMAIL;
                        dgvStudent.Rows[index].Cells[8].Value = item.DIACHI;
                        dgvStudent.Rows[index].Cells[9].Value = item.NGAYVAOKTX;
                        dgvStudent.Rows[index].Cells[10].Value = item.PHONGSV.TENPHONG;
                        dgvStudent.Rows[index].Cells[11].Value = item.TRUONGHOC.TENTRUONG;
                        dgvStudent.Rows[index].Cells[12].Value = item.TRANGTHAI;
                        dgvStudent.Rows[index].Cells[13].Value = item.NGAYRAKTX;
                        this.dgvStudent.Columns[13].Visible = false;
                        i++;
                    }
                }
            }
            else if (cmbViewListSV.Text == "Đã Chuyển Đi")
            {
                dgvStudent.Rows.Clear();
                foreach (var item in listSV)
                {
                    if (item.TRANGTHAI == "Đã Chuyển Đi")
                    {
                        int index = dgvStudent.Rows.Add();
                        dgvStudent.Rows[index].Cells[0].Value = i;
                        dgvStudent.Rows[index].Cells[1].Value = item.CCCD;
                        dgvStudent.Rows[index].Cells[2].Value = item.MSSV;
                        dgvStudent.Rows[index].Cells[3].Value = item.HOTEN;
                        dgvStudent.Rows[index].Cells[4].Value = item.NAMSINH;
                        dgvStudent.Rows[index].Cells[5].Value = item.GIOITINH;
                        dgvStudent.Rows[index].Cells[6].Value = item.SDT;
                        dgvStudent.Rows[index].Cells[7].Value = item.EMAIL;
                        dgvStudent.Rows[index].Cells[8].Value = item.DIACHI;
                        dgvStudent.Rows[index].Cells[9].Value = item.NGAYVAOKTX;
                        dgvStudent.Rows[index].Cells[10].Value = item.PHONGSV.TENPHONG;
                        dgvStudent.Rows[index].Cells[11].Value = item.TRUONGHOC.TENTRUONG;
                        dgvStudent.Rows[index].Cells[12].Value = item.TRANGTHAI;
                        dgvStudent.Rows[index].Cells[13].Value = item.NGAYRAKTX;
                        this.dgvStudent.Columns[13].Visible = true;
                        i++;
                    }
                }
            }
            else
            {
                dgvStudent.Rows.Clear();
                foreach (var item in listSV)
                {
                    int index = dgvStudent.Rows.Add();
                    dgvStudent.Rows[index].Cells[0].Value = i;
                    dgvStudent.Rows[index].Cells[1].Value = item.CCCD;
                    dgvStudent.Rows[index].Cells[2].Value = item.MSSV;
                    dgvStudent.Rows[index].Cells[3].Value = item.HOTEN;
                    dgvStudent.Rows[index].Cells[4].Value = item.NAMSINH;
                    dgvStudent.Rows[index].Cells[5].Value = item.GIOITINH;
                    dgvStudent.Rows[index].Cells[6].Value = item.SDT;
                    dgvStudent.Rows[index].Cells[7].Value = item.EMAIL;
                    dgvStudent.Rows[index].Cells[8].Value = item.DIACHI;
                    dgvStudent.Rows[index].Cells[9].Value = item.NGAYVAOKTX;
                    dgvStudent.Rows[index].Cells[10].Value = item.PHONGSV.TENPHONG;
                    dgvStudent.Rows[index].Cells[11].Value = item.TRUONGHOC.TENTRUONG;
                    dgvStudent.Rows[index].Cells[12].Value = item.TRANGTHAI;
                    dgvStudent.Rows[index].Cells[13].Value = item.NGAYRAKTX;
                    this.dgvStudent.Columns[13].Visible = true;
                    i++;
                }
            }
        }

        private void BindGridThanNhan(List<NGUOITHANSV> listThanNhan)
        {
            dgvThanNhan.Rows.Clear();
            foreach (var item in listThanNhan)
            {
                dgvThanNhan.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                int index = dgvThanNhan.Rows.Add();
                dgvThanNhan.Rows[index].Cells[0].Value = item.TENNGUOITHAN;
                dgvThanNhan.Rows[index].Cells[1].Value = item.QUANHEVOISV;
                dgvThanNhan.Rows[index].Cells[2].Value = item.SDT;
                dgvThanNhan.Rows[index].Cells[3].Value = item.DIACHI;
            }
        }
        private void setNull()
        {
            txtCCCD.Text = "";
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtAddressSV.Text = "";
            txtPhoneSV.Text = "";
            cmbSchool.SelectedValue = 0;
            robMale.Checked = true;
            dtpBirthday.Value = DateTime.Now;
            //cmbTrangThaiSV.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            //Thân nhân
            txtTenThanNhan.Text = "";
            txtSDTThanNhan.Text = "";
            cmbQuanHeVoiSV.SelectedIndex = 0;
            txtDiaChiTN.Text = "";
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[1].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private bool CheckValidate()
        {
            if (txtCCCD.Text == "" || txtStudentID.Text == "" || txtStudentName.Text == "" || txtAddressSV.Text == "" || txtPhoneSV.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void reloadDGV()
        {
            List<SINHVIEN> listStudent = context.SINHVIEN.ToList(); //lấy sinh viên  Câu lệnh LinQ
            BindGrid(listStudent);
        }
        private void reloadDGVThanNhan()
        {
            List<NGUOITHANSV> listThanNhan = context.NGUOITHANSV.Where(p=>p.CCCD==txtCCCD.Text).ToList(); //lấy sinh viên  Câu lệnh LinQ
            if (listThanNhan.Count ==0)
            {
                dgvThanNhan.Rows.Clear();
            }else
            {
                BindGridThanNhan(listThanNhan);
            }
           
        }
        private void frmNV_ListStudent_Load(object sender, EventArgs e)
        {
            try
            {
                List<TRUONGHOC> listSchool = context.TRUONGHOC.ToList();
                List<PHONGSV> listRoom = context.PHONGSV.ToList();
                List<SINHVIEN> listStudent = context.SINHVIEN.ToList();
                //List<TOANHA> listToa = context.TOANHA.ToList();
                FillRoomCombobox(listRoom);
                FillSchoolCombobox(listSchool);
                BindGrid(listStudent);
                cmbViewListSV.SelectedIndex = 0;
                robMale.Checked = true;
                cmbRoom.SelectedIndex = 0;
                cmbSchool.SelectedIndex = 0;
                pnAddStudent.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                string thongbao = "\nTạo Mới Tài Khoản Thành Công!\nTài khoản: " + txtCCCD.Text + "\nMật khẩu: " + txtPhoneSV.Text;
                string ngay = String.Format("{0:yyyy-MM-dd}", dtpBirthday.Value);
                //string ngayvaoktx = String.Format("{0:yyyy-MM-dd}", dtpNgayVaoKTX.Value);
                string gioitinh;
                if (robMale.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                if (GetSelectedRow(txtCCCD.Text) == -1)
                {
                    ACCOUNT user = context.ACCOUNT.FirstOrDefault(p => p.USER == txtCCCD.Text);
                    SINHVIEN masv = context.SINHVIEN.FirstOrDefault(p => p.CCCD == txtCCCD.Text);
                    //PHONGSV phongsv = context.PHONGSV.FirstOrDefault();
                    if (masv == null)
                    {
                        SINHVIEN sv = new SINHVIEN()
                        {
                            CCCD = txtCCCD.Text,
                            MSSV = txtStudentID.Text,
                            HOTEN = txtStudentName.Text,
                            DIACHI = txtAddressSV.Text,
                            EMAIL = txtEmail.Text,
                            SDT = txtPhoneSV.Text,
                            GIOITINH = gioitinh,
                            NGAYVAOKTX = DateTime.Now,
                            NAMSINH = dtpBirthday.Value,
                            MATRUONG = cmbSchool.SelectedValue.ToString(),
                            MAPHONG = cmbRoom.SelectedValue.ToString(),
                            TRANGTHAI = "Đang Ở"
                        };
                        ACCOUNT a = new ACCOUNT()
                        {
                            USER = txtCCCD.Text,
                            PASS = txtPhoneSV.Text,
                            QUYEN = "USER",
                            CCCD = txtCCCD.Text
                        };
                        NGUOITHANSV nguoithan = new NGUOITHANSV()
                        {
                            TENNGUOITHAN = txtTenThanNhan.Text,
                            QUANHEVOISV = cmbQuanHeVoiSV.SelectedItem.ToString(),
                            SDT = txtSDTThanNhan.Text,
                            DIACHI = txtDiaChiTN.Text,
                            CCCD = txtCCCD.Text
                        }; 
                        PHONGSV phongsv = context.PHONGSV.FirstOrDefault(p => p.MAPHONG == cmbRoom.SelectedValue.ToString());
                        {
                            if (phongsv.SOLUONG > 0)
                            {
                                phongsv.SOLUONG -= 1;
                                context.SINHVIEN.Add(sv);
                                context.ACCOUNT.Add(a);
                                context.NGUOITHANSV.Add(nguoithan);
                                context.SaveChanges();
                                MessageBox.Show("Thêm mới dữ liệu thành công!" + thongbao, "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Phòng Đã Đầy", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        context.SaveChanges();
                        HOADONLEPHI lephi = new HOADONLEPHI()
                        {
                            CCCD = txtCCCD.Text,
                            NGAYLAP = DateTime.Now,
                            MANV = manv,
                            TRANGTHAI = "Chưa Thanh Toán",
                            TONGTIEN = 0,
                            HANCUOI = DateTime.Now.AddMonths(int.Parse(cmbSoThang.SelectedItem.ToString()))
                        };
                        context.HOADONLEPHI.Add(lephi);
                        context.SaveChanges();
                        CTHOADONLEPHI ctiethoadon = new CTHOADONLEPHI()
                        {
                            SOTHANG = int.Parse(cmbSoThang.SelectedItem.ToString()),
                            MAPHONG = sv.MAPHONG,
                            MAHDLEPHI = lephi.MAHDLEPHI
                        };
                        context.CTHOADONLEPHI.Add(ctiethoadon);
                        context.SaveChanges();
                        reloadDGV();
                        setNull();
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
            }
            else
            {
                string ngay = String.Format("{0:yyyy-MM-dd}", dtpBirthday.Value);
                string gioitinh;
                if (robMale.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                SINHVIEN dbUpdate = context.SINHVIEN.FirstOrDefault(p => p.CCCD == txtCCCD.Text);
                if (dbUpdate != null)
                {
                    {
                        dbUpdate.CCCD = txtCCCD.Text;
                        dbUpdate.MSSV = txtStudentID.Text;
                        dbUpdate.HOTEN = txtStudentName.Text;
                        dbUpdate.DIACHI = txtAddressSV.Text;
                        dbUpdate.EMAIL = txtEmail.Text;
                        dbUpdate.SDT = txtPhoneSV.Text;
                        dbUpdate.GIOITINH = gioitinh;
                        dbUpdate.NAMSINH = dtpBirthday.Value;
                        dbUpdate.MATRUONG = cmbSchool.SelectedValue.ToString();
                        dbUpdate.MAPHONG = cmbRoom.SelectedValue.ToString();
                        context.SaveChanges();
                        MessageBox.Show("Cập Nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK);
                }
                if (txtTenThanNhan.Text != "")
                {
                    NGUOITHANSV dbUpdateTN = context.NGUOITHANSV.FirstOrDefault(p => p.CCCD.ToString() == txtCCCD.Text);
                    if (dbUpdateTN != null)
                    {
                        dbUpdateTN.TENNGUOITHAN = txtTenThanNhan.Text;
                        dbUpdateTN.QUANHEVOISV = cmbQuanHeVoiSV.SelectedItem.ToString();
                        dbUpdateTN.SDT = txtSDTThanNhan.Text;
                        dbUpdateTN.DIACHI = txtDiaChiTN.Text;
                        context.SaveChanges();
                    }
                }
                reloadDGVThanNhan();
                reloadDGV();
                setNull();
            }
        }
        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            ACCOUNT tt = context.ACCOUNT.FirstOrDefault(p => p.USER == txtCCCD.Text);
            SINHVIEN dbDelete = context.SINHVIEN.FirstOrDefault(p => p.CCCD == txtCCCD.Text);
            PHONGSV phongsv = context.PHONGSV.FirstOrDefault(p => p.MAPHONG == cmbRoom.SelectedValue.ToString());
            if (dbDelete != null)
            {
                DialogResult noti = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (noti == DialogResult.Yes)
                {
                    phongsv.SOLUONG += 1;
                    context.ACCOUNT.Remove(tt);
                    dbDelete.TRANGTHAI = "Đã Chuyển Đi";
                    dbDelete.NGAYRAKTX = DateTime.Now;
                    context.SaveChanges();
                    if (txtTenThanNhan.Text != "")
                    {
                        NGUOITHANSV dbDeleteTN = context.NGUOITHANSV.FirstOrDefault(p => p.CCCD.ToString() == txtCCCD.Text);
                        context.NGUOITHANSV.Remove(dbDeleteTN);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    dgvThanNhan.Rows.Clear();
                    reloadDGV();
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần Xóa ", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            setNull();
        }
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true;
                    txtCCCD.Text = dgvStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    dtpBirthday.Value = DateTime.Parse(dgvStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    string gioitinh = dgvStudent.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    if (gioitinh == "Nam")
                    {
                        robMale.Checked = true;
                    }
                    else
                    {
                        robFemale.Checked = true;

                    }
                    txtPhoneSV.Text = dgvStudent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    txtEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    txtAddressSV.Text = dgvStudent.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    cmbRoom.SelectedIndex = cmbRoom.FindString(dgvStudent.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
                    cmbSchool.SelectedIndex = cmbSchool.FindString(dgvStudent.Rows[e.RowIndex].Cells[12].FormattedValue.ToString());
                    List<NGUOITHANSV> listThanNhan = context.NGUOITHANSV.Where(p=>p.CCCD == txtCCCD.Text).ToList();
                    BindGridThanNhan(listThanNhan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dieuchinh(bool e)
        {
            if (e == true)
            {
                pnAddStudent.Visible = true;
                iconUpDown.IconChar = IconChar.CaretDown;
            }
            else
            {
                pnAddStudent.Visible = false;
                iconUpDown.IconChar = IconChar.CaretUp;
            }
        }
        private void iconUpDown_Click(object sender, EventArgs e)
        {
            if (iconUpDown.IconChar == IconChar.CaretUp)
            {
                dieuchinh(true);
            }
            else
            {
                dieuchinh(false);
            }
        }
        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            List<SINHVIEN> listSVSearch = new List<SINHVIEN>();
            List<SINHVIEN> listSinhVien = context.SINHVIEN.ToList();
            string search = txtSearchSV.Text;
            if (search != "")
            {
                foreach (SINHVIEN item in listSinhVien)
                {
                    if (item.HOTEN.ToLower().Contains(search.ToLower()) || item.MSSV.ToLower().Contains(search.ToLower()) || item.CCCD.ToLower().Contains(search.ToLower()) || item.SDT.ToLower().Contains(search.ToLower()))
                    {
                        listSVSearch.Add(item);
                    }
                }
                BindGrid(listSVSearch);
            }
            else
            {
                BindGrid(listSinhVien);
            }
        }
        //Thân Nhân Sinh Viên
        private void dgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvThanNhan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvThanNhan.CurrentRow.Selected = true;
                    txtTenThanNhan.Text = dgvThanNhan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cmbQuanHeVoiSV.SelectedIndex = cmbQuanHeVoiSV.FindString(dgvThanNhan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    txtSDTThanNhan.Text = dgvThanNhan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtDiaChiTN.Text = dgvThanNhan.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    dieuchinh(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xuất DS Sinh Viên Sang Excel
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "STT";

            cl1.ColumnWidth = 8;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "CCCD";

            cl2.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã Sinh Viên";

            cl3.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Họ Tên";

            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày Sinh";

            cl5.ColumnWidth = 24;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Giới Tính";

            cl6.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Số ĐT";

            cl7.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Email";

            cl8.ColumnWidth = 24;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Địa Chỉ";

            cl9.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Ngày Vào KTX";

            cl10.ColumnWidth = 24;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Ngày Ra KTX";

            cl11.ColumnWidth = 24;


            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

            cl12.Value2 = "Phòng";

            cl12.ColumnWidth = 18.5;


            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");

            cl13.Value2 = "Trường";

            cl13.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("N3", "N3");

            cl14.Value2 = "Trạng Thái";

            cl14.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "N3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnOutputExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("STT");
            DataColumn col2 = new DataColumn("CCCD");
            DataColumn col3 = new DataColumn("MSSV");
            DataColumn col4 = new DataColumn("HOTEN");
            DataColumn col5 = new DataColumn("NAMSINH");
            DataColumn col6 = new DataColumn("GIOITINH");
            DataColumn col7 = new DataColumn("SDT");
            DataColumn col8 = new DataColumn("EMAIL");
            DataColumn col9 = new DataColumn("DIACHI");
            DataColumn col10 = new DataColumn("NGAYVAOKTX");
            DataColumn col11 = new DataColumn("NGAYRAKTX");
            DataColumn col12 = new DataColumn("PHONGSV.MAPHONGSV");
            DataColumn col13 = new DataColumn("TENTRUONG");
            DataColumn col14 = new DataColumn("TRANGTHAI");


            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);
            dataTable.Columns.Add(col13);
            dataTable.Columns.Add(col14);

            foreach (DataGridViewRow dgvRow in dgvStudent.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dgvRow.Cells[0].Value;
                dtRow[1] = dgvRow.Cells[1].Value;
                dtRow[2] = dgvRow.Cells[2].Value;
                dtRow[3] = dgvRow.Cells[3].Value;
                dtRow[4] = dgvRow.Cells[4].Value;
                dtRow[5] = dgvRow.Cells[5].Value;
                dtRow[6] = dgvRow.Cells[6].Value;
                dtRow[7] = dgvRow.Cells[7].Value;
                dtRow[8] = dgvRow.Cells[8].Value;
                dtRow[9] = dgvRow.Cells[9].Value;
                dtRow[10] = dgvRow.Cells[10].Value;
                dtRow[11] = dgvRow.Cells[11].Value;
                dtRow[12] = dgvRow.Cells[12].Value;
                dtRow[13] = dgvRow.Cells[13].Value;
                // dtRow[10] = dgvRow.Cells[10].Value;

                dataTable.Rows.Add(dtRow);
            }
            ExportFile(dataTable, "Danh Sach", "Danh Sách Sinh Viên");
        }
    }
}
