namespace EgyenesIlleszto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hibajelzo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kiszamol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.label_yavg = new System.Windows.Forms.Label();
            this.label_xavg = new System.Windows.Forms.Label();
            this.label_prod = new System.Windows.Forms.Label();
            this.label_xsum = new System.Windows.Forms.Label();
            this.label_ysum = new System.Windows.Forms.Label();
            this.label_xsq = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_xsumsq = new System.Windows.Forms.Label();
            this.label_sumprod = new System.Windows.Forms.Label();
            this.label_beta = new System.Windows.Forms.Label();
            this.label_alpha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hibajelzo
            // 
            this.hibajelzo.AutoSize = true;
            this.hibajelzo.Location = new System.Drawing.Point(402, 30);
            this.hibajelzo.Name = "hibajelzo";
            this.hibajelzo.Size = new System.Drawing.Size(0, 13);
            this.hibajelzo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 12);
            this.dataGridView1.Size = new System.Drawing.Size(244, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ToolTipText = "Az adatsor x értékei";
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            this.y.ToolTipText = "Az adatsor y értékei";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hibajelzo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.kiszamol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox14, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox16, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox18, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_n, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_yavg, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_xavg, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_prod, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_xsum, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_ysum, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label_xsq, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox26, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox20, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label_xsumsq, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label_sumprod, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.label_beta, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label_alpha, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.n, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_error, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // kiszamol
            // 
            this.kiszamol.Location = new System.Drawing.Point(253, 3);
            this.kiszamol.Name = "kiszamol";
            this.kiszamol.Size = new System.Drawing.Size(75, 23);
            this.kiszamol.TabIndex = 6;
            this.kiszamol.Text = "Kiszámít";
            this.kiszamol.UseVisualStyleBackColor = true;
            this.kiszamol.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elemszám és átlagok";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(367, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(368, 90);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(306, 127);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(90, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(321, 159);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(75, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 19;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(322, 191);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(74, 26);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 21;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(300, 223);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(96, 26);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox16.TabIndex = 23;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(286, 255);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(110, 35);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 25;
            this.pictureBox18.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Részeredmények";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_n
            // 
            this.label_n.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(402, 51);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(13, 13);
            this.label_n.TabIndex = 45;
            this.label_n.Text = "0";
            // 
            // label_yavg
            // 
            this.label_yavg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_yavg.AutoSize = true;
            this.label_yavg.Location = new System.Drawing.Point(402, 92);
            this.label_yavg.Name = "label_yavg";
            this.label_yavg.Size = new System.Drawing.Size(13, 13);
            this.label_yavg.TabIndex = 47;
            this.label_yavg.Text = "0";
            // 
            // label_xavg
            // 
            this.label_xavg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_xavg.AutoSize = true;
            this.label_xavg.Location = new System.Drawing.Point(402, 70);
            this.label_xavg.Name = "label_xavg";
            this.label_xavg.Size = new System.Drawing.Size(13, 13);
            this.label_xavg.TabIndex = 46;
            this.label_xavg.Text = "0";
            // 
            // label_prod
            // 
            this.label_prod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_prod.AutoSize = true;
            this.label_prod.Location = new System.Drawing.Point(402, 133);
            this.label_prod.Name = "label_prod";
            this.label_prod.Size = new System.Drawing.Size(13, 13);
            this.label_prod.TabIndex = 48;
            this.label_prod.Text = "0";
            // 
            // label_xsum
            // 
            this.label_xsum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_xsum.AutoSize = true;
            this.label_xsum.Location = new System.Drawing.Point(402, 165);
            this.label_xsum.Name = "label_xsum";
            this.label_xsum.Size = new System.Drawing.Size(13, 13);
            this.label_xsum.TabIndex = 49;
            this.label_xsum.Text = "0";
            // 
            // label_ysum
            // 
            this.label_ysum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ysum.AutoSize = true;
            this.label_ysum.Location = new System.Drawing.Point(402, 197);
            this.label_ysum.Name = "label_ysum";
            this.label_ysum.Size = new System.Drawing.Size(13, 13);
            this.label_ysum.TabIndex = 50;
            this.label_ysum.Text = "0";
            // 
            // label_xsq
            // 
            this.label_xsq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_xsq.AutoSize = true;
            this.label_xsq.Location = new System.Drawing.Point(402, 229);
            this.label_xsq.Name = "label_xsq";
            this.label_xsq.Size = new System.Drawing.Size(13, 13);
            this.label_xsq.TabIndex = 51;
            this.label_xsq.Text = "0";
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(149, 415);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(98, 18);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox26.TabIndex = 40;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(12, 344);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(235, 63);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox20.TabIndex = 34;
            this.pictureBox20.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Végeredmények";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(253, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // label_xsumsq
            // 
            this.label_xsumsq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_xsumsq.AutoSize = true;
            this.label_xsumsq.Location = new System.Drawing.Point(402, 266);
            this.label_xsumsq.Name = "label_xsumsq";
            this.label_xsumsq.Size = new System.Drawing.Size(13, 13);
            this.label_xsumsq.TabIndex = 53;
            this.label_xsumsq.Text = "0";
            // 
            // label_sumprod
            // 
            this.label_sumprod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_sumprod.AutoSize = true;
            this.label_sumprod.Location = new System.Drawing.Point(402, 304);
            this.label_sumprod.Name = "label_sumprod";
            this.label_sumprod.Size = new System.Drawing.Size(13, 13);
            this.label_sumprod.TabIndex = 54;
            this.label_sumprod.Text = "0";
            // 
            // label_beta
            // 
            this.label_beta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_beta.AutoSize = true;
            this.label_beta.Location = new System.Drawing.Point(253, 369);
            this.label_beta.Name = "label_beta";
            this.label_beta.Size = new System.Drawing.Size(13, 13);
            this.label_beta.TabIndex = 55;
            this.label_beta.Text = "0";
            // 
            // label_alpha
            // 
            this.label_alpha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_alpha.AutoSize = true;
            this.label_alpha.Location = new System.Drawing.Point(253, 418);
            this.label_alpha.Name = "label_alpha";
            this.label_alpha.Size = new System.Drawing.Size(13, 13);
            this.label_alpha.TabIndex = 56;
            this.label_alpha.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 44;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(402, 111);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(0, 13);
            this.n.TabIndex = 43;
            // 
            // label_error
            // 
            this.label_error.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.label_error.AutoSize = true;
            this.label_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_error.Location = new System.Drawing.Point(402, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(87, 30);
            this.label_error.TabIndex = 57;
            this.label_error.Text = "        ";
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Regresszió számoló";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hibajelzo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button kiszamol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_xavg;
        private System.Windows.Forms.Label label_yavg;
        private System.Windows.Forms.Label label_prod;
        private System.Windows.Forms.Label label_xsum;
        private System.Windows.Forms.Label label_ysum;
        private System.Windows.Forms.Label label_xsq;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_xsumsq;
        private System.Windows.Forms.Label label_sumprod;
        private System.Windows.Forms.Label label_beta;
        private System.Windows.Forms.Label label_alpha;
        private System.Windows.Forms.Label label_error;



    }
}

