namespace LoginDaftar
{
    partial class EditLowongan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLowongan));
            label1 = new Label();
            textNama = new TextBox();
            label2 = new Label();
            textDeskripsi = new TextBox();
            label3 = new Label();
            textSyarat = new TextBox();
            label4 = new Label();
            textPeriode = new TextBox();
            label5 = new Label();
            buttonEdit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(-207, 55);
            label1.Name = "label1";
            label1.Size = new Size(1009, 86);
            label1.TabIndex = 0;
            label1.Text = "                                                      ";
            label1.Click += label1_Click_1;
            // 
            // textNama
            // 
            textNama.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNama.Location = new Point(237, 228);
            textNama.Margin = new Padding(3, 2, 3, 2);
            textNama.Name = "textNama";
            textNama.Size = new Size(629, 44);
            textNama.TabIndex = 1;
            textNama.TextChanged += textNama_TextChanged;
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
            // 
            // textDeskripsi
            // 
            textDeskripsi.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDeskripsi.Location = new Point(237, 495);
            textDeskripsi.Margin = new Padding(3, 2, 3, 2);
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(629, 44);
            textDeskripsi.TabIndex = 3;
            textDeskripsi.TextChanged += textDeskripsi_TextChanged;
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
            // textSyarat
            // 
            textSyarat.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSyarat.Location = new Point(237, 362);
            textSyarat.Margin = new Padding(3, 2, 3, 2);
            textSyarat.Name = "textSyarat";
            textSyarat.Size = new Size(629, 44);
            textSyarat.TabIndex = 5;
            textSyarat.TextChanged += textSyarat_TextChanged;
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
            // textPeriode
            // 
            textPeriode.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPeriode.Location = new Point(237, 621);
            textPeriode.Margin = new Padding(3, 2, 3, 2);
            textPeriode.Name = "textPeriode";
            textPeriode.Size = new Size(629, 44);
            textPeriode.TabIndex = 7;
            textPeriode.TextChanged += textPeriode_TextChanged;
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
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkSlateGray;
            buttonEdit.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonEdit.Location = new Point(269, 838);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(374, 47);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit Lowongan";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textPeriode);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textSyarat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textDeskripsi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textNama);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 1058);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // EditLowongan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Name = "EditLowongan";
            Text = "EditLowongan";
            Load += EditLowongan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textNama;
        private Label label2;
        private TextBox textDeskripsi;
        private Label label3;
        private TextBox textSyarat;
        private Label label4;
        private TextBox textPeriode;
        private Label label5;
        private Button buttonEdit;
        private Panel panel1;
    }
}