namespace BankaNumaratör
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            btnSiraAl = new Button();
            txtTCNo = new TextBox();
            label3 = new Label();
            lblYapilanIslem = new Label();
            groupBox1 = new GroupBox();
            dgvSıradakiler = new DataGridView();
            label7 = new Label();
            groupBox2 = new GroupBox();
            lblGiseIslemSayisi = new Label();
            lblBireyselIslemSayisi = new Label();
            lblVipIslemSayisi = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSıradakiler).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 0;
            label1.Text = "Bankamıza Hoşgeldiniz!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 82);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "-------- Lütfen Sıra Alınız! --------";
            // 
            // btnSiraAl
            // 
            btnSiraAl.Location = new Point(153, 160);
            btnSiraAl.Name = "btnSiraAl";
            btnSiraAl.Size = new Size(94, 29);
            btnSiraAl.TabIndex = 2;
            btnSiraAl.Text = "SIRA AL";
            btnSiraAl.UseVisualStyleBackColor = true;
            btnSiraAl.Click += btnSiraAl_Click;
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(153, 127);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(209, 27);
            txtTCNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "T.C. No:";
            // 
            // lblYapilanIslem
            // 
            lblYapilanIslem.AutoSize = true;
            lblYapilanIslem.BorderStyle = BorderStyle.FixedSingle;
            lblYapilanIslem.Location = new Point(13, 48);
            lblYapilanIslem.Name = "lblYapilanIslem";
            lblYapilanIslem.Size = new Size(27, 22);
            lblYapilanIslem.TabIndex = 5;
            lblYapilanIslem.Text = "    ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblYapilanIslem);
            groupBox1.Location = new Point(632, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 178);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gişe";
            // 
            // dgvSıradakiler
            // 
            dgvSıradakiler.AllowUserToAddRows = false;
            dgvSıradakiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSıradakiler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvSıradakiler.Location = new Point(21, 241);
            dgvSıradakiler.MultiSelect = false;
            dgvSıradakiler.Name = "dgvSıradakiler";
            dgvSıradakiler.ReadOnly = true;
            dgvSıradakiler.RowHeadersWidth = 51;
            dgvSıradakiler.RowTemplate.Height = 29;
            dgvSıradakiler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSıradakiler.Size = new Size(556, 223);
            dgvSıradakiler.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 213);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 10;
            label7.Text = "SIRA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblGiseIslemSayisi);
            groupBox2.Controls.Add(lblBireyselIslemSayisi);
            groupBox2.Controls.Add(lblVipIslemSayisi);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(632, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 180);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yapılan İşlem Sayısı";
            // 
            // lblGiseIslemSayisi
            // 
            lblGiseIslemSayisi.AutoSize = true;
            lblGiseIslemSayisi.BorderStyle = BorderStyle.FixedSingle;
            lblGiseIslemSayisi.Location = new Point(137, 105);
            lblGiseIslemSayisi.Name = "lblGiseIslemSayisi";
            lblGiseIslemSayisi.Size = new Size(19, 22);
            lblGiseIslemSayisi.TabIndex = 13;
            lblGiseIslemSayisi.Text = "0";
            // 
            // lblBireyselIslemSayisi
            // 
            lblBireyselIslemSayisi.AutoSize = true;
            lblBireyselIslemSayisi.BorderStyle = BorderStyle.FixedSingle;
            lblBireyselIslemSayisi.Location = new Point(137, 74);
            lblBireyselIslemSayisi.Name = "lblBireyselIslemSayisi";
            lblBireyselIslemSayisi.Size = new Size(19, 22);
            lblBireyselIslemSayisi.TabIndex = 12;
            lblBireyselIslemSayisi.Text = "0";
            // 
            // lblVipIslemSayisi
            // 
            lblVipIslemSayisi.AutoSize = true;
            lblVipIslemSayisi.BorderStyle = BorderStyle.FixedSingle;
            lblVipIslemSayisi.Location = new Point(137, 42);
            lblVipIslemSayisi.Name = "lblVipIslemSayisi";
            lblVipIslemSayisi.Size = new Size(19, 22);
            lblVipIslemSayisi.TabIndex = 11;
            lblVipIslemSayisi.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 74);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 9;
            label8.Text = "Bireysel İşlem";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 107);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 10;
            label9.Text = "Gişe İşlem";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 42);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 8;
            label10.Text = "VIP İşlem";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "GizliTCno";
            Column1.HeaderText = "T.C. Kimlik";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SıraNo";
            Column2.HeaderText = "Sıra No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Islem";
            Column3.HeaderText = "İşlem Türü";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "OzelSıraNo";
            Column4.HeaderText = "İşlem Sıra No ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 507);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(dgvSıradakiler);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtTCNo);
            Controls.Add(btnSiraAl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BA BANK";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSıradakiler).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSiraAl;
        private TextBox txtTCNo;
        private Label label3;
        private Label lblYapilanIslem;
        private GroupBox groupBox1;
        private DataGridView dgvSıradakiler;
        private Label label7;
        private GroupBox groupBox2;
        private Label lblGiseIslemSayisi;
        private Label lblBireyselIslemSayisi;
        private Label lblVipIslemSayisi;
        private Label label8;
        private Label label9;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}