﻿namespace LoginDaftar
{
    partial class BuatLowongan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuatLowongan));
            panel1 = new Panel();
            ErrorHandlingLabel = new Label();
            ButtonBuatLowongan = new Button();
            label5 = new Label();
            textBoxPeriode = new TextBox();
            label4 = new Label();
            textBoxSyarat = new TextBox();
            label3 = new Label();
            textBoxDeskripsi = new TextBox();
            label2 = new Label();
            textBoxNama = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(ErrorHandlingLabel);
            panel1.Controls.Add(ButtonBuatLowongan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPeriode);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxSyarat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxDeskripsi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNama);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 1048);
            panel1.TabIndex = 0;
            // 
            // ErrorHandlingLabel
            // 
            ErrorHandlingLabel.AutoSize = true;
            ErrorHandlingLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorHandlingLabel.ForeColor = Color.Red;
            ErrorHandlingLabel.Location = new Point(237, 712);
            ErrorHandlingLabel.Name = "ErrorHandlingLabel";
            ErrorHandlingLabel.Size = new Size(0, 23);
            ErrorHandlingLabel.TabIndex = 10;
            ErrorHandlingLabel.Click += ErrorHandlingLabel_Click;
            // 
            // ButtonBuatLowongan
            // 
            ButtonBuatLowongan.BackColor = Color.DarkSlateGray;
            ButtonBuatLowongan.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonBuatLowongan.ForeColor = SystemColors.ButtonHighlight;
            ButtonBuatLowongan.Location = new Point(269, 838);
            ButtonBuatLowongan.Margin = new Padding(3, 2, 3, 2);
            ButtonBuatLowongan.Name = "ButtonBuatLowongan";
            ButtonBuatLowongan.Size = new Size(374, 47);
            ButtonBuatLowongan.TabIndex = 9;
            ButtonBuatLowongan.Text = "Buat Lowongan";
            ButtonBuatLowongan.UseVisualStyleBackColor = false;
            ButtonBuatLowongan.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(47, 623);
            label5.Name = "label5";
            label5.Size = new Size(120, 36);
            label5.TabIndex = 8;
            label5.Text = "Periode";
            // 
            // textBoxPeriode
            // 
            textBoxPeriode.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPeriode.Location = new Point(237, 621);
            textBoxPeriode.Margin = new Padding(3, 2, 3, 2);
            textBoxPeriode.Name = "textBoxPeriode";
            textBoxPeriode.Size = new Size(629, 44);
            textBoxPeriode.TabIndex = 7;
            textBoxPeriode.TextChanged += textBoxPeriode_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(47, 364);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 6;
            label4.Text = "Syarat";
            // 
            // textBoxSyarat
            // 
            textBoxSyarat.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSyarat.Location = new Point(237, 362);
            textBoxSyarat.Margin = new Padding(3, 2, 3, 2);
            textBoxSyarat.Name = "textBoxSyarat";
            textBoxSyarat.Size = new Size(629, 44);
            textBoxSyarat.TabIndex = 5;
            textBoxSyarat.TextChanged += textBoxSyarat_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(24, 495);
            label3.Name = "label3";
            label3.Size = new Size(143, 36);
            label3.TabIndex = 4;
            label3.Text = "Deskripsi";
            // 
            // textBoxDeskripsi
            // 
            textBoxDeskripsi.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDeskripsi.Location = new Point(237, 495);
            textBoxDeskripsi.Margin = new Padding(3, 2, 3, 2);
            textBoxDeskripsi.Name = "textBoxDeskripsi";
            textBoxDeskripsi.Size = new Size(629, 44);
            textBoxDeskripsi.TabIndex = 3;
            textBoxDeskripsi.TextChanged += textBoxDeskripsi_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(70, 230);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // textBoxNama
            // 
            textBoxNama.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNama.Location = new Point(237, 228);
            textBoxNama.Margin = new Padding(3, 2, 3, 2);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(629, 44);
            textBoxNama.TabIndex = 1;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(-124, 54);
            label1.Name = "label1";
            label1.Size = new Size(1009, 86);
            label1.TabIndex = 0;
            label1.Text = "                                                      ";
            label1.Click += label1_Click;
            // 
            // BuatLowongan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BuatLowongan";
            Text = "BuatLowongan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxNama;
        private Label label2;
        private Button ButtonBuatLowongan;
        private Label label5;
        private TextBox textBoxPeriode;
        private Label label4;
        private TextBox textBoxSyarat;
        private Label label3;
        private TextBox textBoxDeskripsi;
        private Label ErrorHandlingLabel;
    }
}