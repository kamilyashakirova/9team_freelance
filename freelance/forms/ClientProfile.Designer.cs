namespace freelance.forms
{
    partial class ClientProfile  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientProfile));
            panel1 = new Panel();
            cemail_txt = new TextBox();
            label4 = new Label();
            id_txt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cpatronymic_txt = new TextBox();
            csurname_txt = new TextBox();
            cname_txt = new TextBox();
            fotodownload_btn = new Button();
            clientpicture = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientpicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cemail_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(id_txt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cpatronymic_txt);
            panel1.Controls.Add(csurname_txt);
            panel1.Controls.Add(cname_txt);
            panel1.Controls.Add(fotodownload_btn);
            panel1.Controls.Add(clientpicture);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 711);
            panel1.TabIndex = 0;
            // 
            // cemail_txt
            // 
            cemail_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cemail_txt.Location = new Point(28, 614);
            cemail_txt.Name = "cemail_txt";
            cemail_txt.Size = new Size(323, 30);
            cemail_txt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Didact Gothic", 10.1999989F);
            label4.Location = new Point(31, 586);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 9;
            label4.Text = "E-mail";
            // 
            // id_txt
            // 
            id_txt.Font = new Font("Didact Gothic", 10.1999989F);
            id_txt.Location = new Point(28, 676);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(323, 30);
            id_txt.TabIndex = 8;
            id_txt.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Didact Gothic", 10.1999989F);
            label3.Location = new Point(31, 425);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 7;
            label3.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Didact Gothic", 10.1999989F);
            label2.Location = new Point(31, 508);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 6;
            label2.Text = "Отчество";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Didact Gothic", 10.1999989F);
            label1.Location = new Point(31, 348);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Фамилия";
            // 
            // cpatronymic_txt
            // 
            cpatronymic_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cpatronymic_txt.Location = new Point(28, 536);
            cpatronymic_txt.Name = "cpatronymic_txt";
            cpatronymic_txt.Size = new Size(323, 30);
            cpatronymic_txt.TabIndex = 4;
            // 
            // csurname_txt
            // 
            csurname_txt.Font = new Font("Didact Gothic", 10.1999989F);
            csurname_txt.Location = new Point(28, 453);
            csurname_txt.Name = "csurname_txt";
            csurname_txt.Size = new Size(323, 30);
            csurname_txt.TabIndex = 3;
            // 
            // cname_txt
            // 
            cname_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cname_txt.Location = new Point(28, 373);
            cname_txt.Name = "cname_txt";
            cname_txt.Size = new Size(323, 30);
            cname_txt.TabIndex = 2;
            // 
            // fotodownload_btn
            // 
            fotodownload_btn.Font = new Font("Didact Gothic", 10.1999989F);
            fotodownload_btn.Location = new Point(84, 300);
            fotodownload_btn.Name = "fotodownload_btn";
            fotodownload_btn.Size = new Size(211, 39);
            fotodownload_btn.TabIndex = 1;
            fotodownload_btn.Text = "Загрузить фотографию";
            fotodownload_btn.UseVisualStyleBackColor = true;
            fotodownload_btn.Click += fotodownload_btn_Click;
            // 
            // clientpicture
            // 
            clientpicture.BorderStyle = BorderStyle.FixedSingle;
            clientpicture.Location = new Point(67, 11);
            clientpicture.Name = "clientpicture";
            clientpicture.Size = new Size(246, 283);
            clientpicture.SizeMode = PictureBoxSizeMode.Zoom;
            clientpicture.TabIndex = 0;
            clientpicture.TabStop = false;
            clientpicture.Click += clientpicture_Click;
            // 
            // ClientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 711);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientProfile";
            Text = "Профиль";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientpicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button fotodownload_btn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        public PictureBox clientpicture;
        public TextBox cpatronymic_txt;
        public TextBox csurname_txt;
        public TextBox cname_txt;
        public TextBox id_txt;
        public TextBox cemail_txt;
    }
}