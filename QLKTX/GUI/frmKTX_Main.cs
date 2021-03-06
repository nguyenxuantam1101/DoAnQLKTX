using FontAwesome.Sharp;
using QLKTX.DATA;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmKTX_Main : Form
    {
        string quyen = "";
        string manv = "";
        string cCCD = "";
        string userLogin = "";
        KTXDBContext context = new KTXDBContext();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmKTX_Main(string quyen, string manv, string cCCD, string userLogin )
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.quyen = quyen;
            this.manv = manv;
            this.cCCD = cCCD;
            this.userLogin = userLogin;
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(151, 255, 255);
            public static Color color8 = Color.FromArgb(106, 90, 205);
            public static Color color9 = Color.FromArgb(67, 110, 238);
            public static Color color10 = Color.FromArgb(255, 106, 106);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentHome.IconChar = currentBtn.IconChar;
                iconCurrentHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void hidePnMenu()
        {
            pnAccountManager.Visible = false;//ADMIN(NV)
            pnCatalog.Visible = false;//NV
            pnExtendCatalog.Visible = false;//SV
            pnBill.Visible = false;//NV
            pnExtendBill.Visible = false;//SV
            pnStatisticMenu.Visible = false;//NV
            pnChucNangInfor.Visible = false;
        }
        private void frmKTX_Main_Load(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = context.NHANVIEN.FirstOrDefault(p => p.MANV == manv);
            SINHVIEN sinhvien = context.SINHVIEN.FirstOrDefault(p => p.CCCD == cCCD);
            hidePnMenu();
            if (quyen == "ADMIN")
            {
                btnTextInfor.Text = nhanvien.HOTENNV;
            }
            else if (quyen == "MANAGE")
            {
                btnHeThong.Visible = false;
                pnSystem.Visible = false;
                btnTextInfor.Text = nhanvien.HOTENNV;
            }
            else //USER
            {
                btnHeThong.Visible = false;
                btnThongKe.Visible = false;
                pnSystem.Visible = false;
                pnStatistic.Visible = false;
                pnStatisticMenu.Visible = false;
                btnTextInfor.Text = sinhvien.HOTEN;
            }
        }
        //click danh muc -> show menu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidePnMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(pnAccountManager);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (quyen != "")
            {
                if (quyen == "ADMIN" || quyen == "MANAGE")
                {
                    showSubMenu(pnCatalog);
                }
                else
                {
                    showSubMenu(pnExtendCatalog);
                }    
            }
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            if (quyen != "")
            {
                if (quyen == "ADMIN" || quyen == "MANAGE")
                {
                    showSubMenu(pnBill);
                }
                else
                {
                    showSubMenu(pnExtendBill);
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(pnStatisticMenu);
        }
        private void btnTextInfor_Click(object sender, EventArgs e)
        {
            
            showSubMenu(pnChucNangInfor);
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnHienThiFormCon.Controls.Add(childForm);
            pnHienThiFormCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmChangePass(userLogin));
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmNV_ListAccount());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmNV_ListEmployee());
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmNV_ListStudent(manv));
        }

        private void btnToa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmNV_AddBuilding());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frmNV_AddRoom());
        }

        private void btnSVInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmSV_Info(cCCD));
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmNV_AddRoom());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmNV_CreateBill(manv));
        }

        private void btnSV_HoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmSV_InfoBill(cCCD));
        }

        private void btnReportHoaDon_Click(object sender, EventArgs e)
        {
            //chưa có form
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            //chưa có form
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentHome.IconChar = IconChar.Home;
            iconCurrentHome.IconColor = Color.OrangeRed;
            lblTitleChildForm.Text = "TRANG CHỦ";
        }
    }
}
