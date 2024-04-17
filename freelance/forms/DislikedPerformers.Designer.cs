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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dislikedperformers));
            disliked_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname = new DataGridViewTextBoxColumn();
            pspecialisation = new DataGridViewTextBoxColumn();
            ptime = new DataGridViewTextBoxColumn();
            pprice = new DataGridViewTextBoxColumn();
            pExperience = new DataGridViewTextBoxColumn();
            prating = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            disliked_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)disliked_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // disliked_dgv
            // 
            dataGridViewCellStyle6.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            disliked_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            disliked_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            disliked_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            disliked_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            disliked_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname, pspecialisation, ptime, pprice, pExperience, prating });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            disliked_dgv.DefaultCellStyle = dataGridViewCellStyle8;
            disliked_dgv.GridColor = Color.DarkSeaGreen;
            disliked_dgv.Location = new Point(0, 200);
            disliked_dgv.Name = "disliked_dgv";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            disliked_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            disliked_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            disliked_dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            disliked_dgv.Size = new Size(750, 514);
            disliked_dgv.TabIndex = 1;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(778, 446);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(452, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(778, 153);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, -106);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(911, -140);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(280, 408);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // disliked_lbl
            // 
            disliked_lbl.AutoSize = true;
            disliked_lbl.BorderStyle = BorderStyle.FixedSingle;
            disliked_lbl.Font = new Font("Didact Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            disliked_lbl.Location = new Point(0, 141);
            disliked_lbl.Name = "disliked_lbl";
            disliked_lbl.Size = new Size(126, 42);
            disliked_lbl.TabIndex = 17;
            disliked_lbl.Text = "Скрытое";
            // 
            // Dislikedperformers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1120, 711);
            Controls.Add(disliked_lbl);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(disliked_dgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dislikedperformers";
            Text = "Скрытое";
            ((System.ComponentModel.ISupportInitialize)disliked_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView disliked_dgv;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pspecialisation;
        private DataGridViewTextBoxColumn ptime;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn pExperience;
        private DataGridViewTextBoxColumn prating;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label disliked_lbl;
    }
}