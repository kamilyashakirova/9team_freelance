namespace freelance
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            login_txtb = new TextBox();
            password_txtb = new TextBox();
            hi_lbl = new Label();
            enter_btn = new Button();
            hide_picb = new PictureBox();
            forgotpassword_lbl = new Label();
            registration_lbl = new Label();
            athoriz_pic = new PictureBox();
            entererror_lbl = new Label();
            show_pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hide_picb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)athoriz_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)show_pic).BeginInit();
            SuspendLayout();
            // 
            // login_txtb
            // 
            login_txtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_txtb.BorderStyle = BorderStyle.None;
            login_txtb.Font = new Font("Didact Gothic", 10.8F);
            login_txtb.ForeColor = SystemColors.WindowFrame;
            login_txtb.Location = new Point(75, 246);
            login_txtb.Name = "login_txtb";
            login_txtb.PlaceholderText = "Введите логин";
            login_txtb.Size = new Size(225, 24);
            login_txtb.TabIndex = 0;
            login_txtb.TextAlign = HorizontalAlignment.Center;
            login_txtb.TextChanged += login_txtb_TextChanged;
            // 
            // password_txtb
            // 
            password_txtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_txtb.BorderStyle = BorderStyle.None;
            password_txtb.Font = new Font("Didact Gothic", 10.8F);
            password_txtb.ForeColor = SystemColors.WindowFrame;
            password_txtb.Location = new Point(75, 296);
            password_txtb.Name = "password_txtb";
            password_txtb.PasswordChar = '*';
            password_txtb.PlaceholderText = "Введите пароль";
            password_txtb.Size = new Size(225, 24);
            password_txtb.TabIndex = 3;
            password_txtb.TabStop = false;
            password_txtb.TextAlign = HorizontalAlignment.Center;
            // 
            // hi_lbl
            // 
            hi_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hi_lbl.AutoSize = true;
            hi_lbl.Font = new Font("Didact Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            hi_lbl.ForeColor = Color.Teal;
            hi_lbl.Location = new Point(124, 187);
            hi_lbl.Name = "hi_lbl";
            hi_lbl.Size = new Size(127, 40);
            hi_lbl.TabIndex = 2;
            hi_lbl.Text = "ПРИВЕТ!";
            // 
            // enter_btn
            // 
            enter_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enter_btn.BackColor = SystemColors.ControlLightLight;
            enter_btn.Font = new Font("Didact Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enter_btn.ForeColor = SystemColors.WindowText;
            enter_btn.Location = new Point(138, 344);
            enter_btn.Name = "enter_btn";
            enter_btn.Size = new Size(94, 39);
            enter_btn.TabIndex = 3;
            enter_btn.Text = "ВОЙТИ";
            enter_btn.UseVisualStyleBackColor = false;
            enter_btn.Click += enter_btn_Click;
            // 
            // hide_picb
            // 
            hide_picb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hide_picb.Image = (Image)resources.GetObject("hide_picb.Image");
            hide_picb.Location = new Point(315, 286);
            hide_picb.Name = "hide_picb";
            hide_picb.Size = new Size(35, 40);
            hide_picb.SizeMode = PictureBoxSizeMode.Zoom;
            hide_picb.TabIndex = 4;
            hide_picb.TabStop = false;
            hide_picb.Click += hide_picb_Click;
            // 
            // forgotpassword_lbl
            // 
            forgotpassword_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            forgotpassword_lbl.AutoSize = true;
            forgotpassword_lbl.Font = new Font("Didact Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            forgotpassword_lbl.Location = new Point(111, 457);
            forgotpassword_lbl.Name = "forgotpassword_lbl";
            forgotpassword_lbl.Size = new Size(155, 28);
            forgotpassword_lbl.TabIndex = 5;
            forgotpassword_lbl.Text = "Забыли пароль?";
            forgotpassword_lbl.Click += forgotpassword_lbl_Click;
            // 
            // registration_lbl
            // 
            registration_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registration_lbl.AutoSize = true;
            registration_lbl.Font = new Font("Didact Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registration_lbl.Location = new Point(87, 485);
            registration_lbl.Name = "registration_lbl";
            registration_lbl.Size = new Size(203, 28);
            registration_lbl.TabIndex = 6;
            registration_lbl.Text = "Зарегистрироваться ";
            registration_lbl.Click += registration_lbl_Click;
            // 
            // athoriz_pic
            // 
            athoriz_pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            athoriz_pic.Image = (Image)resources.GetObject("athoriz_pic.Image");
            athoriz_pic.Location = new Point(369, 27);
            athoriz_pic.Name = "athoriz_pic";
            athoriz_pic.Size = new Size(522, 513);
            athoriz_pic.SizeMode = PictureBoxSizeMode.Zoom;
            athoriz_pic.TabIndex = 7;
            athoriz_pic.TabStop = false;
            // 
            // entererror_lbl
            // 
            entererror_lbl.AutoSize = true;
            entererror_lbl.Font = new Font("Didact Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entererror_lbl.Location = new Point(60, 395);
            entererror_lbl.Name = "entererror_lbl";
            entererror_lbl.Size = new Size(0, 28);
            entererror_lbl.TabIndex = 8;
            // 
            // show_pic
            // 
            show_pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_pic.Image = (Image)resources.GetObject("show_pic.Image");
            show_pic.Location = new Point(315, 286);
            show_pic.Name = "show_pic";
            show_pic.Size = new Size(35, 40);
            show_pic.SizeMode = PictureBoxSizeMode.Zoom;
            show_pic.TabIndex = 9;
            show_pic.TabStop = false;
            show_pic.Visible = false;
            show_pic.Click += show_pic_Click;
            // 
            // Enter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(887, 535);
            Controls.Add(show_pic);
            Controls.Add(hide_picb);
            Controls.Add(entererror_lbl);
            Controls.Add(registration_lbl);
            Controls.Add(forgotpassword_lbl);
            Controls.Add(enter_btn);
            Controls.Add(hi_lbl);
            Controls.Add(password_txtb);
            Controls.Add(login_txtb);
            Controls.Add(athoriz_pic);
            Name = "Enter";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)hide_picb).EndInit();
            ((System.ComponentModel.ISupportInitialize)athoriz_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)show_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_txtb;
        private TextBox password_txtb;
        private Label hi_lbl;
        private Button enter_btn;
        private PictureBox hide_picb;
        private Label forgotpassword_lbl;
        private Label registration_lbl;
        private PictureBox athoriz_pic;
        private Label entererror_lbl;
        private PictureBox show_pic;
    }
}
