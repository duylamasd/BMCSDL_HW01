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
    public partial class AES : Form
    {
        private byte[] cipher { get; set; }
        private byte[] decrypted { get; set; }
        private byte[] IV { get; set; }

        public AES()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (keyBox.Text == "")
            {
                MessageBox.Show("Enter your key.");
                return;
            }

            if (plainTextBox.Text == "Type any thing here for plain text.")
            {
                MessageBox.Show("Enter you string which you want to encrypt.");
                return;
            }

            AESProtocol protocol = new AESProtocol();

            byte[] keyBytes = Encoding.Unicode.GetBytes(keyBox.Text);
            byte[] plain = Encoding.Unicode.GetBytes(plainTextBox.Text);
            cipher = protocol.encryptBytes(plain, keyBytes);
            IV = protocol.IV;

            string cipherText = Encoding.Unicode.GetString(cipher);
            cipherTextBox.Text = cipherText;
            MessageBox.Show("Encrypting done!");
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (keyBox.Text == "")
            {
                MessageBox.Show("Enter your key.");
                return;
            }

            if (cipherTextBox.Text == "")
            {
                MessageBox.Show("You haven't encrypt any thing yet.");
                return;
            }

            AESProtocol protocol = new AESProtocol();

            byte[] keyBytes = Encoding.Unicode.GetBytes(keyBox.Text);
            decrypted = protocol.decryptBytes(cipher, keyBytes, IV);

            string decryptResult = Encoding.Unicode.GetString(decrypted);
            decryptedTextBox.Text = decryptResult;
            MessageBox.Show("Decrypting done!");
        }
    }
}
