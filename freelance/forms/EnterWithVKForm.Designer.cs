namespace freelance
{
    partial class EnterWithVKForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterWithVKForm));
            VKlogin_txt = new TextBox();
            VKpassword_txt = new TextBox();
            enterWithVK_btn = new PictureBox();
            enter_rus_lbl = new Label();
            show_pic = new PictureBox();
            hide_picb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)enterWithVK_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)show_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hide_picb).BeginInit();
            SuspendLayout();
            // 
            // VKlogin_txt
            // 
            VKlogin_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VKlogin_txt.Location = new Point(65, 110);
            VKlogin_txt.Margin = new Padding(4);
            VKlogin_txt.Name = "VKlogin_txt";
            VKlogin_txt.PlaceholderText = "Телефон или email";
            VKlogin_txt.Size = new Size(325, 28);
            VKlogin_txt.TabIndex = 0;
            // 
            // VKpassword_txt
            // 
            VKpassword_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VKpassword_txt.Location = new Point(65, 185);
            VKpassword_txt.Margin = new Padding(4);
            VKpassword_txt.Name = "VKpassword_txt";
            VKpassword_txt.PasswordChar = '*';
            VKpassword_txt.PlaceholderText = "Пароль";
            VKpassword_txt.Size = new Size(325, 28);
            VKpassword_txt.TabIndex = 1;
            VKpassword_txt.TextChanged += VKpassword_txt_TextChanged;
            // 
            // enterWithVK_btn
            // 
            enterWithVK_btn.Image = (Image)resources.GetObject("enterWithVK_btn.Image");
            enterWithVK_btn.Location = new Point(65, 260);
            enterWithVK_btn.Name = "enterWithVK_btn";
            enterWithVK_btn.Size = new Size(317, 60);
            enterWithVK_btn.SizeMode = PictureBoxSizeMode.Zoom;
            enterWithVK_btn.TabIndex = 31;
            enterWithVK_btn.TabStop = false;
            enterWithVK_btn.Click += enterWithVK_btn_Click;
            // 
            // enter_rus_lbl
            // 
            enter_rus_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enter_rus_lbl.AutoSize = true;
            enter_rus_lbl.BackColor = SystemColors.MenuHighlight;
            enter_rus_lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enter_rus_lbl.ForeColor = Color.White;
            enter_rus_lbl.Location = new Point(170, 278);
            enter_rus_lbl.Name = "enter_rus_lbl";
            enter_rus_lbl.Size = new Size(137, 25);
            enter_rus_lbl.TabIndex = 33;
            enter_rus_lbl.Text = "Вход с ВК ID";
            // 
            // show_pic
            // 
            show_pic.Image = (Image)resources.GetObject("show_pic.Image");
            show_pic.Location = new Point(397, 175);
            show_pic.Name = "show_pic";
            show_pic.Size = new Size(35, 50);
            show_pic.SizeMode = PictureBoxSizeMode.Zoom;
            show_pic.TabIndex = 34;
            show_pic.TabStop = false;
            show_pic.Click += show_pic_Click;
            // 
            // hide_picb
            // 
            hide_picb.Image = (Image)resources.GetObject("hide_picb.Image");
            hide_picb.Location = new Point(397, 175);
            hide_picb.Name = "hide_picb";
            hide_picb.Size = new Size(35, 50);
            hide_picb.SizeMode = PictureBoxSizeMode.Zoom;
            hide_picb.TabIndex = 35;
            hide_picb.TabStop = false;
            hide_picb.Click += hide_picb_Click;
            // 
            // EnterWithVKForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 421);
            Controls.Add(show_pic);
            Controls.Add(hide_picb);
            Controls.Add(enter_rus_lbl);
            Controls.Add(enterWithVK_btn);
            Controls.Add(VKpassword_txt);
            Controls.Add(VKlogin_txt);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EnterWithVKForm";
            Text = "Вход с ВК";
            Load += EnterWithVKForm_Load;
            ((System.ComponentModel.ISupportInitialize)enterWithVK_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)show_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)hide_picb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox VKlogin_txt;
        private TextBox VKpassword_txt;
        private PictureBox enterWithVK_btn;
        private Label enter_rus_lbl;
        private PictureBox show_pic;
        private PictureBox hide_picb;
    }
}