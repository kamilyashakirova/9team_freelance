﻿namespace freelance.forms
{
    partial class Myservices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myservices));
            myservices_dgv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            pname_my = new DataGridViewTextBoxColumn();
            pspecialisation_my = new DataGridViewTextBoxColumn();
            ptime_my = new DataGridViewTextBoxColumn();
            planguage_my = new DataGridViewTextBoxColumn();
            pExperience_my = new DataGridViewTextBoxColumn();
            pproduct_my = new DataGridViewTextBoxColumn();
            addservice_btn = new Button();
            myservices_lbl = new Label();
            pictureBox1 = new PictureBox();
            updatedgv_pic = new PictureBox();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)myservices_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updatedgv_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // myservices_dgv
            // 
            myservices_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            myservices_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            myservices_dgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            myservices_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            myservices_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            myservices_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myservices_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname_my, pspecialisation_my, ptime_my, planguage_my, pExperience_my, pproduct_my });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            myservices_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            myservices_dgv.GridColor = Color.DarkSeaGreen;
            myservices_dgv.Location = new Point(0, 198);
            myservices_dgv.Name = "myservices_dgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            myservices_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            myservices_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.1999989F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            myservices_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            myservices_dgv.Size = new Size(680, 545);
            myservices_dgv.TabIndex = 2;
            myservices_dgv.CellDoubleClick += myservices_dgv_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // pname_my
            // 
            pname_my.HeaderText = "ФИО";
            pname_my.MinimumWidth = 6;
            pname_my.Name = "pname_my";
            pname_my.Width = 125;
            // 
            // pspecialisation_my
            // 
            pspecialisation_my.HeaderText = "Специализация";
            pspecialisation_my.MinimumWidth = 6;
            pspecialisation_my.Name = "pspecialisation_my";
            pspecialisation_my.Width = 125;
            // 
            // ptime_my
            // 
            ptime_my.HeaderText = "Срок";
            ptime_my.MinimumWidth = 6;
            ptime_my.Name = "ptime_my";
            ptime_my.Width = 125;
            // 
            // planguage_my
            // 
            planguage_my.HeaderText = "Знание языков";
            planguage_my.MinimumWidth = 6;
            planguage_my.Name = "planguage_my";
            planguage_my.Width = 125;
            // 
            // pExperience_my
            // 
            pExperience_my.HeaderText = "Опыт";
            pExperience_my.MinimumWidth = 6;
            pExperience_my.Name = "pExperience_my";
            pExperience_my.Width = 125;
            // 
            // pproduct_my
            // 
            pproduct_my.HeaderText = "Продукт";
            pproduct_my.MinimumWidth = 6;
            pproduct_my.Name = "pproduct_my";
            pproduct_my.Width = 125;
            // 
            // addservice_btn
            // 
            addservice_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addservice_btn.BackColor = Color.LightBlue;
            addservice_btn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addservice_btn.Location = new Point(842, 620);
            addservice_btn.Name = "addservice_btn";
            addservice_btn.Size = new Size(296, 78);
            addservice_btn.TabIndex = 3;
            addservice_btn.Text = "Создать объявление";
            addservice_btn.UseVisualStyleBackColor = false;
            addservice_btn.Click += addservice_btn_Click;
            // 
            // myservices_lbl
            // 
            myservices_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            myservices_lbl.AutoSize = true;
            myservices_lbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            myservices_lbl.Location = new Point(0, 152);
            myservices_lbl.Name = "myservices_lbl";
            myservices_lbl.Size = new Size(149, 29);
            myservices_lbl.TabIndex = 4;
            myservices_lbl.Text = "Мои заказы";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 1);
            pictureBox1.MinimumSize = new Size(400, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // updatedgv_pic
            // 
            updatedgv_pic.Image = (Image)resources.GetObject("updatedgv_pic.Image");
            updatedgv_pic.Location = new Point(58, 1);
            updatedgv_pic.Name = "updatedgv_pic";
            updatedgv_pic.Size = new Size(89, 71);
            updatedgv_pic.SizeMode = PictureBoxSizeMode.Zoom;
            updatedgv_pic.TabIndex = 26;
            updatedgv_pic.TabStop = false;
            updatedgv_pic.Click += updatedgv_pic_Click;
            // 
            // exit_btn
            // 
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.Location = new Point(0, 1);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(52, 71);
            exit_btn.SizeMode = PictureBoxSizeMode.Zoom;
            exit_btn.TabIndex = 27;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Myservices
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1194, 744);
            Controls.Add(exit_btn);
            Controls.Add(updatedgv_pic);
            Controls.Add(myservices_lbl);
            Controls.Add(addservice_btn);
            Controls.Add(myservices_dgv);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Myservices";
            Text = "Мои заказы";
            Load += Myservices_Load;
            ((System.ComponentModel.ISupportInitialize)myservices_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)updatedgv_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView myservices_dgv;
        private Button addservice_btn;
        private Label myservices_lbl;
        private PictureBox pictureBox1;
        private PictureBox updatedgv_pic;
        private PictureBox exit_btn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname_my;
        private DataGridViewTextBoxColumn pspecialisation_my;
        private DataGridViewTextBoxColumn ptime_my;
        private DataGridViewTextBoxColumn planguage_my;
        private DataGridViewTextBoxColumn pExperience_my;
        private DataGridViewTextBoxColumn pproduct_my;
    }
}