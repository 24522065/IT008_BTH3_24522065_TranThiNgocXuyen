using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void chooseNumber(dynamic sender, MouseEventArgs e)
        {
            if (sender.BackColor == Color.Blue)
                sender.BackColor = Color.White;
            else if (sender.BackColor == Color.White)
                sender.BackColor = Color.Blue;
            else if (sender.BackColor == Color.Yellow)
                MessageBox.Show("Vé tại vị trí này đã được bán!");
        }
        long total = 0;
        private void chooseButton_Click(object sender, EventArgs e)
        {
            foreach (Control btn in this.Controls)
                if (btn.GetType() == button1.GetType())
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;
                        if (int.Parse(btn.Text) >= 1 && int.Parse(btn.Text) <= 5)
                            total += 5000;
                        else if (int.Parse(btn.Text) >= 6 && int.Parse(btn.Text) <= 10)
                            total += 6500;
                        else total += 8000;
                    }
            payment.Text = total.ToString() + " (VND)";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            total = 0;
            payment.Text = "0 (VND)";
            foreach (Control btn in this.Controls)
                if (btn.GetType() == button1.GetType())
                    if (btn.BackColor == Color.Blue)
                        btn.BackColor = Color.White;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vé được đặt thành công, tổng số tiền phải trả là " + total + " (VND)");
            foreach (Control btn in this.Controls)
                if (btn.GetType() == button1.GetType())
                    if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Blue)
                        btn.BackColor = Color.White;
        }
    }
}
