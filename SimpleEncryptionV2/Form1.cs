using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SimpleEncryptionV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath;
        string folderpath;
        string origin_filename;
        string origin_fileextension;
        string origin_filetext;
        string hash = "UwUbotAndreasxD";
        bool encrypted;
        bool textfieldbool;
        public bool[] easteregg = new bool[6];
        private void setall(bool idk)
        {
            folderpath = "";
            origin_filename = "";
            origin_fileextension = "";
            string[] folderpathtmp = filepath.Split('\\');
            //folderpath
            for (int i = 0; i < folderpathtmp.Length - 1; i++)
            {
                folderpath += folderpathtmp[i] + "\\";
            }
            string[] folderpathtmp2 = folderpathtmp[folderpathtmp.Length - 1].Split('.');
            if (folderpathtmp2[0].Contains("_encrypted"))
            {
                encrypted = true;
                origin_filename = folderpathtmp2[0].Substring(0, folderpathtmp2[0].Length - 10);
            }
            else
            {
                encrypted = false;
                origin_filename = folderpathtmp2[0];
            }
            origin_fileextension = "." + folderpathtmp2[1];
            origin_filetext = File.ReadAllText(filepath);
            if (encrypted)
            {
                realblep.Text = origin_filetext;
                Unencrypt();
            }
            else
            {
                blep.Text = origin_filetext;
                Encrypt();
            } 
            Debug.WriteLine("filepath: " + filepath + "\nfolderpath: " + folderpath + "\nfilename: " + origin_filename + "\nextension: " + origin_fileextension);

        }

        private void Encrypt()
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(blep.Text);
            using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    realblep.Text = Convert.ToBase64String(results, 0, results.Length);
                }

            }
        }
        private void Unencrypt()
        {
            try
            {
                byte[] data = Convert.FromBase64String(realblep.Text); using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        blep.Text = UTF8Encoding.UTF8.GetString(results);
                    }

                }
            }
            catch { }


        }
        private void Button_ofd(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;
            filepath = ofd.FileName;
            if(textBox1.Text.Contains("_encrypted"))
            setall(true);else
                setall(false);
        }

        private void LoadFromfilebutton(object sender, EventArgs e)
        {
            if (encrypted)
            {
                realblep.Text = origin_filetext;
                Unencrypt();
                realblep.Update();
            }
            else
            {
                blep.Text = origin_filetext;
                Encrypt();
                blep.Update();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
            textBox1.Text = folderpath;
        }

        private void BtnExportEncrypted_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == folderpath)
            {
                MessageBox.Show("Please enter a Filename");

            }
            else
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".txt";
                }
                filepath = textBox1.Text;
                setall(false);
                Debug.WriteLine("Written to:" + folderpath + origin_filename + "_encrypted" + origin_fileextension);
                File.WriteAllText(folderpath + origin_filename + "_encrypted" + origin_fileextension, realblep.Text);
            }
        }

        private void BtnExportUnencrypted(object sender, EventArgs e)
        {
            if (textBox1.Text == folderpath)
            {
                MessageBox.Show("Please enter a Filename");
            }
            else
            {
                File.WriteAllText(folderpath + origin_filename + origin_fileextension, blep.Text);
                Debug.WriteLine("Written to:" + folderpath + origin_filename + origin_fileextension);
            }
        }

        private void blep_TextChanged(object sender, EventArgs e)
        {
            
            if (textfieldbool)
                Encrypt();
        }

        private void realblep_TextChanged(object sender, EventArgs e)
        {
            
            if (!textfieldbool)
                Unencrypt();
        }

        private void realblep_Enter(object sender, EventArgs e)
        {
            textfieldbool = false;
        }

        private void blep_Enter(object sender, EventArgs e)
        {
            textfieldbool = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(realblep.Text != null)
            Clipboard.SetText(realblep.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            realblep.Text = Clipboard.GetText();
            Unencrypt();
        }

        int a = 0;
        private void CheckEasterEgg()
        {
            if (easteregg[0] && easteregg[1] && easteregg[2] && easteregg[3] && easteregg[4] && easteregg[5])
            {
                pictureBox1.BringToFront();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            blep.BringToFront();
            realblep.BringToFront();
            for (int i = 0; i < easteregg.Length; i++)
            {
                easteregg[i] = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            easteregg[0] = true;
            CheckEasterEgg();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            easteregg[1] = true;
            CheckEasterEgg();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            easteregg[2] = true;
            CheckEasterEgg();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            easteregg[3] = true;
            CheckEasterEgg();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            easteregg[4] = true;
            CheckEasterEgg();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            easteregg[5] = true;
            CheckEasterEgg();
        }


    }
}
