using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // to be able to use XML
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Marella_MORAD___SD_SAT___2019
{
    public partial class Form8 : Form
    {
        //public variables to be used accross multiple methods
        string SecQns;
        string SecAns;

        string decryptedPassword;

        // to be used for counting the times a button is pressend
        int SubmitCount;
        int CheckCount;

        bool Found = false;
        bool UNFound = false;


        public Form8()
        {
            InitializeComponent();
            CheckAnsBtn.Enabled = false; // disable as the username hasn't yet been checked
        }
        
        private void SubmitUNBtn_Click(object sender, EventArgs e)
        {
            SubmitCount++; //increse everytime the button is clicked

            //Load the xml
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("dataBase.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("dataBase/user")) //to run through the xml file
            {
                //check if the username entered match with the data in the XML file
                if (xNode.SelectSingleNode("username").InnerText == UNTextBox.Text)
                {
                    SecQns = xNode.SelectSingleNode("security_question").InnerText; //get the question
                    SecAns = xNode.SelectSingleNode("security_question_answer").InnerText; //get the answer

                    CheckAnsBtn.Enabled = true; // enable the CheckAnsBtn
                    SubmitUNBtn.Enabled = false;
                    UNFound = true;
                }
            }

            QnsLabel.Text = SecQns; // Display the question

            if (string.IsNullOrEmpty(UNTextBox.Text))
            {
                MessageBox.Show("Please enter a username to resotre the password for");
            }

            else if (UNFound == false)
            {
                //Display different messages depending on the times the button is clicked
                if (SubmitCount < 4 && SubmitCount >= 1)
                {
                    MessageBox.Show("Please check your username and try again - it doesn't seem to exist");
                }

                else if (SubmitCount == 4)
                {
                    //after the user falies to enter a username that exissts 3 times, disable the submitbtn, and ask them if they want to create a new account 
                    MessageBox.Show("Your username doesn't exist, please contact the adminstration team. Otherwise, feel free to create a new account");
                    SubmitUNBtn.Enabled = false;

                    ExistSelection();
                }
            }
        }

        private void CheckAnsBtn_Click(object sender, EventArgs e)
        {
            CheckCount++; //increse everytime the button is clicked
            if (string.IsNullOrEmpty(AnsTextBox.Text))
            {
                MessageBox.Show("Please enter an Answer to the question displayed above");
            }
            else if (SecAns == AnsTextBox.Text) // if the answer is correct, decrypt the password and display it
            {
                DecryptPassword();
            }
            //Display different messages depending on the times the button is clicked
            else if (CheckCount < 4)
            {
                MessageBox.Show("Sorry, wrong answer - please try again and be careful the app is case sensitive (upper or lower cases matter)");
            }
            else if (CheckCount == 4)
            {
                MessageBox.Show("Your answer doesn't seem to match, please contact the administration team. Otherwise, feel free to create a new account");
                CheckAnsBtn.Enabled = false;
                ExistSelection();
            }
        }

        void ExistSelection()
        {
            DialogResult dialog = MessageBox.Show("Do you want to go back to Signup? Otherwise the program will close.", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                // if yes send them back to the signup page
                Form2 SignUp = new Form2();
                SignUp.Show(); // Open SignUp
                this.Hide(); // Close this one
            }
            else if (dialog == DialogResult.No)
            {
                //if no close the program
                Application.ExitThread(); // to exit the program if the user press on the x button
            }
        }

        void DecryptPassword()
        {
            //Password decryption
            string vUsername = UNTextBox.Text;
            string key = "Memo";

            //load the xml
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("dataBase.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("dataBase/user"))
            {
                if (xNode.SelectSingleNode("username").InnerText == vUsername)
                {
                    //retrives the encrypted password from the xml file
                    string encryptedPassword = xNode.SelectSingleNode("password").InnerText;

                    //decrypts the encrypted password with the key, using the Decrypt method in the StringCipher class
                    decryptedPassword = StringCipher.Decrypt(encryptedPassword, key);

                    Found = true;
                }
            }

            if (Found == true)
            {
                MessageBox.Show("Your password is : " + decryptedPassword + " make sure you don't lose it again!");
                // send them back to login
                Form3 Login = new Form3();
                Login.Show();
                this.Hide();
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

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
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
