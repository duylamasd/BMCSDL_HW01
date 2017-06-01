using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCSDL_HW01
{
    public partial class ThresHoldSchemeForm : Form
    {
        private ThresholdScheme scheme { get; set; }
        private List<Tuple<BigInteger, BigInteger>> provided { get; set; }

        public ThresHoldSchemeForm()
        {
            InitializeComponent();
        }

        private void provide_Click(object sender, EventArgs e)
        {
            if (thresHoldBox.Text == "")
            {
                MessageBox.Show("Please enter the threshold.");
                return;
            }

            if (!thresHoldBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter the threshold as numeric.");
                return;
            }

            int threshold;
            Int32.TryParse(thresHoldBox.Text, out threshold);
            scheme = new ThresholdScheme(threshold);
            provided = new List<Tuple<BigInteger, BigInteger>>();
            privateBox.Text = scheme.privateKey.ToString();
            modBox.Text = scheme.mod.ToString();

            for (int i = 0; i <= threshold; i++)
            {
                Tuple<BigInteger, BigInteger> newKey = scheme.provideNewKey();
                provided.Add(newKey);
                string newItemForList = "(" + newKey.Item1 + ", " + newKey.Item2 + ")";
                providedList.Items.Add(newItemForList);
            }
        }

        private void caculate_Click(object sender, EventArgs e)
        {
            BigInteger calculatedKey;
            calculatedKey = scheme.getKeyFromMembers(provided);
            calculatedBox.Text = calculatedKey.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            providedList.Items.Clear();
            calculatedBox.Text = "";
            privateBox.Text = "";
            thresHoldBox.Text = "";
            provided.Clear();
        }
    }
}
