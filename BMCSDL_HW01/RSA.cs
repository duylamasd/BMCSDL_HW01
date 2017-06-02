using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCSDL_HW01
{
    public partial class RSA : Form
    {
        RSAProtocol protocol { get; set; }
        private byte[] cipher { get; set; }
        private byte[] decrypted { get; set; }

        public RSA()
        {
            InitializeComponent();
            protocol = new RSAProtocol();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (plainTextBox.Text == "Type any thing here for plain text.")
            {
                MessageBox.Show("Enter you string which you want to encrypt.");
                return;
            }

            byte[] plain = Encoding.Unicode.GetBytes(plainTextBox.Text);
            cipher = protocol.encryptBytes(plain);

            string cipherText = Encoding.Unicode.GetString(cipher);
            cipherTextBox.Text = cipherText;
            string publicKeyInfo = protocol.e.ToString();
            publicKeyBox.Text = publicKeyInfo;

            MessageBox.Show("Encrypting done!");
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (cipherTextBox.Text == "")
            {
                MessageBox.Show("You haven't encrypt any thing yet.");
                return;
            }

            decrypted = protocol.decryptBytes(cipher);

            string decryptResult = Encoding.Unicode.GetString(decrypted);
            decryptedTextBox.Text = decryptResult;
            MessageBox.Show("Decrypting done!");

            publicKeyBox.Text = "";
        }
    }
}
