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

        public List<int> GetFiboList(int n)
        {
            List<int> numbers = new List<int>(n);

            numbers.Add(1);
            numbers.Add(1);
            for (int i = 2; i < n; i++)
            {
                numbers.Add(numbers[i - 2] + numbers[i - 1]);
            }

            return numbers;
        }

        public Label GetLabelNumber(string numberText, int numberNo)
        {
            Label lblNumber = new Label();

            lblNumber.Text = numberText;

            int colorNumber = numberNo % colors.Count;
            lblNumber.ForeColor = colors[colorNumber];

            lblNumber.Location = new Point(200, 200 + numberNo * 10);

            return lblNumber;
        }
    }
}
