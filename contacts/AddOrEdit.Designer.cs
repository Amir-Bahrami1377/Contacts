namespace contacts
{
    partial class AddOrEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAge = new NumericUpDown();
            label3 = new Label();
            txtMobile = new TextBox();
            label4 = new Label();
            txtFamily = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFamily);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فرد";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(6, 160);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(415, 76);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 168);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 10;
            label6.Text = "آدرس:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(415, 26);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 8;
            label5.Text = "ایمیل:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(19, 76);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 26);
            txtAge.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 81);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 6;
            label3.Text = "سن:";
            label3.Click += label3_Click;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(220, 73);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(201, 26);
            txtMobile.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 76);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 4;
            label4.Text = "موبایل:";
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(6, 20);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(163, 26);
            txtFamily.TabIndex = 3;
            txtFamily.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 28);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی:";
            // 
            // txtName
            // 
            txtName.Location = new Point(274, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 26);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 18);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(345, 264);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddOrEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 301);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOrEdit";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Load += AddOrEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFamily;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtMobile;
        private Label label4;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private NumericUpDown txtAge;
        private Button btnSubmit;
    }
}