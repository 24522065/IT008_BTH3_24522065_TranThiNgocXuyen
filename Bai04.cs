using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatMenu_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColor = new ColorDialog();
            if (chooseColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = chooseColor.Color;
            }
        }
    }
}

