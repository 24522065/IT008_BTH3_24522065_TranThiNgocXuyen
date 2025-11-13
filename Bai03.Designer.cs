namespace Bai03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnChangeColor = new Button();
            SuspendLayout();
            // 
            // bttnChangeColor
            // 
            bttnChangeColor.Location = new Point(230, 166);
            bttnChangeColor.Name = "bttnChangeColor";
            bttnChangeColor.Size = new Size(187, 34);
            bttnChangeColor.TabIndex = 0;
            bttnChangeColor.Text = "Change Color";
            bttnChangeColor.UseVisualStyleBackColor = true;
            bttnChangeColor.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnChangeColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bttnChangeColor;
    }
}
