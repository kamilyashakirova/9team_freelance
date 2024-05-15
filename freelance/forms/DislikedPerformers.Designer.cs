namespace freelance.forms
{
    partial class Dislikedperformers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dislikedperformers));
            disliked_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname_disliked = new DataGridViewTextBoxColumn();
            pspecialisation_disliked = new DataGridViewTextBoxColumn();
            ptime_disliked = new DataGridViewTextBoxColumn();
            planguage_disliked = new DataGridViewTextBoxColumn();
            pExperience_disliked = new DataGridViewTextBoxColumn();
            pproduct_disliked = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            disliked_lbl = new Label();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)disliked_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // disliked_dgv
            // 
            disliked_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            disliked_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            disliked_dgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            disliked_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            disliked_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            disliked_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            disliked_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname_disliked, pspecialisation_disliked, ptime_disliked, planguage_disliked, pExperience_disliked, pproduct_disliked });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            disliked_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            disliked_dgv.GridColor = Color.DarkSeaGreen;
            disliked_dgv.Location = new Point(0, 150);
            disliked_dgv.Margin = new Padding(3, 2, 3, 2);
            disliked_dgv.Name = "disliked_dgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            disliked_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            disliked_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            disliked_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            disliked_dgv.Size = new Size(656, 386);
            disliked_dgv.TabIndex = 1;
            disliked_dgv.CellDoubleClick += disliked_dgv_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // pname_disliked
            // 
            pname_disliked.HeaderText = "ФИО";
            pname_disliked.MinimumWidth = 6;
            pname_disliked.Name = "pname_disliked";
            pname_disliked.Width = 125;
            // 
            // pspecialisation_disliked
            // 
            pspecialisation_disliked.HeaderText = "Специализация";
            pspecialisation_disliked.MinimumWidth = 6;
            pspecialisation_disliked.Name = "pspecialisation_disliked";
            pspecialisation_disliked.Width = 125;
            // 
            // ptime_disliked
            // 
            ptime_disliked.HeaderText = "Срок";
            ptime_disliked.MinimumWidth = 6;
            ptime_disliked.Name = "ptime_disliked";
            ptime_disliked.Width = 125;
            // 
            // planguage_disliked
            // 
            planguage_disliked.HeaderText = "Знание языков";
            planguage_disliked.MinimumWidth = 6;
            planguage_disliked.Name = "planguage_disliked";
            planguage_disliked.Width = 125;
            // 
            // pExperience_disliked
            // 
            pExperience_disliked.HeaderText = "Опыт";
            pExperience_disliked.MinimumWidth = 6;
            pExperience_disliked.Name = "pExperience_disliked";
            pExperience_disliked.Width = 125;
            // 
            // pproduct_disliked
            // 
            pproduct_disliked.HeaderText = "Продукт";
            pproduct_disliked.MinimumWidth = 6;
            pproduct_disliked.Name = "pproduct_disliked";
            pproduct_disliked.Width = 125;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(681, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(396, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(681, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(419, -80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(797, -105);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(245, 306);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // disliked_lbl
            // 
            disliked_lbl.AutoSize = true;
            disliked_lbl.BorderStyle = BorderStyle.FixedSingle;
            disliked_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            disliked_lbl.Location = new Point(0, 106);
            disliked_lbl.Name = "disliked_lbl";
            disliked_lbl.Size = new Size(103, 28);
            disliked_lbl.TabIndex = 17;
            disliked_lbl.Text = "Скрытое";
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(0, 0);
            exit_btn.Margin = new Padding(3, 2, 3, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(40, 46);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 29;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Dislikedperformers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(980, 533);
            Controls.Add(exit_btn);
            Controls.Add(disliked_lbl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(disliked_dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dislikedperformers";
            Text = "Скрытое";
            Load += Dislikedperformers_Load_1;
            ((System.ComponentModel.ISupportInitialize)disliked_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView disliked_dgv;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label disliked_lbl;
        private PictureBox exit_btn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname_disliked;
        private DataGridViewTextBoxColumn pspecialisation_disliked;
        private DataGridViewTextBoxColumn ptime_disliked;
        private DataGridViewTextBoxColumn planguage_disliked;
        private DataGridViewTextBoxColumn pExperience_disliked;
        private DataGridViewTextBoxColumn pproduct_disliked;
    }
}