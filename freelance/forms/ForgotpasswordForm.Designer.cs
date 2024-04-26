namespace freelance.forms
{
    partial class ForgotpasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotpasswordForm));
            newpassword_txt = new TextBox();
            errorEXp_lbl = new Label();
            errorRepeatnewp_lbl = new Label();
            passwordrecovery_lbl = new Label();
            writepassword_lbl = new Label();
            login_txt = new TextBox();
            loginerror_lbl = new Label();
            passworderror_lbl = new Label();
            login_lbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            sendpassword_btn = new Button();
            newenter_btn = new Button();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // newpassword_txt
            // 
            newpassword_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newpassword_txt.Font = new Font("Didact Gothic", 10.1999989F);
            newpassword_txt.Location = new Point(151, 301);
            newpassword_txt.Name = "newpassword_txt";
            newpassword_txt.PasswordChar = '*';
            newpassword_txt.PlaceholderText = "Введите пароль";
            newpassword_txt.Size = new Size(243, 30);
            newpassword_txt.TabIndex = 2;
            newpassword_txt.Visible = false;
            // 
            // errorEXp_lbl
            // 
            errorEXp_lbl.AutoSize = true;
            errorEXp_lbl.Font = new Font("Didact Gothic", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            errorEXp_lbl.Location = new Point(148, 206);
            errorEXp_lbl.Name = "errorEXp_lbl";
            errorEXp_lbl.Size = new Size(0, 22);
            errorEXp_lbl.TabIndex = 4;
            // 
            // errorRepeatnewp_lbl
            // 
            errorRepeatnewp_lbl.AutoSize = true;
            errorRepeatnewp_lbl.Location = new Point(151, 376);
            errorRepeatnewp_lbl.Name = "errorRepeatnewp_lbl";
            errorRepeatnewp_lbl.Size = new Size(0, 20);
            errorRepeatnewp_lbl.TabIndex = 5;
            // 
            // passwordrecovery_lbl
            // 
            passwordrecovery_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordrecovery_lbl.AutoSize = true;
            passwordrecovery_lbl.Font = new Font("Didact Gothic", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordrecovery_lbl.Location = new Point(102, 46);
            passwordrecovery_lbl.Name = "passwordrecovery_lbl";
            passwordrecovery_lbl.Size = new Size(343, 43);
            passwordrecovery_lbl.TabIndex = 6;
            passwordrecovery_lbl.Text = "Восстановление пароля";
            // 
            // writepassword_lbl
            // 
            writepassword_lbl.AutoSize = true;
            writepassword_lbl.Font = new Font("Didact Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            writepassword_lbl.Location = new Point(49, 270);
            writepassword_lbl.Name = "writepassword_lbl";
            writepassword_lbl.Size = new Size(497, 28);
            writepassword_lbl.TabIndex = 7;
            writepassword_lbl.Text = "Введите пароль, который мы отправили на вашу почту";
            writepassword_lbl.Visible = false;
            // 
            // login_txt
            // 
            login_txt.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login_txt.Location = new Point(102, 126);
            login_txt.Name = "login_txt";
            login_txt.PlaceholderText = "Введите логин";
            login_txt.Size = new Size(352, 30);
            login_txt.TabIndex = 8;
            // 
            // loginerror_lbl
            // 
            loginerror_lbl.AutoSize = true;
            loginerror_lbl.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginerror_lbl.Location = new Point(198, 156);
            loginerror_lbl.Name = "loginerror_lbl";
            loginerror_lbl.Size = new Size(135, 25);
            loginerror_lbl.TabIndex = 9;
            loginerror_lbl.Text = "Неверный логин";
            loginerror_lbl.Visible = false;
            // 
            // passworderror_lbl
            // 
            passworderror_lbl.AutoSize = true;
            passworderror_lbl.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passworderror_lbl.Location = new Point(198, 334);
            passworderror_lbl.Name = "passworderror_lbl";
            passworderror_lbl.Size = new Size(147, 25);
            passworderror_lbl.TabIndex = 10;
            passworderror_lbl.Text = "Неверный пароль";
            passworderror_lbl.Visible = false;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Didact Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login_lbl.Location = new Point(198, 97);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(142, 28);
            login_lbl.TabIndex = 11;
            login_lbl.Text = "Введите логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-62, 270);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 335);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // sendpassword_btn
            // 
            sendpassword_btn.BackColor = SystemColors.Window;
            sendpassword_btn.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendpassword_btn.Location = new Point(127, 206);
            sendpassword_btn.Name = "sendpassword_btn";
            sendpassword_btn.Size = new Size(288, 36);
            sendpassword_btn.TabIndex = 14;
            sendpassword_btn.Text = "Отправить пароль на почту";
            sendpassword_btn.UseVisualStyleBackColor = false;
            sendpassword_btn.Click += sendpassword_btn_Click;
            // 
            // newenter_btn
            // 
            newenter_btn.BackColor = SystemColors.Window;
            newenter_btn.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newenter_btn.Location = new Point(209, 361);
            newenter_btn.Name = "newenter_btn";
            newenter_btn.Size = new Size(111, 39);
            newenter_btn.TabIndex = 15;
            newenter_btn.Text = "Войти";
            newenter_btn.UseVisualStyleBackColor = false;
            newenter_btn.Visible = false;
            newenter_btn.Click += newenter_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(2, 1);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(52, 58);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 30;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // ForgotpasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(558, 412);
            Controls.Add(exit_btn);
            Controls.Add(newenter_btn);
            Controls.Add(sendpassword_btn);
            Controls.Add(login_lbl);
            Controls.Add(passworderror_lbl);
            Controls.Add(loginerror_lbl);
            Controls.Add(login_txt);
            Controls.Add(writepassword_lbl);
            Controls.Add(passwordrecovery_lbl);
            Controls.Add(errorRepeatnewp_lbl);
            Controls.Add(errorEXp_lbl);
            Controls.Add(newpassword_txt);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotpasswordForm";
            Text = "восстановление пароля";
            Load += ForgotpasswordForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox newpassword_txt;
        private Label errorEXp_lbl;
        private Label errorRepeatnewp_lbl;
        private Label passwordrecovery_lbl;
        private Label writepassword_lbl;
        private TextBox login_txt;
        private Label loginerror_lbl;
        private Label passworderror_lbl;
        private Label login_lbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button sendpassword_btn;
        private Button newenter_btn;
        private PictureBox exit_btn;
    }
}