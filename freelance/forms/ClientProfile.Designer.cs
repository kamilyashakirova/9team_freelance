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
            vkIcon_pic = new PictureBox();
            exit_btn = new PictureBox();
            cemail_txt = new TextBox();
            email_lbl = new Label();
            id_txt = new TextBox();
            name_lbl = new Label();
            patronomyc_lbl = new Label();
            surname_lbl = new Label();
            cpatronymic_txt = new TextBox();
            csurname_txt = new TextBox();
            cname_txt = new TextBox();
            fotodownload_btn = new Button();
            clientpicture = new PictureBox();
            customize_btn = new Button();
            my_btn = new Button();
            disliked_btn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vkIcon_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(vkIcon_pic);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(cemail_txt);
            panel1.Controls.Add(email_lbl);
            panel1.Controls.Add(id_txt);
            panel1.Controls.Add(name_lbl);
            panel1.Controls.Add(patronomyc_lbl);
            panel1.Controls.Add(surname_lbl);
            panel1.Controls.Add(cpatronymic_txt);
            panel1.Controls.Add(csurname_txt);
            panel1.Controls.Add(cname_txt);
            panel1.Controls.Add(fotodownload_btn);
            panel1.Controls.Add(clientpicture);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 711);
            panel1.TabIndex = 0;
            // 
            // vkIcon_pic
            // 
            vkIcon_pic.Image = (Image)resources.GetObject("vkIcon_pic.Image");
            vkIcon_pic.Location = new Point(239, 182);
            vkIcon_pic.Name = "vkIcon_pic";
            vkIcon_pic.Size = new Size(97, 83);
            vkIcon_pic.SizeMode = PictureBoxSizeMode.Zoom;
            vkIcon_pic.TabIndex = 30;
            vkIcon_pic.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(-1, -1);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(47, 69);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 29;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // cemail_txt
            // 
            cemail_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cemail_txt.Location = new Point(13, 614);
            cemail_txt.Name = "cemail_txt";
            cemail_txt.Size = new Size(323, 30);
            cemail_txt.TabIndex = 10;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Didact Gothic", 10.1999989F);
            email_lbl.Location = new Point(16, 586);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(58, 25);
            email_lbl.TabIndex = 9;
            email_lbl.Text = "E-mail";
            // 
            // id_txt
            // 
            id_txt.Font = new Font("Didact Gothic", 10.1999989F);
            id_txt.Location = new Point(13, 676);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(323, 30);
            id_txt.TabIndex = 8;
            id_txt.Visible = false;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Didact Gothic", 10.1999989F);
            name_lbl.Location = new Point(16, 425);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(42, 25);
            name_lbl.TabIndex = 7;
            name_lbl.Text = "Имя";
            // 
            // patronomyc_lbl
            // 
            patronomyc_lbl.AutoSize = true;
            patronomyc_lbl.Font = new Font("Didact Gothic", 10.1999989F);
            patronomyc_lbl.Location = new Point(16, 508);
            patronomyc_lbl.Name = "patronomyc_lbl";
            patronomyc_lbl.Size = new Size(83, 25);
            patronomyc_lbl.TabIndex = 6;
            patronomyc_lbl.Text = "Отчество";
            // 
            // surname_lbl
            // 
            surname_lbl.AutoSize = true;
            surname_lbl.Font = new Font("Didact Gothic", 10.1999989F);
            surname_lbl.Location = new Point(16, 348);
            surname_lbl.Name = "surname_lbl";
            surname_lbl.Size = new Size(81, 25);
            surname_lbl.TabIndex = 5;
            surname_lbl.Text = "Фамилия";
            // 
            // cpatronymic_txt
            // 
            cpatronymic_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cpatronymic_txt.Location = new Point(13, 536);
            cpatronymic_txt.Name = "cpatronymic_txt";
            cpatronymic_txt.Size = new Size(323, 30);
            cpatronymic_txt.TabIndex = 4;
            // 
            // csurname_txt
            // 
            csurname_txt.Font = new Font("Didact Gothic", 10.1999989F);
            csurname_txt.Location = new Point(13, 453);
            csurname_txt.Name = "csurname_txt";
            csurname_txt.Size = new Size(323, 30);
            csurname_txt.TabIndex = 3;
            // 
            // cname_txt
            // 
            cname_txt.Font = new Font("Didact Gothic", 10.1999989F);
            cname_txt.Location = new Point(13, 373);
            cname_txt.Name = "cname_txt";
            cname_txt.Size = new Size(323, 30);
            cname_txt.TabIndex = 2;
            // 
            // fotodownload_btn
            // 
            fotodownload_btn.BackColor = Color.Transparent;
            fotodownload_btn.Font = new Font("Didact Gothic", 10.1999989F);
            fotodownload_btn.Location = new Point(69, 300);
            fotodownload_btn.Name = "fotodownload_btn";
            fotodownload_btn.Size = new Size(211, 39);
            fotodownload_btn.TabIndex = 1;
            fotodownload_btn.Text = "Загрузить фотографию";
            fotodownload_btn.UseVisualStyleBackColor = false;
            fotodownload_btn.Click += fotodownload_btn_Click;
            // 
            // clientpicture
            // 
            clientpicture.BorderStyle = BorderStyle.FixedSingle;
            clientpicture.Location = new Point(52, 11);
            clientpicture.Name = "clientpicture";
            clientpicture.Size = new Size(246, 283);
            clientpicture.SizeMode = PictureBoxSizeMode.Zoom;
            clientpicture.TabIndex = 0;
            clientpicture.TabStop = false;
            // 
            // customize_btn
            // 
            customize_btn.BackColor = Color.MediumAquamarine;
            customize_btn.Font = new Font("Didact Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customize_btn.Location = new Point(356, 47);
            customize_btn.Name = "customize_btn";
            customize_btn.Size = new Size(250, 107);
            customize_btn.TabIndex = 1;
            customize_btn.Text = "Редактировать предпочтения";
            customize_btn.UseVisualStyleBackColor = false;
            customize_btn.Click += button1_Click;
            // 
            // my_btn
            // 
            my_btn.BackColor = Color.LightSkyBlue;
            my_btn.Font = new Font("Didact Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            my_btn.Location = new Point(625, 47);
            my_btn.Name = "my_btn";
            my_btn.Size = new Size(250, 107);
            my_btn.TabIndex = 2;
            my_btn.Text = "Мои заказы";
            my_btn.UseVisualStyleBackColor = false;
            my_btn.Click += button2_Click;
            // 
            // disliked_btn
            // 
            disliked_btn.BackColor = Color.SteelBlue;
            disliked_btn.Font = new Font("Didact Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            disliked_btn.ForeColor = SystemColors.ButtonFace;
            disliked_btn.Location = new Point(891, 47);
            disliked_btn.Name = "disliked_btn";
            disliked_btn.Size = new Size(250, 107);
            disliked_btn.TabIndex = 3;
            disliked_btn.Text = "Скрытые профили";
            disliked_btn.UseVisualStyleBackColor = false;
            disliked_btn.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(691, 837);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ClientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1148, 711);
            Controls.Add(disliked_btn);
            Controls.Add(my_btn);
            Controls.Add(customize_btn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientProfile";
            Text = "Профиль";
            Load += ClientProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vkIcon_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button fotodownload_btn;
        private Label name_lbl;
        private Label patronomyc_lbl;
        private Label surname_lbl;
        private Label email_lbl;
        public PictureBox clientpicture;
        public TextBox cpatronymic_txt;
        public TextBox csurname_txt;
        public TextBox cname_txt;
        public TextBox id_txt;
        public TextBox cemail_txt;
        private Button customize_btn;
        private Button my_btn;
        private Button disliked_btn;
        private PictureBox pictureBox1;
        private PictureBox exit_btn;
        private PictureBox vkIcon_pic;
    }
}