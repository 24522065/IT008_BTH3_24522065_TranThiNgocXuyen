using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValidNumber(out double n1, out double n2)
        {
            n1 = n2 = 0;

            if (string.IsNullOrWhiteSpace(num1.Text) || string.IsNullOrWhiteSpace(num2.Text))
            {
                MessageBox.Show("Không được để trống");
                return false;
            }

            if (!double.TryParse(num1.Text.Trim(), out n1) || !double.TryParse(num2.Text.Trim(), out n2))
            {
                num1.Text = num2.Text = "";
                MessageBox.Show("Giá trị nhập vào không hợp lệ, hãy nhập lại");
                return false;
            }

            return true;
        }

        private void congButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber(out double n1, out double n2))
                answer.Text = (n1 + n2).ToString();
        }

        private void truButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber(out double n1, out double n2))
                answer.Text = (n1 - n2).ToString();
        }

        private void nhanButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber(out double n1, out double n2))
                answer.Text = (n1 * n2).ToString();
        }

        private void chiaButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0");
                    return;
                }
                answer.Text = (n1 / n2).ToString();
            }
        }
    }
}
