namespace LoginDaftar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            warningMessage = new Label();
            SignUpButtonDaftar = new Button();
            dummyUploadCompany = new Button();
            label2 = new Label();
            panel9 = new Panel();
            panel5 = new Panel();
            textUsername = new TextBox();
            panel10 = new Panel();
            panel6 = new Panel();
            textPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(warningMessage);
            panel1.Controls.Add(SignUpButtonDaftar);
            panel1.Controls.Add(dummyUploadCompany);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel10);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // warningMessage
            // 
            warningMessage.AutoSize = true;
            warningMessage.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            warningMessage.ForeColor = Color.Red;
            warningMessage.Location = new Point(100, 499);
            warningMessage.Name = "warningMessage";
            warningMessage.Size = new Size(0, 19);
            warningMessage.TabIndex = 19;
            // 
            // SignUpButtonDaftar
            // 
            SignUpButtonDaftar.BackColor = Color.DarkSlateGray;
            SignUpButtonDaftar.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButtonDaftar.ForeColor = Color.White;
            SignUpButtonDaftar.Location = new Point(100, 704);
            SignUpButtonDaftar.Name = "SignUpButtonDaftar";
            SignUpButtonDaftar.Size = new Size(614, 78);
            SignUpButtonDaftar.TabIndex = 18;
            SignUpButtonDaftar.Text = "Sign Up";
            SignUpButtonDaftar.UseVisualStyleBackColor = false;
            SignUpButtonDaftar.Click += button2_Click;
            // 
            // dummyUploadCompany
            // 
            dummyUploadCompany.BackColor = Color.DarkSlateGray;
            dummyUploadCompany.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dummyUploadCompany.ForeColor = Color.White;
            dummyUploadCompany.Location = new Point(100, 593);
            dummyUploadCompany.Name = "dummyUploadCompany";
            dummyUploadCompany.Size = new Size(614, 78);
            dummyUploadCompany.TabIndex = 17;
            dummyUploadCompany.Text = "Upload Your Company Data";
            dummyUploadCompany.UseVisualStyleBackColor = false;
            dummyUploadCompany.Click += dummyUploadCompany_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(143, 37);
            label2.Name = "label2";
            label2.Size = new Size(544, 96);
            label2.TabIndex = 2;
            label2.Text = "Experience++";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightSeaGreen;
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(textUsername);
            panel9.Location = new Point(100, 274);
            panel9.Name = "panel9";
            panel9.Size = new Size(614, 88);
            panel9.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(20, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 32);
            panel5.TabIndex = 11;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(70, 16);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.ShortcutsEnabled = false;
            textUsername.Size = new Size(526, 48);
            textUsername.TabIndex = 7;
            textUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightSeaGreen;
            panel10.Controls.Add(panel6);
            panel10.Controls.Add(textPassword);
            panel10.Location = new Point(100, 395);
            panel10.Name = "panel10";
            panel10.Size = new Size(614, 86);
            panel10.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(20, 18);
            panel6.Name = "panel6";
            panel6.Size = new Size(44, 48);
            panel6.TabIndex = 12;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(70, 18);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.ShortcutsEnabled = false;
            textPassword.Size = new Size(526, 48);
            textPassword.TabIndex = 8;
            textPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1041, 535);
            label3.Name = "label3";
            label3.Size = new Size(762, 96);
            label3.TabIndex = 4;
            label3.Text = "Fill In Your Details!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(1259, 439);
            label1.Name = "label1";
            label1.Size = new Size(330, 96);
            label1.TabIndex = 5;
            label1.Text = "Sign Up";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.ForeColor = Color.IndianRed;
            panel2.Location = new Point(1342, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 47);
            panel2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1387, 373);
            label9.Name = "label9";
            label9.Size = new Size(125, 86);
            label9.TabIndex = 6;
            label9.Text = "++";
            label9.UseMnemonic = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Daftar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Panel panel6;
        private Panel panel5;
        private Panel panel10;
        private Panel panel9;
        private Button dummyUploadCompany;
        private Button SignUpButtonDaftar;
        private Label label9;
        private Label warningMessage;
    }
}