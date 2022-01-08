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
        public frmSV_Info()
        {
            InitializeComponent();
        }

        private void frmSV_Info_Load(object sender, EventArgs e)
        {
            //Tab thông tin sinh viên

        }
    }
}
