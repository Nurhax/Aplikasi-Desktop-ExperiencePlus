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
            SignUpButtonDaftar = new Button();
            dummyUploadCompany = new Button();
            label2 = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            namaPT = new TextBox();
            panel8 = new Panel();
            AlamatPT = new TextBox();
            panel4 = new Panel();
            panel9 = new Panel();
            panel5 = new Panel();
            Username = new TextBox();
            panel10 = new Panel();
            panel6 = new Panel();
            Password = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(SignUpButtonDaftar);
            panel1.Controls.Add(dummyUploadCompany);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel10);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // SignUpButtonDaftar
            // 
            SignUpButtonDaftar.BackColor = Color.DarkSlateGray;
            SignUpButtonDaftar.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButtonDaftar.ForeColor = Color.White;
            SignUpButtonDaftar.Location = new Point(100, 750);
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
            dummyUploadCompany.Location = new Point(100, 643);
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
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(namaPT);
            panel7.Location = new Point(100, 169);
            panel7.Name = "panel7";
            panel7.Size = new Size(614, 102);
            panel7.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(20, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 39);
            panel3.TabIndex = 9;
            // 
            // namaPT
            // 
            namaPT.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaPT.Location = new Point(70, 21);
            namaPT.Multiline = true;
            namaPT.Name = "namaPT";
            namaPT.PlaceholderText = "Nama PT";
            namaPT.Size = new Size(526, 48);
            namaPT.TabIndex = 5;
            namaPT.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightSeaGreen;
            panel8.Controls.Add(AlamatPT);
            panel8.Controls.Add(panel4);
            panel8.Location = new Point(100, 288);
            panel8.Name = "panel8";
            panel8.Size = new Size(614, 91);
            panel8.TabIndex = 14;
            // 
            // AlamatPT
            // 
            AlamatPT.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlamatPT.Location = new Point(70, 19);
            AlamatPT.Multiline = true;
            AlamatPT.Name = "AlamatPT";
            AlamatPT.PlaceholderText = "Alamat PT";
            AlamatPT.ShortcutsEnabled = false;
            AlamatPT.Size = new Size(526, 48);
            AlamatPT.TabIndex = 6;
            AlamatPT.TextAlign = HorizontalAlignment.Center;
            AlamatPT.TextChanged += textBox2_TextChanged;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(20, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 48);
            panel4.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightSeaGreen;
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(Username);
            panel9.Location = new Point(100, 395);
            panel9.Name = "panel9";
            panel9.Size = new Size(614, 88);
            panel9.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(20, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 48);
            panel5.TabIndex = 11;
            // 
            // Username
            // 
            Username.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(70, 16);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.ShortcutsEnabled = false;
            Username.Size = new Size(526, 48);
            Username.TabIndex = 7;
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightSeaGreen;
            panel10.Controls.Add(panel6);
            panel10.Controls.Add(Password);
            panel10.Location = new Point(100, 500);
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
            // Password
            // 
            Password.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(70, 18);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.ShortcutsEnabled = false;
            Password.Size = new Size(526, 48);
            Password.TabIndex = 8;
            Password.TextAlign = HorizontalAlignment.Center;
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private TextBox AlamatPT;
        private TextBox namaPT;
        private TextBox Username;
        private TextBox Password;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel9;
        private Button dummyUploadCompany;
        private Button SignUpButtonDaftar;
        private Label label9;
    }
}