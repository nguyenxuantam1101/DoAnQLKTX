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
    public partial class frmThongKeHDDienNuoc : Form
    {
        public frmThongKeHDDienNuoc()
        {
            InitializeComponent();
        }

        private void frmThongKeHDDienNuoc_Load(object sender, EventArgs e)
        {


        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            switch (radioButton.Name)
            {
                case "robThongKeNam":
                    dtpTKNam.Enabled = true;
                    dtpTKThang.Enabled = false;
                    dtpTKTu.Enabled = false;
                    dtpTKDen.Enabled = false;
                    break;
                case "robThongKeThang":
                    dtpTKNam.Enabled = false;
                    dtpTKThang.Enabled = true;
                    dtpTKTu.Enabled = false;
                    dtpTKDen.Enabled = false;
                    break;
                case "robThongKeTuDen":
                    dtpTKNam.Enabled = false;
                    dtpTKThang.Enabled = false;
                    dtpTKTu.Enabled = true;
                    dtpTKDen.Enabled = true;
                    break;
            }
        }
        private void btnThongKeDienNuoc_Click(object sender, EventArgs e)
        {

        }
    }
}
