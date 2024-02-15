namespace SimpleEncryptionV2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.blep = new System.Windows.Forms.RichTextBox();
            this.realblep = new System.Windows.Forms.RichTextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textbox_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureB1 = new System.Windows.Forms.PictureBox();
            this.pictureB4 = new System.Windows.Forms.PictureBox();
            this.pictureB3 = new System.Windows.Forms.PictureBox();
            this.pictureB2 = new System.Windows.Forms.PictureBox();
            this.pictureB6 = new System.Windows.Forms.PictureBox();
            this.pictureB5 = new System.Windows.Forms.PictureBox();
            this.pictureB7 = new System.Windows.Forms.PictureBox();
            this.pictureB8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(-1, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "... ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_ofd);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadFromFile.Location = new System.Drawing.Point(1, 70);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(111, 37);
            this.btnLoadFromFile.TabIndex = 3;
            this.btnLoadFromFile.Text = "Load text from File";
            this.btnLoadFromFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.LoadFromfilebutton);
            // 
            // blep
            // 
            this.blep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blep.BackColor = System.Drawing.Color.Navy;
            this.blep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blep.ForeColor = System.Drawing.SystemColors.Window;
            this.blep.Location = new System.Drawing.Point(0, 102);
            this.blep.Name = "blep";
            this.blep.Size = new System.Drawing.Size(501, 600);
            this.blep.TabIndex = 5;
            this.blep.Text = "Text Here";
            this.blep.TextChanged += new System.EventHandler(this.blep_TextChanged);
            this.blep.Enter += new System.EventHandler(this.blep_Enter);
            // 
            // realblep
            // 
            this.realblep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.realblep.BackColor = System.Drawing.Color.Navy;
            this.realblep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realblep.ForeColor = System.Drawing.SystemColors.Window;
            this.realblep.Location = new System.Drawing.Point(507, 102);
            this.realblep.Name = "realblep";
            this.realblep.Size = new System.Drawing.Size(500, 600);
            this.realblep.TabIndex = 6;
            this.realblep.Text = "Text Here";
            this.realblep.TextChanged += new System.EventHandler(this.realblep_TextChanged);
            this.realblep.Enter += new System.EventHandler(this.realblep_Enter);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExport.Location = new System.Drawing.Point(507, 71);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 37);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export encrypted";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExportEncrypted_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(118, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Export unencrypted";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnExportUnencrypted);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(580, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(653, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "V";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textbox_key
            // 
            this.textbox_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_key.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox_key.Location = new System.Drawing.Point(270, -1);
            this.textbox_key.Name = "textbox_key";
            this.textbox_key.PasswordChar = '-';
            this.textbox_key.Size = new System.Drawing.Size(242, 26);
            this.textbox_key.TabIndex = 23;
            this.textbox_key.Text = "key";
            this.textbox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_key.TextChanged += new System.EventHandler(this.textbox_key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(273, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "KEY";
            // 
            // pictureB1
            // 
            this.pictureB1.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB1.Location = new System.Drawing.Point(-1, 25);
            this.pictureB1.Name = "pictureB1";
            this.pictureB1.Size = new System.Drawing.Size(186, 48);
            this.pictureB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB1.TabIndex = 31;
            this.pictureB1.TabStop = false;
            this.pictureB1.Click += new System.EventHandler(this.PictureB1);
            // 
            // pictureB4
            // 
            this.pictureB4.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB4.Location = new System.Drawing.Point(507, -1);
            this.pictureB4.Name = "pictureB4";
            this.pictureB4.Size = new System.Drawing.Size(77, 76);
            this.pictureB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB4.TabIndex = 32;
            this.pictureB4.TabStop = false;
            this.pictureB4.Click += new System.EventHandler(this.PictureB4);
            // 
            // pictureB3
            // 
            this.pictureB3.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB3.Location = new System.Drawing.Point(360, 31);
            this.pictureB3.Name = "pictureB3";
            this.pictureB3.Size = new System.Drawing.Size(152, 71);
            this.pictureB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB3.TabIndex = 33;
            this.pictureB3.TabStop = false;
            this.pictureB3.Click += new System.EventHandler(this.PictureB3);
            // 
            // pictureB2
            // 
            this.pictureB2.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB2.Location = new System.Drawing.Point(191, 10);
            this.pictureB2.Name = "pictureB2";
            this.pictureB2.Size = new System.Drawing.Size(174, 92);
            this.pictureB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB2.TabIndex = 34;
            this.pictureB2.TabStop = false;
            this.pictureB2.Click += new System.EventHandler(this.PictureB2);
            // 
            // pictureB6
            // 
            this.pictureB6.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB6.Location = new System.Drawing.Point(653, 44);
            this.pictureB6.Name = "pictureB6";
            this.pictureB6.Size = new System.Drawing.Size(58, 29);
            this.pictureB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB6.TabIndex = 35;
            this.pictureB6.TabStop = false;
            this.pictureB6.Click += new System.EventHandler(this.PictureB6);
            // 
            // pictureB5
            // 
            this.pictureB5.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB5.Location = new System.Drawing.Point(580, -284);
            this.pictureB5.Name = "pictureB5";
            this.pictureB5.Size = new System.Drawing.Size(67, 359);
            this.pictureB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB5.TabIndex = 36;
            this.pictureB5.TabStop = false;
            this.pictureB5.Click += new System.EventHandler(this.PictureB5);
            // 
            // pictureB7
            // 
            this.pictureB7.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB7.Location = new System.Drawing.Point(717, 12);
            this.pictureB7.Name = "pictureB7";
            this.pictureB7.Size = new System.Drawing.Size(119, 91);
            this.pictureB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB7.TabIndex = 37;
            this.pictureB7.TabStop = false;
            this.pictureB7.Click += new System.EventHandler(this.PictureB7);
            // 
            // pictureB8
            // 
            this.pictureB8.Image = global::SimpleEncryptionV2.Properties.Resources.banana_happy;
            this.pictureB8.Location = new System.Drawing.Point(842, 7);
            this.pictureB8.Name = "pictureB8";
            this.pictureB8.Size = new System.Drawing.Size(165, 95);
            this.pictureB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB8.TabIndex = 38;
            this.pictureB8.TabStop = false;
            this.pictureB8.Click += new System.EventHandler(this.PictureB8);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1007, 702);
            this.Controls.Add(this.pictureB8);
            this.Controls.Add(this.pictureB7);
            this.Controls.Add(this.pictureB5);
            this.Controls.Add(this.pictureB6);
            this.Controls.Add(this.pictureB3);
            this.Controls.Add(this.pictureB4);
            this.Controls.Add(this.pictureB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_key);
            this.Controls.Add(this.realblep);
            this.Controls.Add(this.blep);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureB2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Banana Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.RichTextBox blep;
        private System.Windows.Forms.RichTextBox realblep;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textbox_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureB1;
        private System.Windows.Forms.PictureBox pictureB4;
        private System.Windows.Forms.PictureBox pictureB3;
        private System.Windows.Forms.PictureBox pictureB2;
        private System.Windows.Forms.PictureBox pictureB6;
        private System.Windows.Forms.PictureBox pictureB5;
        private System.Windows.Forms.PictureBox pictureB7;
        private System.Windows.Forms.PictureBox pictureB8;
    }
}

