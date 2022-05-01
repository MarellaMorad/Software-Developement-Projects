using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// to be able to use XML
using System.Xml;
using System.IO;
// to be able to encrypt the password
using System.Linq;
using System.Security.Cryptography;

namespace Marella_MORAD___SD_SAT___2019
{
    // By: Marella MORAD
    // Last edited: 07 - Aug - 2019

    public partial class Form3 : Form
    {
        // assign public variables to be used all over the program
        string vLoginUN;
        string vLoginPass;

        string decryptedPassword; // store the decryptedpassword

        public Form3()
        {
            InitializeComponent();
            HidePass.Visible = false; // Hide the HidePass button as the text is already coverted into PassChar
        }

        public static string passingText; // to pass the username later to Forms 5,6 and 7

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login(); // Run Login first as it includes validation, brfore actually passing the username
            passingText = UNTextBox.Text; // assign the value for passingText
        }

        void Login()
        {
            //assign the values to the variables and run Validation
            vLoginUN = UNTextBox.Text;
            vLoginPass = PassTextBox.Text;

            ExistanceValidation();
        }

        void ExistanceValidation()
        {
            if (String.IsNullOrEmpty(vLoginUN) || String.IsNullOrEmpty(vLoginPass)) // existance check
            {
                MessageBox.Show("Please enter a Username/Password");
            }
            else
            {
                CheckData();
            }
           
        }

        void CheckData() // to check wether the details exist or not
        {
            bool Found = false;

            XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
            xDoc.Load("dataBase.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("dataBase/user")) //to run through the xml file
            {
                DecryptPassword();

                //check if the username and password entered match with the data in the XML file
                if (xNode.SelectSingleNode("username").InnerText == UNTextBox.Text && decryptedPassword == PassTextBox.Text)
                {
                    Found = true;
                }
            }

            if (Found == false)
            {
                MessageBox.Show("Incorrect Username/Password");
            }
            // if the data are correct, go to the next form
            else
            {
                Form4 Selection = new Form4(); // open the next form
                Selection.Show();
                this.Hide();
            }
        }

        void DecryptPassword()
        {
            //password decryption
            string searchedUser = vLoginUN;
            string key = "Memo";

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("dataBase.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("dataBase/user"))
            {
                if (xNode.SelectSingleNode("username").InnerText == searchedUser)
                {
                    //retrives the encrypted password from the xml file
                    string encryptedPassword = xNode.SelectSingleNode("password").InnerText;

                    //decrypts the encrypted password with the key, using the Decrypt method in the StringCipher class
                    decryptedPassword = StringCipher.Decrypt(encryptedPassword, key);
                }
            }
        }

        public static class StringCipher
        {
            // This constant is used to determine the keysize of the encryption algorithm in bits.
            // We divide this by 8 within the code below to get the equivalent number of bytes.
            private const int Keysize = 256;

            // This constant determines the number of iterations for the password bytes generation function.
            private const int DerivationIterations = 1000;

            public static string Decrypt(string cipherText, string passPhrase)
            {
                // Get the complete stream of bytes that represent:
                // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
                var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
                // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
                var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
                // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
                var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
                // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
                var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    var plainTextBytes = new byte[cipherTextBytes.Length];
                                    var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }

            private static byte[] Generate256BitsOfRandomEntropy()
            {
                var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    // Fill the array with cryptographically secure random bytes.
                    rngCsp.GetBytes(randomBytes);
                }
                return randomBytes;
            }
        }

        // to go back to the SignUp page
        private void SkipBackBtn_Click(object sender, EventArgs e)
        {
            Form2 SignUp = new Form2();
            SignUp.Show(); // Open the SignUp form
            this.Hide(); // Close this one
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password should be 6 to 8 characters"); //information abot password restrictions
        }

        private void ForgotPassBtn_Click(object sender, EventArgs e)
        {
            Form8 PassReset = new Form8();
            PassReset.Show(); // Open the Password Reset form
            this.Hide(); // Close this one
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            // if the HidePass button was clicked, show the password as circuls / password char
            // show the ShowPass button and hide the HidePass button
            PassTextBox.UseSystemPasswordChar = true;
            HidePass.Visible = false;
            ShowPass.Visible = true;
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            // if the ShowPass button was clicked, show the actual letters and numbers of the password
            // hide the ShowPass button and show the HidePass button
            PassTextBox.UseSystemPasswordChar = false;
            HidePass.Visible = true;
            ShowPass.Visible = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread(); // to exit the program if the user press on the x button
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true; // to not exit the program if the user pressed No (as exit may be pressed by mistake and therefore avoid loss of data)
            }
        }
    }
}