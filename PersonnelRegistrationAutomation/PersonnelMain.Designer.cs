
namespace PersonnelRegistrationAutomation
{
    partial class PersonnelMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelMain));
            this.GrpTransactions = new System.Windows.Forms.GroupBox();
            this.BtnGraphic = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.GrbPersonnel = new System.Windows.Forms.GroupBox();
            this.CombCity = new System.Windows.Forms.ComboBox();
            this.RdUnmarried = new System.Windows.Forms.RadioButton();
            this.RdMarried = new System.Windows.Forms.RadioButton();
            this.TxtVocation = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Lblid = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVerıTabanıDataSet = new PersonnelRegistrationAutomation.PersonelVerıTabanıDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new PersonnelRegistrationAutomation.PersonelVerıTabanıDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.GrpTransactions.SuspendLayout();
            this.GrbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVerıTabanıDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpTransactions
            // 
            this.GrpTransactions.BackColor = System.Drawing.Color.Transparent;
            this.GrpTransactions.Controls.Add(this.BtnGraphic);
            this.GrpTransactions.Controls.Add(this.BtnStatistics);
            this.GrpTransactions.Controls.Add(this.BtnList);
            this.GrpTransactions.Controls.Add(this.BtnSave);
            this.GrpTransactions.Controls.Add(this.BtnClear);
            this.GrpTransactions.Controls.Add(this.BtnDelete);
            this.GrpTransactions.Controls.Add(this.BtnUpdate);
            this.GrpTransactions.Location = new System.Drawing.Point(448, 13);
            this.GrpTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.GrpTransactions.Name = "GrpTransactions";
            this.GrpTransactions.Padding = new System.Windows.Forms.Padding(4);
            this.GrpTransactions.Size = new System.Drawing.Size(264, 451);
            this.GrpTransactions.TabIndex = 0;
            this.GrpTransactions.TabStop = false;
            this.GrpTransactions.Text = "Transactions";
            // 
            // BtnGraphic
            // 
            this.BtnGraphic.Location = new System.Drawing.Point(28, 385);
            this.BtnGraphic.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGraphic.Name = "BtnGraphic";
            this.BtnGraphic.Size = new System.Drawing.Size(210, 50);
            this.BtnGraphic.TabIndex = 6;
            this.BtnGraphic.Text = "Graphics";
            this.BtnGraphic.UseVisualStyleBackColor = true;
            this.BtnGraphic.Click += new System.EventHandler(this.BtnGraphic_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.Location = new System.Drawing.Point(28, 327);
            this.BtnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(210, 50);
            this.BtnStatistics.TabIndex = 5;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.UseVisualStyleBackColor = true;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(28, 37);
            this.BtnList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(210, 50);
            this.BtnList.TabIndex = 0;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(28, 95);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(210, 50);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(28, 153);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(210, 50);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(28, 211);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(210, 50);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(28, 269);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(210, 50);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // GrbPersonnel
            // 
            this.GrbPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.GrbPersonnel.Controls.Add(this.CombCity);
            this.GrbPersonnel.Controls.Add(this.RdUnmarried);
            this.GrbPersonnel.Controls.Add(this.RdMarried);
            this.GrbPersonnel.Controls.Add(this.TxtVocation);
            this.GrbPersonnel.Controls.Add(this.TxtId);
            this.GrbPersonnel.Controls.Add(this.Lblid);
            this.GrbPersonnel.Controls.Add(this.TxtSalary);
            this.GrbPersonnel.Controls.Add(this.TxtSurname);
            this.GrbPersonnel.Controls.Add(this.TxtName);
            this.GrbPersonnel.Controls.Add(this.label7);
            this.GrbPersonnel.Controls.Add(this.label6);
            this.GrbPersonnel.Controls.Add(this.label4);
            this.GrbPersonnel.Controls.Add(this.label3);
            this.GrbPersonnel.Controls.Add(this.label2);
            this.GrbPersonnel.Controls.Add(this.label1);
            this.GrbPersonnel.Location = new System.Drawing.Point(0, 0);
            this.GrbPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.GrbPersonnel.Name = "GrbPersonnel";
            this.GrbPersonnel.Padding = new System.Windows.Forms.Padding(4);
            this.GrbPersonnel.Size = new System.Drawing.Size(440, 451);
            this.GrbPersonnel.TabIndex = 1;
            this.GrbPersonnel.TabStop = false;
            this.GrbPersonnel.Text = "Personnel ";
            // 
            // CombCity
            // 
            this.CombCity.FormattingEnabled = true;
            this.CombCity.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.CombCity.Location = new System.Drawing.Point(150, 214);
            this.CombCity.Name = "CombCity";
            this.CombCity.Size = new System.Drawing.Size(215, 36);
            this.CombCity.TabIndex = 15;
            // 
            // RdUnmarried
            // 
            this.RdUnmarried.AutoSize = true;
            this.RdUnmarried.Location = new System.Drawing.Point(263, 396);
            this.RdUnmarried.Name = "RdUnmarried";
            this.RdUnmarried.Size = new System.Drawing.Size(142, 33);
            this.RdUnmarried.TabIndex = 14;
            this.RdUnmarried.TabStop = true;
            this.RdUnmarried.Text = "Unmarried";
            this.RdUnmarried.UseVisualStyleBackColor = true;
            this.RdUnmarried.CheckedChanged += new System.EventHandler(this.RdUnmarried_CheckedChanged);
            // 
            // RdMarried
            // 
            this.RdMarried.AutoSize = true;
            this.RdMarried.Location = new System.Drawing.Point(150, 396);
            this.RdMarried.Name = "RdMarried";
            this.RdMarried.Size = new System.Drawing.Size(113, 33);
            this.RdMarried.TabIndex = 13;
            this.RdMarried.TabStop = true;
            this.RdMarried.Text = "Married";
            this.RdMarried.UseVisualStyleBackColor = true;
            this.RdMarried.CheckedChanged += new System.EventHandler(this.RdMarried_CheckedChanged_1);
            // 
            // TxtVocation
            // 
            this.TxtVocation.Location = new System.Drawing.Point(150, 338);
            this.TxtVocation.Name = "TxtVocation";
            this.TxtVocation.Size = new System.Drawing.Size(215, 36);
            this.TxtVocation.TabIndex = 12;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(150, 45);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(215, 36);
            this.TxtId.TabIndex = 7;
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.Location = new System.Drawing.Point(111, 48);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(32, 29);
            this.Lblid.TabIndex = 4;
            this.Lblid.Text = "Id";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(150, 272);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(125, 36);
            this.TxtSalary.TabIndex = 11;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(150, 158);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(215, 36);
            this.TxtSurname.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(150, 100);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(215, 36);
            this.TxtName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vocation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVerıTabanıDataSet;
            // 
            // personelVerıTabanıDataSet
            // 
            this.personelVerıTabanıDataSet.DataSetName = "PersonelVerıTabanıDataSet";
            this.personelVerıTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 483);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1170, 248);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personnel List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // PersonnelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrbPersonnel);
            this.Controls.Add(this.GrpTransactions);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Name = "PersonnelMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonnelMain_FormClosed);
            this.Load += new System.EventHandler(this.PersonnelMain_Load);
            this.GrpTransactions.ResumeLayout(false);
            this.GrbPersonnel.ResumeLayout(false);
            this.GrbPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVerıTabanıDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpTransactions;
        private System.Windows.Forms.GroupBox GrbPersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnGraphic;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.RadioButton RdUnmarried;
        private System.Windows.Forms.RadioButton RdMarried;
        private System.Windows.Forms.TextBox TxtVocation;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lblid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVerıTabanıDataSet personelVerıTabanıDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVerıTabanıDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CombCity;
    }
}

