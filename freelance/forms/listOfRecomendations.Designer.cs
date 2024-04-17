namespace freelance.forms
{
    partial class ListOfRecomendations
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfRecomendations));
            listofrecs_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname = new DataGridViewTextBoxColumn();
            pspecialization = new DataGridViewTextBoxColumn();
            ptime = new DataGridViewTextBoxColumn();
            ppriceofwork = new DataGridViewTextBoxColumn();
            pExperience = new DataGridViewTextBoxColumn();
            prating = new DataGridViewTextBoxColumn();
            settings_btn = new PictureBox();
            likedlist_btn = new PictureBox();
            like_btn = new PictureBox();
            dislike_btn = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)listofrecs_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likedlist_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)like_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dislike_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // listofrecs_dgv
            // 
            listofrecs_dgv.AllowUserToAddRows = false;
            listofrecs_dgv.AllowUserToDeleteRows = false;
            listofrecs_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listofrecs_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listofrecs_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listofrecs_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listofrecs_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listofrecs_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname, pspecialization, ptime, ppriceofwork, pExperience, prating });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            listofrecs_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            listofrecs_dgv.GridColor = Color.DarkSeaGreen;
            listofrecs_dgv.Location = new Point(180, 184);
            listofrecs_dgv.Name = "listofrecs_dgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            listofrecs_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            listofrecs_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            listofrecs_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            listofrecs_dgv.Size = new Size(763, 527);
            listofrecs_dgv.TabIndex = 0;
            listofrecs_dgv.CellDoubleClick += listofrecs_dgv_CellDoubleClick;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 57;
            // 
            // pname
            // 
            pname.Frozen = true;
            pname.HeaderText = "ФИО";
            pname.MinimumWidth = 6;
            pname.Name = "pname";
            pname.Width = 77;
            // 
            // pspecialization
            // 
            pspecialization.Frozen = true;
            pspecialization.HeaderText = "Специализация";
            pspecialization.MinimumWidth = 6;
            pspecialization.Name = "pspecialization";
            pspecialization.Width = 158;
            // 
            // ptime
            // 
            ptime.Frozen = true;
            ptime.HeaderText = "Время выполнения";
            ptime.MinimumWidth = 6;
            ptime.Name = "ptime";
            ptime.Width = 167;
            // 
            // ppriceofwork
            // 
            ppriceofwork.Frozen = true;
            ppriceofwork.HeaderText = "Цена";
            ppriceofwork.MinimumWidth = 6;
            ppriceofwork.Name = "ppriceofwork";
            ppriceofwork.Width = 80;
            // 
            // pExperience
            // 
            pExperience.Frozen = true;
            pExperience.HeaderText = "Опыт работы";
            pExperience.MinimumWidth = 6;
            pExperience.Name = "pExperience";
            pExperience.Width = 130;
            // 
            // prating
            // 
            prating.Frozen = true;
            prating.HeaderText = "Рейтинг";
            prating.MinimumWidth = 6;
            prating.Name = "prating";
            prating.Width = 101;
            // 
            // settings_btn
            // 
            settings_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settings_btn.BackColor = Color.DarkSeaGreen;
            settings_btn.Image = (Image)resources.GetObject("settings_btn.Image");
            settings_btn.Location = new Point(9, 17);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(61, 42);
            settings_btn.SizeMode = PictureBoxSizeMode.Zoom;
            settings_btn.TabIndex = 1;
            settings_btn.TabStop = false;
            settings_btn.Click += settings_btn_Click;
            settings_btn.MouseEnter += settings_btn_MouseEnter;
            settings_btn.MouseLeave += settings_btn_MouseLeave;
            // 
            // likedlist_btn
            // 
            likedlist_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            likedlist_btn.BackColor = Color.DarkSeaGreen;
            likedlist_btn.Image = (Image)resources.GetObject("likedlist_btn.Image");
            likedlist_btn.Location = new Point(96, 17);
            likedlist_btn.Name = "likedlist_btn";
            likedlist_btn.Size = new Size(61, 42);
            likedlist_btn.SizeMode = PictureBoxSizeMode.Zoom;
            likedlist_btn.TabIndex = 2;
            likedlist_btn.TabStop = false;
            likedlist_btn.Click += likedlist_btn_Click;
            likedlist_btn.MouseEnter += likedlist_btn_MouseEnter;
            likedlist_btn.MouseLeave += likedlist_btn_MouseLeave;
            // 
            // like_btn
            // 
            like_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            like_btn.BackColor = Color.DarkSeaGreen;
            like_btn.Image = (Image)resources.GetObject("like_btn.Image");
            like_btn.Location = new Point(1007, 336);
            like_btn.Name = "like_btn";
            like_btn.Size = new Size(84, 67);
            like_btn.SizeMode = PictureBoxSizeMode.Zoom;
            like_btn.TabIndex = 4;
            like_btn.TabStop = false;
            like_btn.Click += like_btn_Click;
            like_btn.MouseEnter += like_btn_MouseEnter;
            like_btn.MouseLeave += like_btn_MouseLeave;
            // 
            // dislike_btn
            // 
            dislike_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dislike_btn.BackColor = Color.DarkSeaGreen;
            dislike_btn.Image = (Image)resources.GetObject("dislike_btn.Image");
            dislike_btn.Location = new Point(1007, 448);
            dislike_btn.Name = "dislike_btn";
            dislike_btn.Size = new Size(84, 67);
            dislike_btn.SizeMode = PictureBoxSizeMode.Zoom;
            dislike_btn.TabIndex = 5;
            dislike_btn.TabStop = false;
            dislike_btn.Click += dislike_btn_Click;
            dislike_btn.MouseEnter += dislike_btn_MouseEnter;
            dislike_btn.MouseLeave += dislike_btn_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 512);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 151);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-121, 105);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(295, 282);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(891, -71);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(334, 296);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // ListOfRecomendations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1153, 712);
            Controls.Add(dislike_btn);
            Controls.Add(like_btn);
            Controls.Add(likedlist_btn);
            Controls.Add(settings_btn);
            Controls.Add(listofrecs_dgv);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListOfRecomendations";
            Text = "Главная";
            Load += listOfRecomendations_Load;
            ((System.ComponentModel.ISupportInitialize)listofrecs_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)likedlist_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)like_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dislike_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listofrecs_dgv;
        private PictureBox settings_btn;
        private PictureBox likedlist_btn;
        private PictureBox like_btn;
        private PictureBox dislike_btn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pspecialization;
        private DataGridViewTextBoxColumn ptime;
        private DataGridViewTextBoxColumn ppriceofwork;
        private DataGridViewTextBoxColumn pExperience;
        private DataGridViewTextBoxColumn prating;
    }
}