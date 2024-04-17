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
            pname = new DataGridViewTextBoxColumn();
            pspecialisation = new DataGridViewTextBoxColumn();
            ptime = new DataGridViewTextBoxColumn();
            pprice = new DataGridViewTextBoxColumn();
            pExperience = new DataGridViewTextBoxColumn();
            prating = new DataGridViewTextBoxColumn();
            liked_lbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)liked_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // liked_dgv
            // 
            dataGridViewCellStyle1.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            liked_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            liked_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            liked_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            liked_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            liked_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname, pspecialisation, ptime, pprice, pExperience, prating });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            liked_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            liked_dgv.GridColor = Color.DarkSeaGreen;
            liked_dgv.Location = new Point(-1, 200);
            liked_dgv.Name = "liked_dgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            liked_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            liked_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            liked_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            liked_dgv.Size = new Size(750, 514);
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
            // pname
            // 
            pname.HeaderText = "ФИО";
            pname.MinimumWidth = 6;
            pname.Name = "pname";
            pname.Width = 125;
            // 
            // pspecialisation
            // 
            pspecialisation.HeaderText = "Специализация";
            pspecialisation.MinimumWidth = 6;
            pspecialisation.Name = "pspecialisation";
            pspecialisation.Width = 125;
            // 
            // ptime
            // 
            ptime.HeaderText = "Срок";
            ptime.MinimumWidth = 6;
            ptime.Name = "ptime";
            ptime.Width = 125;
            // 
            // pprice
            // 
            pprice.HeaderText = "Цена";
            pprice.MinimumWidth = 6;
            pprice.Name = "pprice";
            pprice.Width = 125;
            // 
            // pExperience
            // 
            pExperience.HeaderText = "Опыт";
            pExperience.MinimumWidth = 6;
            pExperience.Name = "pExperience";
            pExperience.Width = 125;
            // 
            // prating
            // 
            prating.HeaderText = "Рейтинг";
            prating.MinimumWidth = 6;
            prating.Name = "prating";
            prating.Width = 125;
            // 
            // liked_lbl
            // 
            liked_lbl.AutoSize = true;
            liked_lbl.BorderStyle = BorderStyle.FixedSingle;
            liked_lbl.Font = new Font("Didact Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            liked_lbl.Location = new Point(-1, 124);
            liked_lbl.Name = "liked_lbl";
            liked_lbl.Size = new Size(159, 42);
            liked_lbl.TabIndex = 1;
            liked_lbl.Text = "Избранное";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, -116);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(784, 143);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(784, 436);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(452, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(917, -150);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(280, 408);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // likedperformers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 711);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(liked_lbl);
            Controls.Add(liked_dgv);
            Controls.Add(pictureBox4);
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "likedperformers";
            Text = "Избранное";
            Load += likedperformers_Load;
            ((System.ComponentModel.ISupportInitialize)liked_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label liked_lbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pspecialisation;
        private DataGridViewTextBoxColumn ptime;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn pExperience;
        private DataGridViewTextBoxColumn prating;
        internal DataGridView liked_dgv;
    }
}