using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCSDL_HW01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AES_Click(object sender, EventArgs e)
        {
            AES aesForm = new BMCSDL_HW01.AES();
            aesForm.Show();
        }

        private void RSA_Click(object sender, EventArgs e)
        {
            RSA rsaForm = new RSA();
            rsaForm.Show();
        }

        private void thresHold_Click(object sender, EventArgs e)
        {
            ThresHoldSchemeForm thresholdForm = new ThresHoldSchemeForm();
            thresholdForm.Show();
        }
    }
}
