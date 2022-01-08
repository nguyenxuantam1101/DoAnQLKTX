using QLKTX.DATA;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.GUI
{
    public partial class frmLogin : Form
    {
        KTXDBContext context = new KTXDBContext();
        public static string role = "";
        public static string userLogin = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                ACCOUNT user = context.ACCOUNT.FirstOrDefault(p => p.USER == txtUser.Text && p.PASS == txtPass.Text);
                if (user != null)
                {
                    frmKTX_Main f = new frmKTX_Main(user.QUYEN, user.MANV, user.CCCD);
                    this.Hide();
                    role = user.QUYEN;
                    userLogin = user.MANV;
                    userLogin = user.CCCD;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void cbRememberMe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != null && txtPass.Text != null)
                {
                    if (cbRememberMe.Checked == true)
                    {
                        string username = txtUser.Text;
                        string password = txtPass.Text;
                        Properties.Settings.Default.User = username;
                        Properties.Settings.Default.Pass = password;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Reset();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPass_IconRightClick(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.IconRight = Properties.Resources.icon_hide_final;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
