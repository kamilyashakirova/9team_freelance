namespace freelance.forms
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
            pname = new DataGridViewTextBoxColumn();
            pspecialisation = new DataGridViewTextBoxColumn();
            ptime = new DataGridViewTextBoxColumn();
            planguage = new DataGridViewTextBoxColumn();
            pExperience = new DataGridViewTextBoxColumn();
            pproduct = new DataGridViewTextBoxColumn();
            addservice_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            updatedgv_pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)myservices_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updatedgv_pic).BeginInit();
            SuspendLayout();
            // 
            // myservices_dgv
            // 
            myservices_dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            myservices_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            myservices_dgv.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            myservices_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            myservices_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myservices_dgv.Columns.AddRange(new DataGridViewColumn[] { ID, pname, pspecialisation, ptime, planguage, pExperience, pproduct });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Didact Gothic", 10.1999989F);
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
            dataGridViewCellStyle4.Font = new Font("Didact Gothic", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            myservices_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            myservices_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Didact Gothic", 10.1999989F);
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
            // planguage
            // 
            planguage.HeaderText = "Знание языков";
            planguage.MinimumWidth = 6;
            planguage.Name = "planguage";
            planguage.Width = 125;
            // 
            // pExperience
            // 
            pExperience.HeaderText = "Опыт";
            pExperience.MinimumWidth = 6;
            pExperience.Name = "pExperience";
            pExperience.Width = 125;
            // 
            // pproduct
            // 
            pproduct.HeaderText = "Продукт";
            pproduct.MinimumWidth = 6;
            pproduct.Name = "pproduct";
            pproduct.Width = 125;
            // 
            // addservice_btn
            // 
            addservice_btn.BackColor = Color.LightBlue;
            addservice_btn.Font = new Font("Didact Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addservice_btn.Location = new Point(842, 620);
            addservice_btn.Name = "addservice_btn";
            addservice_btn.Size = new Size(296, 78);
            addservice_btn.TabIndex = 3;
            addservice_btn.Text = "Создать объявление";
            addservice_btn.UseVisualStyleBackColor = false;
            addservice_btn.Click += addservice_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Didact Gothic", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 152);
            label1.Name = "label1";
            label1.Size = new Size(175, 43);
            label1.TabIndex = 4;
            label1.Text = "Мои заказы";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // updatedgv_pic
            // 
            updatedgv_pic.Image = (Image)resources.GetObject("updatedgv_pic.Image");
            updatedgv_pic.Location = new Point(0, 1);
            updatedgv_pic.Name = "updatedgv_pic";
            updatedgv_pic.Size = new Size(89, 71);
            updatedgv_pic.SizeMode = PictureBoxSizeMode.Zoom;
            updatedgv_pic.TabIndex = 26;
            updatedgv_pic.TabStop = false;
            updatedgv_pic.Click += updatedgv_pic_Click;
            // 
            // Myservices
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1194, 744);
            Controls.Add(updatedgv_pic);
            Controls.Add(label1);
            Controls.Add(addservice_btn);
            Controls.Add(myservices_dgv);
            Controls.Add(pictureBox1);
            Font = new Font("Didact Gothic", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Myservices";
            Text = "Мои заказы";
            Load += Myservices_Load;
            ((System.ComponentModel.ISupportInitialize)myservices_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)updatedgv_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView myservices_dgv;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pspecialisation;
        private DataGridViewTextBoxColumn ptime;
        private DataGridViewTextBoxColumn planguage;
        private DataGridViewTextBoxColumn pExperience;
        private DataGridViewTextBoxColumn pproduct;
        private Button addservice_btn;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox updatedgv_pic;
    }
}