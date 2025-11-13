namespace Bai09
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
            groupBox1 = new GroupBox();
            infoList = new DataGridView();
            MSSV = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            toLeftBox_Button = new Button();
            toRightBox_Button = new Button();
            cancelChoice_Button = new Button();
            saveInfo_Button = new Button();
            rightBox = new ListBox();
            leftBox = new ListBox();
            label2 = new Label();
            womanCheckbox = new CheckBox();
            manCheckbox = new CheckBox();
            labelGioiTinh = new Label();
            label1 = new Label();
            majorComboBox = new ComboBox();
            labelName = new Label();
            lblMSV = new Label();
            name_Box = new TextBox();
            studentID_Box = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(infoList);
            groupBox1.Controls.Add(toLeftBox_Button);
            groupBox1.Controls.Add(toRightBox_Button);
            groupBox1.Controls.Add(cancelChoice_Button);
            groupBox1.Controls.Add(saveInfo_Button);
            groupBox1.Controls.Add(rightBox);
            groupBox1.Controls.Add(leftBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(womanCheckbox);
            groupBox1.Controls.Add(manCheckbox);
            groupBox1.Controls.Add(labelGioiTinh);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(majorComboBox);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(lblMSV);
            groupBox1.Controls.Add(name_Box);
            groupBox1.Controls.Add(studentID_Box);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 720);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // infoList
            // 
            infoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoList.Columns.AddRange(new DataGridViewColumn[] { MSSV, Column1, Column2, Column3, Column4 });
            infoList.Location = new Point(46, 542);
            infoList.Name = "infoList";
            infoList.RowHeadersWidth = 62;
            infoList.Size = new Size(817, 225);
            infoList.TabIndex = 16;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "MSSV";
            MSSV.MinimumWidth = 8;
            MSSV.Name = "MSSV";
            MSSV.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Họ Tên";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Chuyên Ngành";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới Tính";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số Môn";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // toLeftBox_Button
            // 
            toLeftBox_Button.BackColor = SystemColors.ControlDark;
            toLeftBox_Button.Location = new Point(266, 404);
            toLeftBox_Button.Name = "toLeftBox_Button";
            toLeftBox_Button.Size = new Size(58, 45);
            toLeftBox_Button.TabIndex = 15;
            toLeftBox_Button.Text = "<";
            toLeftBox_Button.UseVisualStyleBackColor = false;
            toLeftBox_Button.Click += toLeftBox_Button_Click;
            // 
            // toRightBox_Button
            // 
            toRightBox_Button.BackColor = SystemColors.ControlDark;
            toRightBox_Button.Location = new Point(266, 330);
            toRightBox_Button.Name = "toRightBox_Button";
            toRightBox_Button.Size = new Size(58, 44);
            toRightBox_Button.TabIndex = 14;
            toRightBox_Button.Text = ">";
            toRightBox_Button.UseVisualStyleBackColor = false;
            toRightBox_Button.Click += toRightBox_Button_Click;
            // 
            // cancelChoice_Button
            // 
            cancelChoice_Button.BackColor = SystemColors.ControlDark;
            cancelChoice_Button.Location = new Point(331, 485);
            cancelChoice_Button.Name = "cancelChoice_Button";
            cancelChoice_Button.Size = new Size(112, 34);
            cancelChoice_Button.TabIndex = 13;
            cancelChoice_Button.Text = "Xóa Chọn";
            cancelChoice_Button.UseVisualStyleBackColor = false;
            cancelChoice_Button.Click += cancelChoice_Button_Click;
            // 
            // saveInfo_Button
            // 
            saveInfo_Button.BackColor = SystemColors.ControlDark;
            saveInfo_Button.ForeColor = SystemColors.ControlText;
            saveInfo_Button.Location = new Point(111, 481);
            saveInfo_Button.Name = "saveInfo_Button";
            saveInfo_Button.Size = new Size(164, 34);
            saveInfo_Button.TabIndex = 12;
            saveInfo_Button.Text = "Lưu Thông Tin";
            saveInfo_Button.UseVisualStyleBackColor = false;
            saveInfo_Button.Click += saveInfo_Button_Click;
            // 
            // rightBox
            // 
            rightBox.FormattingEnabled = true;
            rightBox.ItemHeight = 25;
            rightBox.Location = new Point(355, 330);
            rightBox.Name = "rightBox";
            rightBox.Size = new Size(180, 129);
            rightBox.TabIndex = 11;
            // 
            // leftBox
            // 
            leftBox.FormattingEnabled = true;
            leftBox.ItemHeight = 25;
            leftBox.Items.AddRange(new object[] { "Lập trình cơ bản", "Cấu trúc dữ liệu và giải thuật", "Nhập môn công nghệ phần mềm", "Hệ điều hành", "Cơ sở dữ liệu", "Mạng máy tính", "Trí tuệ nhân tạo", "Khoa học dữ liệu", "Phát triển ứng dụng web", "Lập trình hướng đối tượng", "Thiết kế giao diện người dùng", "An toàn thông tin", "Kiểm thử phần mềm", "Quản lý dự án phần mềm", "PTTK Hệ thống thông tin", "Cơ sở DL NC" });
            leftBox.Location = new Point(55, 330);
            leftBox.Name = "leftBox";
            leftBox.Size = new Size(180, 129);
            leftBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 279);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 9;
            label2.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // womanCheckbox
            // 
            womanCheckbox.AutoSize = true;
            womanCheckbox.Location = new Point(355, 229);
            womanCheckbox.Name = "womanCheckbox";
            womanCheckbox.Size = new Size(62, 29);
            womanCheckbox.TabIndex = 8;
            womanCheckbox.Text = "Nữ";
            womanCheckbox.UseVisualStyleBackColor = true;
            // 
            // manCheckbox
            // 
            manCheckbox.AutoSize = true;
            manCheckbox.Location = new Point(235, 229);
            manCheckbox.Name = "manCheckbox";
            manCheckbox.Size = new Size(76, 29);
            manCheckbox.TabIndex = 7;
            manCheckbox.Text = "Nam";
            manCheckbox.UseVisualStyleBackColor = true;
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(43, 230);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(81, 25);
            labelGioiTinh.TabIndex = 6;
            labelGioiTinh.Text = "Giới Tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 166);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Chuyên Ngành";
            // 
            // majorComboBox
            // 
            majorComboBox.FormattingEnabled = true;
            majorComboBox.Items.AddRange(new object[] { "Công nghệ phần mềm", "Mạng máy tính", "Khoa học dữ liệu", "Trí tuệ nhân tạo", "Hệ thống thông tin" });
            majorComboBox.Location = new Point(235, 158);
            majorComboBox.Name = "majorComboBox";
            majorComboBox.Size = new Size(182, 33);
            majorComboBox.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(38, 108);
            labelName.Name = "labelName";
            labelName.Size = new Size(67, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Họ Tên";
            // 
            // lblMSV
            // 
            lblMSV.AutoSize = true;
            lblMSV.Location = new Point(38, 58);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(115, 25);
            lblMSV.TabIndex = 2;
            lblMSV.Text = "Mã Sinh Viên";
            // 
            // name_Box
            // 
            name_Box.Location = new Point(235, 102);
            name_Box.Name = "name_Box";
            name_Box.Size = new Size(346, 31);
            name_Box.TabIndex = 1;
            // 
            // studentID_Box
            // 
            studentID_Box.Location = new Point(235, 52);
            studentID_Box.Name = "studentID_Box";
            studentID_Box.Size = new Size(210, 31);
            studentID_Box.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 720);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox name_Box;
        private TextBox studentID_Box;
        private Label label1;
        private ComboBox majorComboBox;
        private Label labelName;
        private Label lblMSV;
        private Label label2;
        private CheckBox womanCheckbox;
        private CheckBox manCheckbox;
        private Label labelGioiTinh;
        private Button cancelChoice_Button;
        private Button saveInfo_Button;
        private ListBox rightBox;
        private ListBox leftBox;
        private DataGridView infoList;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button toLeftBox_Button;
        private Button toRightBox_Button;
    }
}
