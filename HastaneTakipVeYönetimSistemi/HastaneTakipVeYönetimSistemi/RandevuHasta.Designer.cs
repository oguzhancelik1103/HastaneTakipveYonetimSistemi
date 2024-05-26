namespace HastaneTakipVeYönetimSistemi
{
    partial class RandevuHasta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDoktorlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeRandevu = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.hastaneDatabaseDataSet = new HastaneTakipVeYönetimSistemi.HastaneDatabaseDataSet();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new HastaneTakipVeYönetimSistemi.HastaneDatabaseDataSetTableAdapters.RandevularTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.txtsikayet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randevuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 342);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hasta Bilgileri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tıbbi Raporlar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Randevu İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(213, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Randevu Almak İstediğiniz Doktoru Seçiniz :";
            // 
            // comboBoxDoktorlar
            // 
            this.comboBoxDoktorlar.FormattingEnabled = true;
            this.comboBoxDoktorlar.Location = new System.Drawing.Point(500, 81);
            this.comboBoxDoktorlar.Name = "comboBoxDoktorlar";
            this.comboBoxDoktorlar.Size = new System.Drawing.Size(265, 24);
            this.comboBoxDoktorlar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(319, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Randevu Tarihini Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(322, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Randevu Saatini Seçiniz :";
            // 
            // dateTimeRandevu
            // 
            this.dateTimeRandevu.CustomFormat = "yyyy-MM-dd";
            this.dateTimeRandevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRandevu.Location = new System.Drawing.Point(500, 118);
            this.dateTimeRandevu.Name = "dateTimeRandevu";
            this.dateTimeRandevu.Size = new System.Drawing.Size(121, 22);
            this.dateTimeRandevu.TabIndex = 8;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.comboBoxSaat.Location = new System.Drawing.Point(500, 153);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(265, 24);
            this.comboBoxSaat.TabIndex = 9;
            this.comboBoxSaat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(631, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "Randevu Oluştur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // hastaneDatabaseDataSet
            // 
            this.hastaneDatabaseDataSet.DataSetName = "HastaneDatabaseDataSet";
            this.hastaneDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hastaneDatabaseDataSet;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuIDDataGridViewTextBoxColumn,
            this.Tarih,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.doktorIDDataGridViewTextBoxColumn,
            this.hastaIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(631, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 29);
            this.button6.TabIndex = 12;
            this.button6.Text = "Randevu İptal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtsikayet
            // 
            this.txtsikayet.Location = new System.Drawing.Point(500, 190);
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(249, 22);
            this.txtsikayet.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(422, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şikayet :";
            // 
            // randevuIDDataGridViewTextBoxColumn
            // 
            this.randevuIDDataGridViewTextBoxColumn.DataPropertyName = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.HeaderText = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuIDDataGridViewTextBoxColumn.Name = "randevuIDDataGridViewTextBoxColumn";
            this.randevuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuIDDataGridViewTextBoxColumn.Visible = false;
            this.randevuIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "RandevuTarih";
            this.Tarih.HeaderText = "RandevuTarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 125;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            this.doktorIDDataGridViewTextBoxColumn.Visible = false;
            this.doktorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "HastaID";
            this.hastaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            this.hastaIDDataGridViewTextBoxColumn.Visible = false;
            this.hastaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // RandevuHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsikayet);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBoxSaat);
            this.Controls.Add(this.dateTimeRandevu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDoktorlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RandevuHasta";
            this.Text = "RandevuHasta";
            this.Load += new System.EventHandler(this.RandevuHasta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDoktorlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeRandevu;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.Button button5;
        private HastaneDatabaseDataSet hastaneDatabaseDataSet;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private HastaneDatabaseDataSetTableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtsikayet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
    }
}