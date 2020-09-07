using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFibonacci {
    public partial class FormFibonacci : Form {

        /// <summary>
        /// لیستس از رنگ های به کار رفته در نمایش اعداد که با استفاده از تابع رندوم یکی از این رنگ ها انتخاب میشود
        /// </summary>
        private static readonly List<Color> colors = new List<Color>
        {
            Color.Red, Color.Black, Color.Blue, Color.Purple, Color.Pink, Color.Green,
            Color.Gray, Color.Yellow, Color.Orange, Color.Khaki, Color.Aqua, Color.Brown,
            Color.Transparent, Color.Magenta
        };

        public FormFibonacci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// لیستی از دنباله اعداد فیبوناچی تولید میکند به تعداد عدد ورودی
        /// </summary>
        /// <param name="n">تعداد اعداد دنباله فیبوناچی</param>
        /// <returns>لیستی یا به عبارتی دنباله ای از اعداد فیبوناچی به ترتیب کوچک به بزرگ</returns>
        private List<int> GetFiboList(int n)
        {
            List<int> numbers = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                numbers.Add(Fibonacci(i));
            }

            return numbers;
        }

        /// <summary>
        /// تابع بازگشتی فیبوناچی
        /// </summary>
        /// <param name="n">عدد nام دنباله فیبوناچی</param>
        /// <returns></returns>
        private int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// یک کامپوننت برمیگرداند که اعداد دنباله فیبوناچی را به ترتیب نمایش میدهد
        /// </summary>
        /// <param name="numberText">متنی که نمایش داده میشود. یا درواقع همان عدد فیبوناچی</param>
        /// <param name="numberNo">شماره ترتیب عدد در دنباله فیبوناچی</param>
        /// <returns>لیستی از اعداد که دنباله فیبوناچی را تشکیل م می دهند به ترتیب سعودی</returns>
        private Label GetLabelNumber(string numberText, int numberNo)
        {
            Label lblNumber = new Label();

            lblNumber.Text = numberText;

            int colorNumber = numberNo % colors.Count;
            lblNumber.ForeColor = colors[colorNumber];

            lblNumber.Location = new Point(120, 30 + numberNo * 20);

            lblNumber.AutoSize = true;
            lblNumber.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (lblNumber.Location.Y > gBoxFiboNumbers.Height)
            {
                gBoxFiboNumbers.Height += 20;
                this.Height += 20;
            }
            else
            {
                gBoxFiboNumbers.Height = 411;
                this.Height = 474;
            }

            return lblNumber;
        }

        /// <summary>
        /// رویداد کلیلک بر روی دکمه نمایش
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShow_Click(object sender, EventArgs e)
        {
            gBoxFiboNumbers.Controls.Clear();

            int n = (int)txtInput.Value;

            List<int> numbers = GetFiboList(n);

            for (int i = 0; i < numbers.Count; i++)
            {
                Label lblNumber = GetLabelNumber(numbers[i].ToString(), i);

                System.Threading.Thread.Sleep(1000);

                this.Update();

                Controls.Add(lblNumber);
                gBoxFiboNumbers.Controls.Add(lblNumber);
            }
        }
    }
}
