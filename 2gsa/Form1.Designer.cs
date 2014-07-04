namespace _2gsa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adiSoyadiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bolumCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epostaTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adminNameLBL = new System.Windows.Forms.Label();
            this.standnameLBL = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.telefonNoTB = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.internetText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraalindimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katilimciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esoguieeeDataSet3 = new _2gsa.esoguieeeDataSet3();
            this.katilimciTableAdapter = new _2gsa.esoguieeeDataSet3TableAdapters.katilimciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katilimciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esoguieeeDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // adiSoyadiTB
            // 
            this.adiSoyadiTB.Location = new System.Drawing.Point(96, 119);
            this.adiSoyadiTB.Name = "adiSoyadiTB";
            this.adiSoyadiTB.Size = new System.Drawing.Size(172, 20);
            this.adiSoyadiTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm";
            // 
            // bolumCB
            // 
            this.bolumCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bolumCB.FormattingEnabled = true;
            this.bolumCB.Items.AddRange(new object[] {
            "Elektrik-Elektronik Mühendisliği",
            "Bilgisayar Mühendisliği",
            "Makina Mühendisliği",
            "Kimya Mühendisliği",
            "Endüstri Mühendisliği",
            "Maden Mühendisliği",
            "İnşaat Mühendisliği",
            "Metalürji ve Malzeme Mühendisliği",
            "Uluslararası İlişkiler",
            "Mimarlık",
            "Diğer"});
            this.bolumCB.Location = new System.Drawing.Point(96, 151);
            this.bolumCB.Name = "bolumCB";
            this.bolumCB.Size = new System.Drawing.Size(172, 21);
            this.bolumCB.TabIndex = 5;
            this.bolumCB.SelectedIndexChanged += new System.EventHandler(this.bolumCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-Posta";
            // 
            // epostaTB
            // 
            this.epostaTB.Location = new System.Drawing.Point(96, 219);
            this.epostaTB.Name = "epostaTB";
            this.epostaTB.Size = new System.Drawing.Size(172, 20);
            this.epostaTB.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Girilen Kayıtlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yeni Katılımcı Ekleme Paneli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hoşgeldiniz!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(822, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Çıkış yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(741, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Üye Listesi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminNameLBL
            // 
            this.adminNameLBL.AutoSize = true;
            this.adminNameLBL.Location = new System.Drawing.Point(12, 26);
            this.adminNameLBL.Name = "adminNameLBL";
            this.adminNameLBL.Size = new System.Drawing.Size(0, 13);
            this.adminNameLBL.TabIndex = 22;
            // 
            // standnameLBL
            // 
            this.standnameLBL.AutoSize = true;
            this.standnameLBL.Location = new System.Drawing.Point(15, 48);
            this.standnameLBL.Name = "standnameLBL";
            this.standnameLBL.Size = new System.Drawing.Size(0, 13);
            this.standnameLBL.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(821, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Yenile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // telefonNoTB
            // 
            this.telefonNoTB.Location = new System.Drawing.Point(96, 186);
            this.telefonNoTB.Mask = "(999) 000 00 00";
            this.telefonNoTB.Name = "telefonNoTB";
            this.telefonNoTB.Size = new System.Drawing.Size(172, 20);
            this.telefonNoTB.TabIndex = 26;
            // 
            // internetText
            // 
            this.internetText.AutoSize = true;
            this.internetText.Location = new System.Drawing.Point(496, 14);
            this.internetText.Name = "internetText";
            this.internetText.Size = new System.Drawing.Size(0, 13);
            this.internetText.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siraDataGridViewTextBoxColumn,
            this.adisoyadiDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.paraalindimiDataGridViewTextBoxColumn,
            this.adminnameDataGridViewTextBoxColumn,
            this.standDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.katilimciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(274, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 400);
            this.dataGridView1.TabIndex = 28;
            // 
            // siraDataGridViewTextBoxColumn
            // 
            this.siraDataGridViewTextBoxColumn.DataPropertyName = "sira";
            this.siraDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.siraDataGridViewTextBoxColumn.Name = "siraDataGridViewTextBoxColumn";
            this.siraDataGridViewTextBoxColumn.Width = 30;
            // 
            // adisoyadiDataGridViewTextBoxColumn
            // 
            this.adisoyadiDataGridViewTextBoxColumn.DataPropertyName = "adisoyadi";
            this.adisoyadiDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.adisoyadiDataGridViewTextBoxColumn.Name = "adisoyadiDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefonno";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "Telefon No.";
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // paraalindimiDataGridViewTextBoxColumn
            // 
            this.paraalindimiDataGridViewTextBoxColumn.DataPropertyName = "paraalindimi";
            this.paraalindimiDataGridViewTextBoxColumn.HeaderText = "Para alındı mı?";
            this.paraalindimiDataGridViewTextBoxColumn.Name = "paraalindimiDataGridViewTextBoxColumn";
            // 
            // adminnameDataGridViewTextBoxColumn
            // 
            this.adminnameDataGridViewTextBoxColumn.DataPropertyName = "adminname";
            this.adminnameDataGridViewTextBoxColumn.HeaderText = "Giriş Yapan";
            this.adminnameDataGridViewTextBoxColumn.Name = "adminnameDataGridViewTextBoxColumn";
            // 
            // standDataGridViewTextBoxColumn
            // 
            this.standDataGridViewTextBoxColumn.DataPropertyName = "stand";
            this.standDataGridViewTextBoxColumn.HeaderText = "Stand";
            this.standDataGridViewTextBoxColumn.Name = "standDataGridViewTextBoxColumn";
            // 
            // katilimciBindingSource
            // 
            this.katilimciBindingSource.DataMember = "katilimci";
            this.katilimciBindingSource.DataSource = this.esoguieeeDataSet3;
            // 
            // esoguieeeDataSet3
            // 
            this.esoguieeeDataSet3.DataSetName = "esoguieeeDataSet3";
            this.esoguieeeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katilimciTableAdapter
            // 
            this.katilimciTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.internetText);
            this.Controls.Add(this.telefonNoTB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.standnameLBL);
            this.Controls.Add(this.adminNameLBL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.epostaTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bolumCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adiSoyadiTB);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 Günde Şirket-i Alem Katılımcı Kayıt Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katilimciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esoguieeeDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox adiSoyadiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bolumCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epostaTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label adminNameLBL;
        private System.Windows.Forms.Label standnameLBL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox telefonNoTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label internetText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private esoguieeeDataSet3 esoguieeeDataSet3;
        private System.Windows.Forms.BindingSource katilimciBindingSource;
        private esoguieeeDataSet3TableAdapters.katilimciTableAdapter katilimciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraalindimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standDataGridViewTextBoxColumn;
    }
}

