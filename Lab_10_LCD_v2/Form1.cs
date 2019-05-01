using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_10_LCD_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static char[] alfavit = new char[] { ' ','0','1','2','3','4','5','6','7','8','9', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
        Bitmap bmp;
        #region Methods EnCrypt
        /// <summary>
        /// Get Hash
        /// </summary>
        /// <param name="M_int"></param>
        /// <param name="H0"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int H(List<int> M_int, int H0, int n)
        {
            int Hi = H0;
            for (int i = 0; i < M_int.Count; i++)
            {
                int H_rez = Convert.ToInt32(Math.Pow(Hi + M_int[i], 2) % n);
                Console.WriteLine("H" + (i + 1) + "= " + H_rez);
                Hi = H_rez;
            }
            return Hi;
        }

        /// <summary>
        /// Open picture.bmp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Open_bmp_encrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofd.FileName, true);
                pictureBox_bmp.Image = bmp;
                btn_Open_txt_encrypt.Enabled = true;
            }
        }

        string encrypt_text = null;
        /// <summary>
        /// Open file.txt 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Open_txt_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = @"Desktop";
                ofd.RestoreDirectory = true;
                ofd.FileName = @"";
                ofd.Filter = "Все форматы|*.txt;";
                string m_f = null; string Path = null;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Path = ofd.FileName;
                    textBox_fileName_encrypt.Text = ofd.FileName.Remove(0, ofd.FileName.LastIndexOf('\\') + 1);
                    m_f = File.ReadAllText(Path).ToLower();
                    encrypt_text = m_f.ToLower();
                    char[] mass = m_f.ToCharArray();
                    List<int> M_int = new List<int>();
                    foreach (var item in mass)
                        M_int.Add(Array.IndexOf(alfavit, item));
                    int p = 19; int q = 17; int n = p * q; int H0 = 100;
                    int Hash_obraz = H(M_int, H0, n);
                    File.AppendAllText(Path, Hash_obraz.ToString());
                    encrypt_text += Hash_obraz.ToString();
                    btn_Encrypt.Enabled = true;
                }
            }
            catch { }
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        /// <summary>
        /// Button Encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (encrypt_text != null)
            { 
                embedText(encrypt_text, bmp).Save("EncryptPicture.bmp");
                btn_Open_txt_encrypt.Enabled = true;
                btn_Encrypt.Enabled = true;
                textBox_fileName_encrypt.Clear();
                MessageBox.Show("Шифрование прошло успешно...");
            }
            else
            {
                MessageBox.Show("Отсутствует сообщения для шифрования!", "Ошибка шифрации");
            }
        }

        /// <summary>
        /// Метод embedText in picture.bmp
        /// </summary>
        /// <param name="text"></param>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap embedText(string text, Bitmap bmp)
        {
            State state = State.Hiding;

            int charIndex = 0;
            int charValue = 0;
            long pixelElementIndex = 0;
            int zeros = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;
                    for (int n = 0; n < 3; n++)
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp;
                            }
                            if (charIndex >= text.Length)
                            {
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        R += charValue % 2;
                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;
                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;
                                        charValue /= 2;
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }
                        pixelElementIndex++;
                        if (state == State.Filling_With_Zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }
            return bmp;
        }
        #endregion

        /// <summary>
        /// Метод extractText from picture.bmp
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }
                        colorUnitIndex++;
                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = reverseBits(charValue);
                            if (charValue == 0)
                            {
                                return extractedText;
                            }
                            char c = (char)charValue;
                            extractedText += c.ToString();
                        }
                    }
                }
            }
            return extractedText;
        }
        /// <summary>
        /// reverseBits
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int reverseBits(int n)
        {
            int result = 0;
            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }



        /// <summary>
        /// Open picture.bmp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Open_bmp_decrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofd.FileName, true);
                pictureBox_bmp.Image = bmp;
                btn_Decrypt.Enabled = true;
            }
        }

        string Decrypt_text = null;
        /// <summary>
        /// Button Decrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Decrypt_text = extractText(bmp);
            btn_Decrypt.Enabled = false;
            FileStream f = new FileStream("Decrypt.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(f);
            wr.WriteLine(Decrypt_text);
            wr.Close();
            MessageBox.Show("Расшифрование прошло успешно... Проверьте ваши данные");
        }
    }
}
