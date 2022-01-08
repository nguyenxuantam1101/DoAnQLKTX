using FontAwesome.Sharp;
using QLKTX.DATA;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmKTX_Main : Form
    {
        string quyen = "";
        string manv = "";
        string CCCD = "";
        KTXDBContext context = new KTXDBContext();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmKTX_Main(string quyen, string manv, string CCCD)
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
            this.CCCD = CCCD;
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
                //iconCurrentHome.IconChar = currentBtn.IconChar;
                //iconCurrentHome.IconColor = color;
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
            hidePnMenu();
            if (quyen == "ADMIN")
            {
                //pnSystem.Visible = true;
                ////pnAccountManager.Visible = true;
                //pnCatalog.Visible = true;
                //pnBill.Visible = true;
                //pnStatistic.Visible = true;
                //pnChucNangInfor.Visible = true;
            }
            else if (quyen == "MANAGE")
            {
                //pnCatalog.Visible = true;
                //pnBill.Visible = true;
                //pnStatistic.Visible = true;
                //pnChucNangInfor.Visible = true;
                btnHeThong.Visible = false;
                pnSystem.Visible = false;
            }
            else //USER
            {
                //pnExtendCatalog.Visible = true;
                //pnExtendBill.Visible = true;
                //pnChucNangInfor.Visible = true;
                btnHeThong.Visible = false;
                btnThongKe.Visible = false;
                pnSystem.Visible = false;
                pnStatistic.Visible = false;
                pnStatisticMenu.Visible = false;
            }
            //Hiện thị tên
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
            //lblTitleChildForm.Text = childForm.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_AddRoom());
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_ListAccount());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_ListEmployee());
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_ListStudent());
        }

        private void btnToa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_AddBuilding());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_AddRoom());
        }

        private void btnSVInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSV_Info());
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmNV_AddRoom());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNV_CreateBill(manv));
        }

        private void btnSV_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSV_InfoBill(CCCD));
        }

        private void btnReportHoaDon_Click(object sender, EventArgs e)
        {
            //chưa có form
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            //chưa có form
        }
    }
}
