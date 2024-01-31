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
        string filename;
        string fileextension;
        string filetext;
        string hash = "UwUbotAndreasxD";
        bool encrypted;
        bool mlep;
        private void setall(bool idk)
        {
            folderpath = "";
            filename = "";
            fileextension = "";
            string[] fp = filepath.Split('\\');
            //folderpath
            for (int i = 0; i < fp.Length - 1; i++)
            {
                folderpath += fp[i] + "\\";
            }
            string[] fp2 = fp[fp.Length - 1].Split('.');
            if (fp2[0].Contains("_encrypted"))
            {
                encrypted = true;
                filename = fp2[0].Substring(0, fp2[0].Length - 10);
            }
            else
            {
                encrypted = false;
                filename = fp2[0];
            }
            fileextension = "." + fp2[1];
            if (idk)
                filetext = File.ReadAllText(filepath);
            else filetext = blep.Text;
            blep.Text = filetext;
            Debug.WriteLine("filepath: " + filepath + "\nfolderpath: " + folderpath + "\nfilename: " + filename + "\nextension: " + fileextension);

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
            setall(true);
        }

        private void LoadFromfilebutton(object sender, EventArgs e)
        {
            if (encrypted)
            {
                Debug.WriteLine("filetext: " + filetext);
                realblep.Text = filetext;
                Unencrypt();
            }
            else
            {
                blep.Text = filetext;
                Encrypt();
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
                Debug.WriteLine("Written to:" + folderpath + filename + "_encrypted" + fileextension);
                File.WriteAllText(folderpath + filename + "_encrypted" + fileextension, realblep.Text);
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
                File.WriteAllText(folderpath + filename + fileextension, blep.Text);
                Debug.WriteLine("Written to:" + folderpath + filename + fileextension);
            }
        }

        private void blep_TextChanged(object sender, EventArgs e)
        {
            
            if (mlep)
                Encrypt();
        }

        private void realblep_TextChanged(object sender, EventArgs e)
        {
            
            if (!mlep)
                Unencrypt();
        }

        private void realblep_Enter(object sender, EventArgs e)
        {
            mlep = false;
        }

        private void blep_Enter(object sender, EventArgs e)
        {
            mlep = true;
        }
    }
}
