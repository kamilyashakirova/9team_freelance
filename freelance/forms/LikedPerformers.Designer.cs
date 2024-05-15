namespace freelance.forms
{
    partial class Likedperformers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Likedperformers));
            liked_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname_liked = new DataGridViewTextBoxColumn();
            pspecialisation_liked = new DataGridViewTextBoxColumn();
            ptime_liked = new DataGridViewTextBoxColumn();
            planguage_liked = new DataGridViewTextBoxColumn();
            pExperience_liked = new DataGridViewTextBoxColumn();
            pproduct_liked = new DataGridViewTextBoxColumn();
            liked_lbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)liked_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
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
            liked_dgv.Location = new Point(-1, 150);
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
            liked_dgv.Size = new Size(656, 386);
            liked_dgv.TabIndex = 0;
            liked_dgv.CellDoubleClick += liked_dgv_CellDoubleClick;
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
            // liked_lbl
            // 
            liked_lbl.AutoSize = true;
            liked_lbl.BorderStyle = BorderStyle.FixedSingle;
            liked_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            liked_lbl.Location = new Point(-1, 93);
            liked_lbl.Name = "liked_lbl";
            liked_lbl.Size = new Size(126, 28);
            liked_lbl.TabIndex = 1;
            liked_lbl.Text = "Избранное";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, -87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(686, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(686, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(396, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(802, -112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(245, 306);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(-1, -2);
            exit_btn.Margin = new Padding(3, 2, 3, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(49, 56);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 28;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Likedperformers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 533);
            Controls.Add(exit_btn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(liked_lbl);
            Controls.Add(liked_dgv);
            Controls.Add(pictureBox4);
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Likedperformers";
            Text = "Избранное";
            Load += likedperformers_Load;
            ((System.ComponentModel.ISupportInitialize)liked_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label liked_lbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        internal DataGridView liked_dgv;
        private PictureBox exit_btn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname_liked;
        private DataGridViewTextBoxColumn pspecialisation_liked;
        private DataGridViewTextBoxColumn ptime_liked;
        private DataGridViewTextBoxColumn planguage_liked;
        private DataGridViewTextBoxColumn pExperience_liked;
        private DataGridViewTextBoxColumn pproduct_liked;
    }
}