namespace RESPONSI_483121
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txtNama = new TextBox();
            txtDepartemen = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoaddata = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 34);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 174);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan : ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(328, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 177);
            panel1.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(129, 114);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(165, 23);
            txtNama.TabIndex = 5;
            txtNama.Text = "Field";
            // 
            // txtDepartemen
            // 
            txtDepartemen.Location = new Point(129, 166);
            txtDepartemen.Name = "txtDepartemen";
            txtDepartemen.Size = new Size(165, 23);
            txtDepartemen.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(23, 227);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(107, 23);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(187, 227);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(353, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(23, 277);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(437, 187);
            dgvData.TabIndex = 10;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoaddata
            // 
            btnLoaddata.Location = new Point(353, 483);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(107, 23);
            btnLoaddata.TabIndex = 11;
            btnLoaddata.Text = "Load data";
            btnLoaddata.UseVisualStyleBackColor = true;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 22);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 12;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 45);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "HR: HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 74);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 14;
            label6.Text = "ENG = Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 102);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 15;
            label7.Text = "DEV = Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 130);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 16;
            label8.Text = "PM = Product M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 154);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 17;
            label9.Text = "FIN = Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 518);
            Controls.Add(btnLoaddata);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(txtDepartemen);
            Controls.Add(txtNama);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox txtNama;
        private TextBox txtDepartemen;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoaddata;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}