namespace Lab_10_LCD_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_bmp = new System.Windows.Forms.PictureBox();
            this.btn_Open_bmp_encrypt = new System.Windows.Forms.Button();
            this.btn_Open_bmp_decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Open_txt_encrypt = new System.Windows.Forms.Button();
            this.textBox_fileName_encrypt = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_Encrypt);
            this.panel1.Controls.Add(this.textBox_fileName_encrypt);
            this.panel1.Controls.Add(this.btn_Open_txt_encrypt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Open_bmp_encrypt);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 138);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_bmp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 291);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_Decrypt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Open_bmp_decrypt);
            this.panel2.Location = new System.Drawing.Point(2, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 147);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox_bmp
            // 
            this.pictureBox_bmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_bmp.InitialImage = null;
            this.pictureBox_bmp.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_bmp.Name = "pictureBox_bmp";
            this.pictureBox_bmp.Size = new System.Drawing.Size(304, 288);
            this.pictureBox_bmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bmp.TabIndex = 0;
            this.pictureBox_bmp.TabStop = false;
            // 
            // btn_Open_bmp_encrypt
            // 
            this.btn_Open_bmp_encrypt.Location = new System.Drawing.Point(53, 27);
            this.btn_Open_bmp_encrypt.Name = "btn_Open_bmp_encrypt";
            this.btn_Open_bmp_encrypt.Size = new System.Drawing.Size(156, 23);
            this.btn_Open_bmp_encrypt.TabIndex = 0;
            this.btn_Open_bmp_encrypt.Text = "Загрузить контейнет .bmp";
            this.btn_Open_bmp_encrypt.UseVisualStyleBackColor = true;
            this.btn_Open_bmp_encrypt.Click += new System.EventHandler(this.btn_Open_bmp_encrypt_Click);
            // 
            // btn_Open_bmp_decrypt
            // 
            this.btn_Open_bmp_decrypt.Location = new System.Drawing.Point(53, 38);
            this.btn_Open_bmp_decrypt.Name = "btn_Open_bmp_decrypt";
            this.btn_Open_bmp_decrypt.Size = new System.Drawing.Size(156, 23);
            this.btn_Open_bmp_decrypt.TabIndex = 0;
            this.btn_Open_bmp_decrypt.Text = "Загрузить контейнет .bmp";
            this.btn_Open_bmp_decrypt.UseVisualStyleBackColor = true;
            this.btn_Open_bmp_decrypt.Click += new System.EventHandler(this.btn_Open_bmp_decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шифрование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расшифрование";
            // 
            // btn_Open_txt_encrypt
            // 
            this.btn_Open_txt_encrypt.Enabled = false;
            this.btn_Open_txt_encrypt.Location = new System.Drawing.Point(10, 59);
            this.btn_Open_txt_encrypt.Name = "btn_Open_txt_encrypt";
            this.btn_Open_txt_encrypt.Size = new System.Drawing.Size(119, 21);
            this.btn_Open_txt_encrypt.TabIndex = 2;
            this.btn_Open_txt_encrypt.Text = "Открыть txt файл";
            this.btn_Open_txt_encrypt.UseVisualStyleBackColor = true;
            this.btn_Open_txt_encrypt.Click += new System.EventHandler(this.btn_Open_txt_encrypt_Click);
            // 
            // textBox_fileName_encrypt
            // 
            this.textBox_fileName_encrypt.Enabled = false;
            this.textBox_fileName_encrypt.Location = new System.Drawing.Point(147, 60);
            this.textBox_fileName_encrypt.Name = "textBox_fileName_encrypt";
            this.textBox_fileName_encrypt.Size = new System.Drawing.Size(104, 20);
            this.textBox_fileName_encrypt.TabIndex = 3;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.BackColor = System.Drawing.Color.Tomato;
            this.btn_Encrypt.Enabled = false;
            this.btn_Encrypt.Location = new System.Drawing.Point(71, 97);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(107, 28);
            this.btn_Encrypt.TabIndex = 4;
            this.btn_Encrypt.Text = "Зашифровать";
            this.btn_Encrypt.UseVisualStyleBackColor = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Decrypt.Enabled = false;
            this.btn_Decrypt.Location = new System.Drawing.Point(22, 76);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(107, 28);
            this.btn_Decrypt.TabIndex = 4;
            this.btn_Decrypt.Text = "Расшифровать";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 291);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_10_LCD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_bmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Open_bmp_encrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Open_bmp_decrypt;
        private System.Windows.Forms.TextBox textBox_fileName_encrypt;
        private System.Windows.Forms.Button btn_Open_txt_encrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

