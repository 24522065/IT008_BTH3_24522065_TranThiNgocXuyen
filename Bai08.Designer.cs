namespace Bai08
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
            labelQL = new Label();
            labelSTK = new Label();
            labelTen = new Label();
            labelDiaChi = new Label();
            labelSt = new Label();
            acountID = new TextBox();
            accountMoney = new TextBox();
            customerAddress = new TextBox();
            customerName = new TextBox();
            modifyButton = new Button();
            deleteButton = new Button();
            exitButton = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            labelTongTien = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelQL
            // 
            labelQL.AutoSize = true;
            labelQL.ForeColor = Color.Blue;
            labelQL.Location = new Point(164, 9);
            labelQL.Name = "labelQL";
            labelQL.Size = new Size(280, 25);
            labelQL.TabIndex = 0;
            labelQL.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // labelSTK
            // 
            labelSTK.AutoSize = true;
            labelSTK.Location = new Point(95, 70);
            labelSTK.Name = "labelSTK";
            labelSTK.Size = new Size(111, 25);
            labelSTK.TabIndex = 1;
            labelSTK.Text = "Số tài khoản";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(72, 111);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(134, 25);
            labelTen.TabIndex = 2;
            labelTen.Text = "Tên khách hàng";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(45, 160);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(161, 25);
            labelDiaChi.TabIndex = 3;
            labelDiaChi.Text = "Địa chỉ khách hàng";
            // 
            // labelSt
            // 
            labelSt.AutoSize = true;
            labelSt.Location = new Point(12, 208);
            labelSt.Name = "labelSt";
            labelSt.Size = new Size(194, 25);
            labelSt.TabIndex = 4;
            labelSt.Text = "Số tiền trong tài khoản";
            // 
            // acountID
            // 
            acountID.Location = new Point(212, 64);
            acountID.Name = "acountID";
            acountID.Size = new Size(501, 31);
            acountID.TabIndex = 5;
            // 
            // accountMoney
            // 
            accountMoney.Location = new Point(212, 202);
            accountMoney.Name = "accountMoney";
            accountMoney.Size = new Size(501, 31);
            accountMoney.TabIndex = 6;
            // 
            // customerAddress
            // 
            customerAddress.Location = new Point(212, 154);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(501, 31);
            customerAddress.TabIndex = 7;
            // 
            // customerName
            // 
            customerName.Location = new Point(212, 108);
            customerName.Name = "customerName";
            customerName.Size = new Size(501, 31);
            customerName.TabIndex = 8;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(260, 259);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(159, 34);
            modifyButton.TabIndex = 9;
            modifyButton.Text = "Thêm/Cập nhật";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(450, 259);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(601, 259);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 11;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(12, 331);
            listView.Name = "listView";
            listView.Size = new Size(876, 146);
            listView.TabIndex = 12;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 100;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(416, 494);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(96, 25);
            labelTongTien.TabIndex = 13;
            labelTongTien.Text = "Tổng tiền: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(518, 488);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 31);
            textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 558);
            Controls.Add(textBox1);
            Controls.Add(labelTongTien);
            Controls.Add(listView);
            Controls.Add(exitButton);
            Controls.Add(deleteButton);
            Controls.Add(modifyButton);
            Controls.Add(customerName);
            Controls.Add(customerAddress);
            Controls.Add(accountMoney);
            Controls.Add(acountID);
            Controls.Add(labelSt);
            Controls.Add(labelDiaChi);
            Controls.Add(labelTen);
            Controls.Add(labelSTK);
            Controls.Add(labelQL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQL;
        private Label labelSTK;
        private Label labelTen;
        private Label labelDiaChi;
        private Label labelSt;
        private TextBox acountID;
        private TextBox accountMoney;
        private TextBox customerAddress;
        private TextBox customerName;
        private Button modifyButton;
        private Button deleteButton;
        private Button exitButton;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label labelTongTien;
        private TextBox textBox1;
    }
}
