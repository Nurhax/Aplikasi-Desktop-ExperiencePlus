namespace LoginDaftar
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            listBox1 = new ListBox();
            buttonEdit = new Button();
            buttonLoad = new Button();
            label12 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            labelSyarat = new Label();
            label11 = new Label();
            labelDeskripsi = new Label();
            label8 = new Label();
            label5 = new Label();
            labelNama = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-10, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 1050);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkCyan;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(127, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(325, 214);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(481, 339);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 16;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(481, 301);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 14;
            buttonLoad.Text = "Refresh";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 48F);
            label12.Image = (Image)resources.GetObject("label12.Image");
            label12.Location = new Point(-135, 17);
            label12.Name = "label12";
            label12.Size = new Size(1009, 86);
            label12.TabIndex = 12;
            label12.Text = "                                                      ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(159, 428);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(127, 956);
            button1.Name = "button1";
            button1.Size = new Size(259, 53);
            button1.TabIndex = 2;
            button1.Text = "EDIT LOWONGAN\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(labelSyarat);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(labelDeskripsi);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(labelNama);
            panel2.Location = new Point(126, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 421);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // labelSyarat
            // 
            labelSyarat.AutoSize = true;
            labelSyarat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSyarat.ForeColor = SystemColors.ButtonFace;
            labelSyarat.Location = new Point(34, 208);
            labelSyarat.Name = "labelSyarat";
            labelSyarat.Size = new Size(29, 19);
            labelSyarat.TabIndex = 11;
            labelSyarat.Text = "     ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(34, 184);
            label11.Name = "label11";
            label11.Size = new Size(126, 24);
            label11.TabIndex = 10;
            label11.Text = "Persyaratan:";
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeskripsi.ForeColor = SystemColors.ButtonFace;
            labelDeskripsi.Location = new Point(34, 126);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(29, 19);
            labelDeskripsi.TabIndex = 9;
            labelDeskripsi.Text = "     ";
            labelDeskripsi.Click += labelDeskripsi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(34, 102);
            label8.Name = "label8";
            label8.Size = new Size(188, 24);
            label8.TabIndex = 8;
            label8.Text = "Deskripsi Pekerjaan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(34, 63);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 5;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.ForeColor = SystemColors.ButtonFace;
            labelNama.Location = new Point(34, 39);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(35, 24);
            labelNama.TabIndex = 5;
            labelNama.Text = "     ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(1783, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 64);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.BG;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Label labelDeskripsi;
        private Label label8;
        private Label label5;
        private Label labelNama;
        private Label labelSyarat;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label12;
        private Button buttonLoad;
        private Button buttonEdit;
        private ListBox listBox1;
    }
}