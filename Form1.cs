using Magnum.FileSystem;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {


        [DllImport("kernel32.dll")]
        public static extern int OpenFile(FileName Imyafaila, IntPtr ReOpenBuff, uint uStyle);
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
        [DllImport("user32.dll", SetLastError = true)]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);
        [DllImport("Gdi32.dll", EntryPoint = "CreateEllipticRgn")]
        private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
        [DllImport("gdi32.dll", EntryPoint = "CreatePolygonRgn")]
        static extern IntPtr CreatePolygonRgn(Point[] poly, int cPoints, int fnPolyFillMode);
        [DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
        static extern IntPtr CombineRgn(IntPtr hrgnDst, IntPtr hrgnSrc1, IntPtr hrgnSrc2, int iMode);
        [DllImport("gdi32", EntryPoint = "FillRgn")]
        public static extern int FillRgn(IntPtr hDC, IntPtr hRgn, int hBrush);


        private const char VoidChar = '\0';
        public const string str = "1234567890ABCDEF", str2 = "01234567", str3 = "012", str4 = "01";
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;
        public int r;
        public Point[] p = new Point[7];
        protected Process[] procs;
        public string stroka;


        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        public int GetR()
        {
            return this.Height > this.Width ? this.Width / 2 : this.Height / 2;
        }

        public void Draw()
        {
            r = GetR();

            IntPtr hRgn = CreateRoundRectRgn(0, 0, Width, Height, 100, 100);
            IntPtr qwe = CreateEllipticRgn(291, 100, 491, 300);
            CombineRgn(hRgn, hRgn, qwe, 3);
            qwe = CreateRoundRectRgn(330, 145, 350, 255, 0, 0); // вертикальная
            CombineRgn(hRgn, hRgn, qwe, 2);

            /* qwe = CreateRoundRectRgn(365, 190, 385, 210, 0, 0); // 1
             CombineRgn(hRgn, hRgn, qwe, 2);

             qwe = CreateRoundRectRgn(380, 205, 400, 225, 0, 0); // 2 вниз
             CombineRgn(hRgn, hRgn, qwe, 2);

             qwe = CreateRoundRectRgn(395, 220, 415, 240, 0, 0); // 3 вниз
             CombineRgn(hRgn, hRgn, qwe, 2);

             qwe = CreateRoundRectRgn(410, 235, 430, 255, 0, 0); // 4 вниз
             CombineRgn(hRgn, hRgn, qwe, 2); */

            qwe = CreateRoundRectRgn(380, 175, 400, 195, 0, 0); // 2 вверх
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(395, 160, 415, 180, 0, 0); // 3 вверх
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(410, 145, 430, 165, 0, 0); // 4 вверх
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(365, 160, 385, 180, 0, 0); // 3 вверх
            CombineRgn(hRgn, hRgn, qwe, 2);

            qwe = CreateRoundRectRgn(350, 145, 370, 165, 0, 0); // 4 вверх
            CombineRgn(hRgn, hRgn, qwe, 2);


            qwe = CreateRoundRectRgn(430, 145, 450, 255, 0, 0); // вертикальная
            CombineRgn(hRgn, hRgn, qwe, 2);





            SetWindowRgn(this.Handle, hRgn, true);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbInt.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tbInt.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tbInt.Text = "";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

            SetWindowLong(Handle, GWL_EXSTYLE, WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            //Серийный номер диска
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = @"/c wmic diskdrive get serialnumber ";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            stroka = p.StandardOutput.ReadToEnd();
            //MessageBox.Show(stroka);
            string[] words = stroka.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            stroka = words[1];

            SetLayeredWindowAttributes(this.Handle, 0, 255, LWA_ALPHA);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            procs = Process.GetProcessesByName("Laba4");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {





            //Время

            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";  //9.5.8

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            this.Text = "Серийный номер диска: " + stroka + "   Текущее время:" + time;
        }

        private void вывестиСписокФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 forma = new Form3();
            forma.Show();
        }

        private void очиститьФайлСВыводомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@"C:\SomeDir3\results.txt");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbInt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kk = "0";
            if (radioButton1.Checked)
            {
                kk = "1";
            }
            else if (radioButton2.Checked)
            {
                kk = "2";

            }
            else if (radioButton3.Checked)
            {
                kk = "3";
            }
            else if (radioButton4.Checked)
            {
                kk = "4";
            }
            if (tbInt.Text != "")
            {
                string path = @"D:\SomeDir3";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.Create))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(kk);
                    // асинхронная запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                    array = System.Text.Encoding.Default.GetBytes(tbInt.Text);
                    fstream.Write(array, 0, array.Length);

                }
                ProcessStartInfo proc;

                if (checkBox1.Checked != true)
                    proc = new ProcessStartInfo()
                    {
                        FileName = @"D:\Users\vampi\source\repos\Laba4\bin\Debug\Laba4.exe",
                        WindowStyle = ProcessWindowStyle.Hidden

                    };
                else
                    proc = new ProcessStartInfo()
                    {
                        FileName = @"D:\Users\vampi\source\repos\Laba4\bin\Debug\Laba4.exe",
                        WindowStyle = ProcessWindowStyle.Normal,
                        Arguments = "-NoWindow"
                    };
                Process.Start(proc).WaitForExit();

                using (FileStream fstream = new FileStream($@"{path}\result.txt", FileMode.OpenOrCreate))
                {
                    byte[] output = new byte[fstream.Length];
                    fstream.Read(output, 0, output.Length);
                    string result = Encoding.Default.GetString(output);
                    textBox1.Text = result;
                    textBox1.Visible = true;
                    string CalcSys = "";
                    using (FileStream fstream1 = new FileStream($@"{path}\results.txt", FileMode.Append))
                    {
                        switch (kk)
                        {
                            case "1":
                                CalcSys = "16";
                                break;
                            case "2":
                                CalcSys = "8";
                                break;
                            case "3":
                                CalcSys = "3";
                                break;
                            case "4":
                                CalcSys = "2";
                                break;
                        }



                        output = System.Text.Encoding.Default.GetBytes($"Результат перевода {tbInt.Text} из {CalcSys}-ой системы счисления= {result}\n");
                        fstream1.Write(output, 0, output.Length);
                        fstream1.Flush();


                    }
                }
            }
            else
                MessageBox.Show("Введите что-нибудь!!!1!11!!!!1!");




        }

        private void tbInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!(str.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else if (radioButton2.Checked)
            {
                if (!(str2.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else if (radioButton3.Checked)
            {
                if (!(str3.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else
            {
                if (!(str4.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
        }



    }
}
