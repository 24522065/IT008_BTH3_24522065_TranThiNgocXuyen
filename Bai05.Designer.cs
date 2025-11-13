namespace Bai05
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
            num1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            num2 = new TextBox();
            buttonCong = new Button();
            buttonTru = new Button();
            buttonNhan = new Button();
            buttonChia = new Button();
            answer = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(209, 72);
            num1.Name = "num1";
            num1.Size = new Size(303, 31);
            num1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 78);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 140);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // num2
            // 
            num2.Location = new Point(209, 134);
            num2.Name = "num2";
            num2.Size = new Size(303, 31);
            num2.TabIndex = 3;
            // 
            // buttonCong
            // 
            buttonCong.Location = new Point(145, 243);
            buttonCong.Name = "buttonCong";
            buttonCong.Size = new Size(61, 34);
            buttonCong.TabIndex = 4;
            buttonCong.Text = "+";
            buttonCong.UseVisualStyleBackColor = true;
            buttonCong.Click += congButton_Click;
            // 
            // buttonTru
            // 
            buttonTru.Location = new Point(249, 243);
            buttonTru.Name = "buttonTru";
            buttonTru.Size = new Size(62, 34);
            buttonTru.TabIndex = 5;
            buttonTru.Text = "-";
            buttonTru.UseVisualStyleBackColor = true;
            buttonTru.Click += truButton_Click;
            // 
            // buttonNhan
            // 
            buttonNhan.Location = new Point(348, 243);
            buttonNhan.Name = "buttonNhan";
            buttonNhan.Size = new Size(64, 34);
            buttonNhan.TabIndex = 6;
            buttonNhan.Text = "x";
            buttonNhan.UseVisualStyleBackColor = true;
            buttonNhan.Click += nhanButton_Click;
            // 
            // buttonChia
            // 
            buttonChia.Location = new Point(455, 243);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(57, 34);
            buttonChia.TabIndex = 7;
            buttonChia.Text = "/";
            buttonChia.UseVisualStyleBackColor = true;
            buttonChia.Click += chiaButton_Click;
            // 
            // answer
            // 
            answer.Location = new Point(209, 324);
            answer.Name = "answer";
            answer.ReadOnly = true;
            answer.Size = new Size(303, 31);
            answer.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 327);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 9;
            label3.Text = "Answer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(answer);
            Controls.Add(buttonChia);
            Controls.Add(buttonNhan);
            Controls.Add(buttonTru);
            Controls.Add(buttonCong);
            Controls.Add(num2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private Label label1;
        private Label label2;
        private TextBox num2;
        private Button buttonCong;
        private Button buttonTru;
        private Button buttonNhan;
        private Button buttonChia;
        private TextBox answer;
        private Label label3;
    }
}
