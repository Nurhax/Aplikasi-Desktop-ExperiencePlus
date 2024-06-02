namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            DummyLogin = new Panel();
            label8 = new Label();
            ClickHere = new Label();
            label6 = new Label();
            SignUpButton = new Label();
            label4 = new Label();
            passwordLogin = new TextBox();
            usernameLogin = new TextBox();
            LoginButtonLogin = new Button();
            CompanyDummy = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, -2);
            label1.Name = "label1";
            label1.Size = new Size(401, 61);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(DummyLogin);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ClickHere);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(passwordLogin);
            panel1.Controls.Add(usernameLogin);
            panel1.Controls.Add(LoginButtonLogin);
            panel1.Controls.Add(CompanyDummy);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(56, 120);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(611, 853);
            panel1.TabIndex = 1;
            // 
            // DummyLogin
            // 
            DummyLogin.BackgroundImage = (Image)resources.GetObject("DummyLogin.BackgroundImage");
            DummyLogin.Location = new Point(67, 714);
            DummyLogin.Name = "DummyLogin";
            DummyLogin.Size = new Size(474, 95);
            DummyLogin.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(274, 662);
            label8.Name = "label8";
            label8.Size = new Size(55, 31);
            label8.TabIndex = 10;
            label8.Text = "OR";
            // 
            // ClickHere
            // 
            ClickHere.AutoSize = true;
            ClickHere.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickHere.ForeColor = Color.SpringGreen;
            ClickHere.Location = new Point(377, 617);
            ClickHere.Name = "ClickHere";
            ClickHere.Size = new Size(150, 31);
            ClickHere.TabIndex = 9;
            ClickHere.Text = "Click Here!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(144, 617);
            label6.Name = "label6";
            label6.Size = new Size(227, 31);
            label6.TabIndex = 8;
            label6.Text = "Forgot Password?";
            // 
            // SignUpButton
            // 
            SignUpButton.AutoSize = true;
            SignUpButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.SpringGreen;
            SignUpButton.Location = new Point(377, 572);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(180, 31);
            SignUpButton.TabIndex = 7;
            SignUpButton.Text = "Sign Up Here!";
            SignUpButton.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 572);
            label4.Name = "label4";
            label4.Size = new Size(304, 31);
            label4.TabIndex = 6;
            label4.Text = "Don't Have An Account?";
            // 
            // passwordLogin
            // 
            passwordLogin.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLogin.Location = new Point(39, 392);
            passwordLogin.Multiline = true;
            passwordLogin.Name = "passwordLogin";
            passwordLogin.PlaceholderText = "Password";
            passwordLogin.Size = new Size(526, 48);
            passwordLogin.TabIndex = 5;
            passwordLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameLogin
            // 
            usernameLogin.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLogin.Location = new Point(39, 301);
            usernameLogin.Multiline = true;
            usernameLogin.Name = "usernameLogin";
            usernameLogin.PlaceholderText = "Username";
            usernameLogin.Size = new Size(526, 48);
            usernameLogin.TabIndex = 4;
            usernameLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginButtonLogin
            // 
            LoginButtonLogin.BackColor = Color.DarkSlateGray;
            LoginButtonLogin.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButtonLogin.ForeColor = Color.White;
            LoginButtonLogin.Location = new Point(39, 468);
            LoginButtonLogin.Name = "LoginButtonLogin";
            LoginButtonLogin.Size = new Size(526, 87);
            LoginButtonLogin.TabIndex = 3;
            LoginButtonLogin.Text = "Login";
            LoginButtonLogin.UseVisualStyleBackColor = false;
            LoginButtonLogin.Click += LoginButtonLogin_Click;
            // 
            // CompanyDummy
            // 
            CompanyDummy.BackColor = Color.DarkSlateGray;
            CompanyDummy.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyDummy.ForeColor = Color.White;
            CompanyDummy.Location = new Point(39, 184);
            CompanyDummy.Name = "CompanyDummy";
            CompanyDummy.Size = new Size(526, 87);
            CompanyDummy.TabIndex = 2;
            CompanyDummy.Text = "Company";
            CompanyDummy.UseVisualStyleBackColor = false;
            CompanyDummy.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(544, 96);
            label2.TabIndex = 1;
            label2.Text = "Experience++";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.ForeColor = Color.IndianRed;
            panel2.Location = new Point(1050, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 47);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(830, 483);
            label3.Name = "label3";
            label3.Size = new Size(544, 96);
            label3.TabIndex = 3;
            label3.Text = "Experience++";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1094, 406);
            label9.Name = "label9";
            label9.Size = new Size(125, 86);
            label9.TabIndex = 4;
            label9.Text = "++";
            label9.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button CompanyDummy;
        private Label label3;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
        private Button LoginButtonLogin;
        private Label label4;
        private Label label6;
        private Label SignUpButton;
        private Label ClickHere;
        private Label label8;
        private Panel DummyLogin;
        private Label label9;
    }
}
