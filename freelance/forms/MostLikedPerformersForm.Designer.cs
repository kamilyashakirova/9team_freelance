namespace freelance.forms
{
    partial class MostLikedPerformersForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostLikedPerformersForm));
            liked_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname_liked = new DataGridViewTextBoxColumn();
            pspecialisation_liked = new DataGridViewTextBoxColumn();
            ptime_liked = new DataGridViewTextBoxColumn();
            planguage_liked = new DataGridViewTextBoxColumn();
            pExperience_liked = new DataGridViewTextBoxColumn();
            pproduct_liked = new DataGridViewTextBoxColumn();
            mostliked_lbl = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            like_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)liked_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)like_btn).BeginInit();
            SuspendLayout();
            // 
            // liked_dgv
            // 
            liked_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            liked_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            liked_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            liked_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            liked_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            liked_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            liked_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname_liked, pspecialisation_liked, ptime_liked, planguage_liked, pExperience_liked, pproduct_liked });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            liked_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            liked_dgv.GridColor = Color.DarkSeaGreen;
            liked_dgv.Location = new Point(1, 136);
            liked_dgv.Margin = new Padding(3, 2, 3, 2);
            liked_dgv.Name = "liked_dgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            liked_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            liked_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            liked_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            liked_dgv.Size = new Size(699, 397);
            liked_dgv.TabIndex = 1;
            liked_dgv.CellContentClick += liked_dgv_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // pname_liked
            // 
            pname_liked.HeaderText = "ФИО";
            pname_liked.MinimumWidth = 6;
            pname_liked.Name = "pname_liked";
            pname_liked.Width = 125;
            // 
            // pspecialisation_liked
            // 
            pspecialisation_liked.HeaderText = "Специализация";
            pspecialisation_liked.MinimumWidth = 6;
            pspecialisation_liked.Name = "pspecialisation_liked";
            pspecialisation_liked.Width = 125;
            // 
            // ptime_liked
            // 
            ptime_liked.HeaderText = "Срок";
            ptime_liked.MinimumWidth = 6;
            ptime_liked.Name = "ptime_liked";
            ptime_liked.Width = 125;
            // 
            // planguage_liked
            // 
            planguage_liked.HeaderText = "Знание языков";
            planguage_liked.MinimumWidth = 6;
            planguage_liked.Name = "planguage_liked";
            planguage_liked.Width = 125;
            // 
            // pExperience_liked
            // 
            pExperience_liked.HeaderText = "Опыт";
            pExperience_liked.MinimumWidth = 6;
            pExperience_liked.Name = "pExperience_liked";
            pExperience_liked.Width = 125;
            // 
            // pproduct_liked
            // 
            pproduct_liked.HeaderText = "Продукт";
            pproduct_liked.MinimumWidth = 6;
            pproduct_liked.Name = "pproduct_liked";
            pproduct_liked.Width = 125;
            // 
            // mostliked_lbl
            // 
            mostliked_lbl.AutoSize = true;
            mostliked_lbl.BorderStyle = BorderStyle.FixedSingle;
            mostliked_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mostliked_lbl.Location = new Point(1, 93);
            mostliked_lbl.Name = "mostliked_lbl";
            mostliked_lbl.Size = new Size(337, 28);
            mostliked_lbl.TabIndex = 2;
            mostliked_lbl.Text = "Смотрите, что нравится другим";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(709, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(396, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(709, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(447, -80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(825, -106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(245, 306);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // like_btn
            // 
            like_btn.Anchor = AnchorStyles.Left;
            like_btn.BackColor = Color.Pink;
            like_btn.BorderStyle = BorderStyle.FixedSingle;
            like_btn.Image = (Image)resources.GetObject("like_btn.Image");
            like_btn.Location = new Point(802, 248);
            like_btn.Margin = new Padding(3, 2, 3, 2);
            like_btn.Name = "like_btn";
            like_btn.Size = new Size(89, 66);
            like_btn.SizeMode = PictureBoxSizeMode.Zoom;
            like_btn.TabIndex = 21;
            like_btn.TabStop = false;
            like_btn.Click += like_btn_Click;
            // 
            // MostLikedPerformersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(980, 533);
            Controls.Add(like_btn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(mostliked_lbl);
            Controls.Add(liked_dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MostLikedPerformersForm";
            Text = "Общая подборка";
            Load += MostLikedPerformersForm_Load;
            ((System.ComponentModel.ISupportInitialize)liked_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)like_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView liked_dgv;
        private Label mostliked_lbl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname_liked;
        private DataGridViewTextBoxColumn pspecialisation_liked;
        private DataGridViewTextBoxColumn ptime_liked;
        private DataGridViewTextBoxColumn planguage_liked;
        private DataGridViewTextBoxColumn pExperience_liked;
        private DataGridViewTextBoxColumn pproduct_liked;
        private PictureBox like_btn;
    }
}