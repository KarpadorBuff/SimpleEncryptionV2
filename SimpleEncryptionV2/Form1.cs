using System;
using System.Diagnostics;
using System.IO;
using System.Media;
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
        string hash;
        bool encrypted;
        bool textfieldbool;
        public bool[] easteregg = new bool[7];
        SoundPlayer Player = new SoundPlayer();
        private void setall()
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
        private void PlaySound(Stream stream, bool playLooping)
        {
            if (Player != null)
            {
                Player.Stop();
                Player.Dispose();
                Player = null;
            }
            if (stream == null) return;
            Player = new SoundPlayer(stream);

            if (playLooping)
            {
                Player.PlayLooping();
            }
            else
            {
                Player.Play();
            }
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
            if (textBox1.Text.Contains("_encrypted"))
                setall();
            else
                setall();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            textbox_key.Text = Properties.Settings.Default.key;
            hash = textbox_key.Text;
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
                setall();
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
            if (realblep.Text != null)
                Clipboard.SetText(realblep.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            realblep.Text = Clipboard.GetText();
            Unencrypt();
        }
        private void textbox_key_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.key = textbox_key.Text;
            Properties.Settings.Default.Save();
            Debug.WriteLine(Properties.Settings.Default.key);
            hash = Properties.Settings.Default.key;
            if (encrypted) Unencrypt();
            else Encrypt();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("eastereggLength: " + easteregg.Length);
            if (easteregg[easteregg.Length - 1])
            {
                blep.BringToFront();
                realblep.BringToFront();
                for (int i = 0; i < easteregg.Length; i++)
                {
                    PlaySound(Properties.Resources.Bell1, false);
                    easteregg[i] = false;
                }
            }
        }
        private void PictureB6(object sender, EventArgs e)
        {
            easteregg[0] = true;
            for (int i = 1; i < easteregg.Length; i++) easteregg[i] = false;
            PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
        }
        private void PictureB1(object sender, EventArgs e)
        {
            if (easteregg[0])
            {
                easteregg[1] = true;
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB3(object sender, EventArgs e)
        {
            if (easteregg[1])
            {
                easteregg[2] = true;
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB4(object sender, EventArgs e)
        {
            if (easteregg[2])
            {
                easteregg[3] = true;
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB7(object sender, EventArgs e)
        {
            if (easteregg[3])
            {
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
                easteregg[4] = true;
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB2(object sender, EventArgs e)
        {
            if (easteregg[4])
            {
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
                easteregg[5] = true;
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB8(object sender, EventArgs e)
        {
            if (easteregg[5])
            {
                PlaySound(Properties.Resources.Bell1, false); Debug.WriteLine("Sound");
                easteregg[6] = true;
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
        private void PictureB5(object sender, EventArgs e)
        {
            if (easteregg[6])
            {
                PlaySound(Properties.Resources.Bell1, true); Debug.WriteLine("Sound");
                pictureBox1.BringToFront();
            }
            else for (int i = 0; i < easteregg.Length; i++) easteregg[i] = false;
        }
    }
}
