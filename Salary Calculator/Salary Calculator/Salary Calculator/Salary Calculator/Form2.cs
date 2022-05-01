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
    // Last edited: 23 - Jul - 2019

    public partial class Form2 : Form
    {
        // assign public strings so they could e used all over the program 
        string vUsername; // to store the username
        string vPassword; // to store the password
        string vConPass; // to store the confirmation password

        string SecQns; // to store the security question
        string SecAns; // to store the security question answer

        public Form2()
        {
            InitializeComponent();

            // To hide the Hide buttons as the text is already coverted into PassChar
            HideConPass.Visible = false;
            HidePass.Visible = false;

            // To hide the QnsLabel & QnsTextBox as the user hasn't yet chose whether to write their own question or not
            QnsLabel.Visible = false;
            QnsTextBox.Visible = false;

            // Run
            SecurityQnsDisplay();
        }

        public static string passingText; // to pass the username later to Forms 5,6 and 7

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            passingText = UNTextBox.Text; // assign the value for passingText

            SecAns = AnsTextBox.Text; // assign the value of SecAns

            SignUp(); // Run
        }

        void SignUp() // assign the values to the variables and run the validation
        {
            vUsername = UNTextBox.Text;
            vPassword = PassTextBox.Text;
            vConPass = ConPassTextBox.Text;

            SignUpValidation();
        }

        void XmlCheck() // run a check to see whether or not the xml file exists and act upon the results
        {
            if (File.Exists("dataBase.xml") == false)
            {
                NewXML(); // if it doesn't exist, create a new one
            }
            else if (File.Exists("dataBase.xml") == true)
            {
                SaveData(); // if it exists, save the data
            }
        }

        void SignUpValidation()
        {
            UsernameValidation(); // to validate the username only
        }

        void UsernameValidation()
        {
            bool UNSpaces = vUsername.Contains(" "); // to check if the username contains any spaces, it is not allowed to have spaces

            bool Found = false;
            if (File.Exists("dataBase.xml") == true) // check if the xml file exists
            {
                //Load the xml file
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("dataBase.xml");

                foreach (XmlNode xNode in xDoc.SelectNodes("dataBase/user")) //to run through the xml file
                {
                    //check if the username entered already exists
                    if (xNode.SelectSingleNode("username").InnerText == UNTextBox.Text)
                    {
                        Found = true; //set Found to true so that it can be checked later ( if the username is found)
                    }
                }
            }

            // Start Validation...
            if (String.IsNullOrEmpty(vUsername)) // existance check
            {
                MessageBox.Show("Please enter a Username");
            }
            // there is no need for type or range check because the isn't any further calculations
            // it will only be stored in the xml file to be checked later

            // spaces check - spaces are not allowed
            else if (UNSpaces == true)
            {
                MessageBox.Show("Spaces aren’t accepted, please retype your username without any spaces");
            }

            // Check if the username already exists so it doesn't allow the same username to be entered twice
            else if (Found == true)
            {
                MessageBox.Show("Username already taken, please choose a different one");
            }
            // if the usernmae passes the validation move on to PasswordValidation
            else
            {
                PasswordValidation();
            }
        }

        void PasswordValidation() // to validate the password
        {
            bool PassSpaces = vPassword.Contains(" "); // to check for spaces

            if (String.IsNullOrEmpty(vPassword)) // existance check
            {
                MessageBox.Show("Please enter a Password");
            }
            // there is no need for type check because the isn't any further calculations

            // range check
            else if (vPassword.Length < 6 )
            {
                MessageBox.Show("Password should be at least 6 characters long");
            }

            // spaces check
            else if (PassSpaces == true)
            {
                MessageBox.Show("Spaces aren’t accepted, please retype your password without any spaces");
            }

            // if the password passes the validation move on to ConPasswordValidation
            else
            {
                ConPassValidation();
            }
        }

        void ConPassValidation() // to validate the confermation password
        {
            if (String.IsNullOrEmpty(vConPass)) // existance check
            {
                MessageBox.Show("Please enter a Confirmation Password");
            }
            // there is no need for type check because the isn't any further calculations

            // check if both passwords match
            else if (vPassword != vConPass)
            {
                MessageBox.Show("Passwords do NOT match");
            }

            //if it passes the validation
            else
            {
                SecQnsValidation(); //Run
            }
        }

        void SecurityQnsDisplay()
        {
            // To display the questions in the combo box
            SQcomboBox.Items.AddRange(new object[] {
            "What is your mother's maiden name?",
            "What is the name of your first pet?",
            "What was your first car?",
            "What primary school did you attend?",
            "What is the name of the town where you were born?",
            "Others..."});
        }

        void SaveSecurityQns()
        {
            // set the SecQns to a value depending on theuser's choice from the combobox
            if (SQcomboBox.Text == "What is your mother's maiden name?")
            {
                SecQns = "What is your mother's maiden name?";
            }
            else if (SQcomboBox.Text == "What is the name of your first pet?")
            {
                SecQns = "What is the name of your first pet?";
            }
            else if (SQcomboBox.Text == "What was your first car?")
            {
                SecQns = "What was your first car?";
            }
            else if (SQcomboBox.Text == "What primary school did you attend?")
            {
                SecQns = "What primary school did you attend?";
            }
            else if (SQcomboBox.Text == "What is the name of the town where you were born?")
            {
                SecQns = "What is the name of the town where you were born?";
            }
            else if (SQcomboBox.Text == "Others...")
            {
                // if the user chooses others, show the QnsLable and TextBox to allow them to enter their question and then assign it to SecQns
                QnsLabel.Visible = true;
                QnsTextBox.Visible = true;
            }
        }

        void SecQnsValidation()
        {
            // Start Validation...
            //existance check - for question
            if (SQcomboBox.Text == "Please choose a question...")
            {
                MessageBox.Show("Please choose a Security Question - in case of forgotten password, the security question will help us verify your account");
            }
            else if (SQcomboBox.Text == "Others..." && String.IsNullOrEmpty(QnsTextBox.Text))
            {
                MessageBox.Show("Please enter your Security Question - in case of forgotten password, the security question will help us verify your account");
            }

            //existance check - for answer
            else if (String.IsNullOrEmpty(AnsTextBox.Text))
            {
                MessageBox.Show("Please write and answer to the Security Question you choose");
            }
            else
            {
                XmlCheck(); // Run

                //Close this form and open the next one
                Form4 Selection = new Form4();
                Selection.Show(); // Show the Login page
                this.Hide(); // Hide this page
            }
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            // if the ShowPass button was clicked, show the actual letters and numbers of the password
            // hide the ShowPass button and show the HidePass button
            PassTextBox.UseSystemPasswordChar = false;
            HidePass.Visible = true;
            ShowPass.Visible = false;
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            // if the HidePass button was clicked, show the password as circuls / password char
            // show the ShowPass button and hide the HidePass button
            PassTextBox.UseSystemPasswordChar = true;
            HidePass.Visible = false;
            ShowPass.Visible = true;
        }

        private void ShowConPass_Click(object sender, EventArgs e)
        {
            // if the ShowConPass button was clicked, show the actual letters and numbers of the password
            // hide the ShowConPass button and show the HideConPass button
            ConPassTextBox.UseSystemPasswordChar = false;
            HideConPass.Visible = true;
            ShowConPass.Visible = false;
        }

        private void HideConPass_Click(object sender, EventArgs e)
        {
            // if the HideConPass button was clicked, show the password as circuls / password char
            // show the ShowConPass button and hide the HideConPass button
            ConPassTextBox.UseSystemPasswordChar = true;
            HideConPass.Visible = false;
            ShowConPass.Visible = true;
        }

        void NewXML()
        {
            //creates the XML file called dataBase.xml, using a new XmlTextWriter called xWriter
            XmlTextWriter xWriter = new XmlTextWriter("dataBase.xml", Encoding.UTF8);

            xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
            xWriter.WriteStartElement("dataBase");
            xWriter.WriteStartElement("user");
            xWriter.WriteStartElement("username");
            xWriter.WriteString(UNTextBox.Text);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("password");
            
            // Password encryption
            string key = "Memo";
            string passwordStored = PassTextBox.Text;
            string encryptedstring = StringCipher.Encrypt(passwordStored, key);
            xWriter.WriteString(encryptedstring);
            xWriter.WriteEndElement();

            
            xWriter.WriteStartElement("security_question");
            xWriter.WriteString(SecQns); // add the security question from either the combo or the text box
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("security_question_answer");
            xWriter.WriteString(SecAns); // add the security question from either the combo or the text box
            xWriter.WriteEndElement();

            xWriter.WriteEndElement();
            xWriter.WriteEndElement();

            xWriter.Close(); // to close access to the xml so it can be used by other applications.

            XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
            xDoc.Load("dataBase.xml");

            XmlDeclaration xmldecl; // create a declaration which is the line underneeth
            xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

            //Insert the XML declaration into the XML file and save
            XmlElement root = xDoc.DocumentElement;
            xDoc.InsertBefore(xmldecl, root); // to insert it before the root element
            xDoc.Save("dataBase.xml");
        }

        public static class StringCipher
        {
            // This constant is used to determine the keysize of the encryption algorithm in bits.
            // We divide this by 8 within the code below to get the equivalent number of bytes.
            private const int Keysize = 256;

            // This constant determines the number of iterations for the password bytes generation function.
            private const int DerivationIterations = 1000;

            public static string Encrypt(string plainText, string passPhrase)
            {
                // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
                // so that the same Salt and IV values can be used when decrypting.  
                var saltStringBytes = Generate256BitsOfRandomEntropy();
                var ivStringBytes = Generate256BitsOfRandomEntropy();
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                {
                                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                    cryptoStream.FlushFinalBlock();
                                    // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                    var cipherTextBytes = saltStringBytes;
                                    cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                    cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Convert.ToBase64String(cipherTextBytes);
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

        void SaveData()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("dataBase.xml");

            //create the new elements (under the root element)
            XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
            XmlNode username = xDoc.CreateElement("username");
            XmlNode password = xDoc.CreateElement("password");
            XmlNode secQuestion = xDoc.CreateElement("security_question");
            XmlNode secAns = xDoc.CreateElement("security_question_answer");

            // Get the values and store into the text of the elements, save the XML
            username.InnerText = UNTextBox.Text;
            user.AppendChild(username);

            //password encryption
            string key = "Memo";
            string passwordStored = PassTextBox.Text;

            string encryptedPassword = StringCipher.Encrypt(passwordStored, key);

            password.InnerText = encryptedPassword;
            user.AppendChild(password);

            secQuestion.InnerText = SecQns;// add the security qns
            user.AppendChild(secQuestion);

            secAns.InnerText = SecAns;// add the security ans
            user.AppendChild(secAns);

            xDoc.DocumentElement.AppendChild(user);
            xDoc.Save("dataBase.xml");
        }

        // in case the user realises they are in the wrong form
        // they won't need to restart the whole program
        private void SkipBtn_Click(object sender, EventArgs e)
        {
            Form3 Login = new Form3();
            Login.Show();
            this.Hide();
        }

        private void SQcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSecurityQns(); //Run if the choice is changed in the combobox
        }

        // to give the user more info about the passowrd restrictions
        private void InfoBtn_Click(object sender, EventArgs e) // to give the user more info about the passowrd restrictions
        {
            MessageBox.Show("Password should be at least 6 characters long");
        }

        // Runs if the X button is pressed
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void QnsTextBox_TextChanged(object sender, EventArgs e)
        {
            SecQns = QnsTextBox.Text;
        }
    }
}