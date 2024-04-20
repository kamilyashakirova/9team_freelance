namespace freelance.forms
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            reg_lbl = new Label();
            rname_txtb = new TextBox();
            rlogin_txtb = new TextBox();
            rpatronomic_txtb = new TextBox();
            rsurname_txtb = new TextBox();
            rpasswordrepeat_txtb = new TextBox();
            rpassword_txtb = new TextBox();
            rEmail_txtb = new TextBox();
            show_pic = new PictureBox();
            hide_picb = new PictureBox();
            rnae_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            registration_btn = new Button();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)show_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hide_picb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // reg_lbl
            // 
            reg_lbl.AutoEllipsis = true;
            reg_lbl.AutoSize = true;
            reg_lbl.Font = new Font("Didact Gothic", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reg_lbl.Location = new Point(191, 11);
            reg_lbl.Name = "reg_lbl";
            reg_lbl.Size = new Size(190, 43);
            reg_lbl.TabIndex = 0;
            reg_lbl.Text = "Регистрация";
            // 
            // rname_txtb
            // 
            rname_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rname_txtb.Location = new Point(82, 104);
            rname_txtb.Margin = new Padding(3, 4, 3, 4);
            rname_txtb.Name = "rname_txtb";
            rname_txtb.PlaceholderText = "Имя";
            rname_txtb.Size = new Size(417, 30);
            rname_txtb.TabIndex = 1;
            // 
            // rlogin_txtb
            // 
            rlogin_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rlogin_txtb.Location = new Point(82, 311);
            rlogin_txtb.Margin = new Padding(3, 4, 3, 4);
            rlogin_txtb.Name = "rlogin_txtb";
            rlogin_txtb.PlaceholderText = "Логин";
            rlogin_txtb.Size = new Size(417, 30);
            rlogin_txtb.TabIndex = 2;
            // 
            // rpatronomic_txtb
            // 
            rpatronomic_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rpatronomic_txtb.Location = new Point(82, 241);
            rpatronomic_txtb.Margin = new Padding(3, 4, 3, 4);
            rpatronomic_txtb.Name = "rpatronomic_txtb";
            rpatronomic_txtb.PlaceholderText = "Отчество (при наличии)";
            rpatronomic_txtb.Size = new Size(417, 30);
            rpatronomic_txtb.TabIndex = 3;
            // 
            // rsurname_txtb
            // 
            rsurname_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rsurname_txtb.Location = new Point(82, 172);
            rsurname_txtb.Margin = new Padding(3, 4, 3, 4);
            rsurname_txtb.Name = "rsurname_txtb";
            rsurname_txtb.PlaceholderText = "Фамилия ";
            rsurname_txtb.Size = new Size(417, 30);
            rsurname_txtb.TabIndex = 4;
            // 
            // rpasswordrepeat_txtb
            // 
            rpasswordrepeat_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rpasswordrepeat_txtb.Location = new Point(82, 451);
            rpasswordrepeat_txtb.Margin = new Padding(3, 4, 3, 4);
            rpasswordrepeat_txtb.Name = "rpasswordrepeat_txtb";
            rpasswordrepeat_txtb.PasswordChar = '*';
            rpasswordrepeat_txtb.PlaceholderText = "Повторите пароль";
            rpasswordrepeat_txtb.Size = new Size(417, 30);
            rpasswordrepeat_txtb.TabIndex = 5;
            // 
            // rpassword_txtb
            // 
            rpassword_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rpassword_txtb.Location = new Point(82, 382);
            rpassword_txtb.Margin = new Padding(3, 4, 3, 4);
            rpassword_txtb.Name = "rpassword_txtb";
            rpassword_txtb.PasswordChar = '*';
            rpassword_txtb.PlaceholderText = "Пароль";
            rpassword_txtb.Size = new Size(417, 30);
            rpassword_txtb.TabIndex = 6;
            // 
            // rEmail_txtb
            // 
            rEmail_txtb.Font = new Font("Didact Gothic", 10.1999989F);
            rEmail_txtb.Location = new Point(82, 522);
            rEmail_txtb.Margin = new Padding(3, 4, 3, 4);
            rEmail_txtb.Name = "rEmail_txtb";
            rEmail_txtb.PlaceholderText = "E-mail";
            rEmail_txtb.Size = new Size(417, 30);
            rEmail_txtb.TabIndex = 7;
            // 
            // show_pic
            // 
            show_pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_pic.Image = (Image)resources.GetObject("show_pic.Image");
            show_pic.Location = new Point(505, 372);
            show_pic.Name = "show_pic";
            show_pic.Size = new Size(35, 55);
            show_pic.SizeMode = PictureBoxSizeMode.Zoom;
            show_pic.TabIndex = 10;
            show_pic.TabStop = false;
            show_pic.Visible = false;
            show_pic.Click += show_pic_Click;
            // 
            // hide_picb
            // 
            hide_picb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hide_picb.Image = (Image)resources.GetObject("hide_picb.Image");
            hide_picb.Location = new Point(505, 372);
            hide_picb.Name = "hide_picb";
            hide_picb.Size = new Size(35, 55);
            hide_picb.SizeMode = PictureBoxSizeMode.Zoom;
            hide_picb.TabIndex = 11;
            hide_picb.TabStop = false;
            hide_picb.Click += hide_picb_Click;
            // 
            // rnae_lbl
            // 
            rnae_lbl.AutoSize = true;
            rnae_lbl.BackColor = Color.DarkSeaGreen;
            rnae_lbl.Location = new Point(82, 75);
            rnae_lbl.Name = "rnae_lbl";
            rnae_lbl.Size = new Size(106, 25);
            rnae_lbl.TabIndex = 12;
            rnae_lbl.Text = "Введите имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 422);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 13;
            label1.Text = "Повторите пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 353);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 14;
            label2.Text = "Придумайте пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 282);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 15;
            label3.Text = "Введите логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 212);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 16;
            label4.Text = "Введите отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 143);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 17;
            label5.Text = "Введите фамилию";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 493);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 18;
            label6.Text = "Введите e-mail";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(411, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 535);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 151);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // registration_btn
            // 
            registration_btn.BackColor = SystemColors.Window;
            registration_btn.Font = new Font("Didact Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registration_btn.Location = new Point(191, 590);
            registration_btn.Name = "registration_btn";
            registration_btn.Size = new Size(207, 45);
            registration_btn.TabIndex = 22;
            registration_btn.Text = "Зарегистрироваться";
            registration_btn.UseVisualStyleBackColor = false;
            registration_btn.Click += registration_btb_click;
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(1, 0);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(44, 65);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 31;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // registrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(579, 740);
            Controls.Add(exit_btn);
            Controls.Add(registration_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rnae_lbl);
            Controls.Add(show_pic);
            Controls.Add(hide_picb);
            Controls.Add(rEmail_txtb);
            Controls.Add(rpassword_txtb);
            Controls.Add(rpasswordrepeat_txtb);
            Controls.Add(rsurname_txtb);
            Controls.Add(rpatronomic_txtb);
            Controls.Add(rlogin_txtb);
            Controls.Add(rname_txtb);
            Controls.Add(reg_lbl);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Font = new Font("Didact Gothic", 10.1999989F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "registrationForm";
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)show_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)hide_picb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label reg_lbl;
        private TextBox rname_txtb;
        private TextBox rlogin_txtb;
        private TextBox rpatronomic_txtb;
        private TextBox rsurname_txtb;
        private TextBox rpasswordrepeat_txtb;
        private TextBox rpassword_txtb;
        private TextBox rEmail_txtb;
        private PictureBox show_pic;
        private PictureBox hide_picb;
        private Label rnae_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button registration_btn;
        private PictureBox exit_btn;
    }
}