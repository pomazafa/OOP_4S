namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TypeProdBox = new System.Windows.Forms.RadioButton();
            this.TypeNotProdBox = new System.Windows.Forms.RadioButton();
            this.CountBox = new System.Windows.Forms.NumericUpDown();
            this.WeightBox = new System.Windows.Forms.TrackBar();
            this.ValueWeight = new System.Windows.Forms.Label();
            this.OrganizationBox = new System.Windows.Forms.DomainUpDown();
            this.AddressBox = new System.Windows.Forms.RichTextBox();
            this.TelephoneBox = new System.Windows.Forms.MaskedTextBox();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SerButton = new System.Windows.Forms.Button();
            this.DeserButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДиапазонуЦеныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНесколькимКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датеПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странеПроизводителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "Беларусь",
            "Германия",
            "Россия",
            "Украина",
            "Литва",
            "Латвия",
            "Польша",
            "Болгария",
            "Индия",
            "Великобритания",
            "Эстония",
            "Испания",
            "Италия",
            "Норвегия",
            "Швеция",
            "Швейцария",
            "Австрия",
            "США",
            "Азербайджан"});
            this.CountryBox.Location = new System.Drawing.Point(518, 97);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 0;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(30, 312);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 20);
            this.DateBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Инвентарный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вес (грамм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(414, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Производитель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(26, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Информация о товаре";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Организация";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Страна";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Адрес";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(415, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Телефон";
            // 
            // TypeProdBox
            // 
            this.TypeProdBox.AutoSize = true;
            this.TypeProdBox.Location = new System.Drawing.Point(163, 236);
            this.TypeProdBox.Name = "TypeProdBox";
            this.TypeProdBox.Size = new System.Drawing.Size(130, 17);
            this.TypeProdBox.TabIndex = 16;
            this.TypeProdBox.TabStop = true;
            this.TypeProdBox.Text = "Продовольственный";
            this.TypeProdBox.UseVisualStyleBackColor = true;
            // 
            // TypeNotProdBox
            // 
            this.TypeNotProdBox.AutoSize = true;
            this.TypeNotProdBox.Location = new System.Drawing.Point(163, 260);
            this.TypeNotProdBox.Name = "TypeNotProdBox";
            this.TypeNotProdBox.Size = new System.Drawing.Size(142, 17);
            this.TypeNotProdBox.TabIndex = 17;
            this.TypeNotProdBox.TabStop = true;
            this.TypeNotProdBox.Text = "Непродовольственный";
            this.TypeNotProdBox.UseVisualStyleBackColor = true;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(30, 376);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(120, 20);
            this.CountBox.TabIndex = 19;
            this.CountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WeightBox.Location = new System.Drawing.Point(163, 187);
            this.WeightBox.Maximum = 10000;
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(165, 45);
            this.WeightBox.TabIndex = 20;
            this.WeightBox.TickStyle = System.Windows.Forms.TickStyle.None;
            this.WeightBox.ValueChanged += new System.EventHandler(this.VeighyBox_ValueChanged);
            // 
            // ValueWeight
            // 
            this.ValueWeight.AutoSize = true;
            this.ValueWeight.Location = new System.Drawing.Point(335, 193);
            this.ValueWeight.Name = "ValueWeight";
            this.ValueWeight.Size = new System.Drawing.Size(0, 13);
            this.ValueWeight.TabIndex = 21;
            // 
            // OrganizationBox
            // 
            this.OrganizationBox.Items.Add("Минская марка");
            this.OrganizationBox.Items.Add("Ами мебель");
            this.OrganizationBox.Items.Add("ZTE");
            this.OrganizationBox.Items.Add("Луч");
            this.OrganizationBox.Items.Add("Онега");
            this.OrganizationBox.Items.Add("Nestle");
            this.OrganizationBox.Items.Add("Другой");
            this.OrganizationBox.Location = new System.Drawing.Point(518, 57);
            this.OrganizationBox.Name = "OrganizationBox";
            this.OrganizationBox.Size = new System.Drawing.Size(120, 20);
            this.OrganizationBox.TabIndex = 22;
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Location = new System.Drawing.Point(518, 147);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 100);
            this.AddressBox.TabIndex = 24;
            this.AddressBox.Text = "";
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(518, 242);
            this.TelephoneBox.Mask = "(00)000-00-00";
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(100, 20);
            this.TelephoneBox.TabIndex = 25;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(30, 435);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(120, 20);
            this.PriceBox.TabIndex = 26;
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(163, 144);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(100, 20);
            this.SizeBox.TabIndex = 27;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(163, 97);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 20);
            this.NumberBox.TabIndex = 28;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(163, 53);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 29;
            // 
            // SerButton
            // 
            this.SerButton.Location = new System.Drawing.Point(418, 276);
            this.SerButton.Name = "SerButton";
            this.SerButton.Size = new System.Drawing.Size(220, 38);
            this.SerButton.TabIndex = 30;
            this.SerButton.Text = "Сохранить объект";
            this.SerButton.UseVisualStyleBackColor = true;
            this.SerButton.Click += new System.EventHandler(this.SerButton_Click);
            // 
            // DeserButton
            // 
            this.DeserButton.Location = new System.Drawing.Point(417, 320);
            this.DeserButton.Name = "DeserButton";
            this.DeserButton.Size = new System.Drawing.Size(220, 38);
            this.DeserButton.TabIndex = 31;
            this.DeserButton.Text = "Восстановить объект";
            this.DeserButton.UseVisualStyleBackColor = true;
            this.DeserButton.Click += new System.EventHandler(this.DeserButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(417, 376);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 111);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поТипуToolStripMenuItem,
            this.поДиапазонуЦеныToolStripMenuItem,
            this.поНесколькимКритериямToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.поНазваниюToolStripMenuItem.Text = "По названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // поТипуToolStripMenuItem
            // 
            this.поТипуToolStripMenuItem.Name = "поТипуToolStripMenuItem";
            this.поТипуToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.поТипуToolStripMenuItem.Text = "По типу";
            this.поТипуToolStripMenuItem.Click += new System.EventHandler(this.поТипуToolStripMenuItem_Click);
            // 
            // поДиапазонуЦеныToolStripMenuItem
            // 
            this.поДиапазонуЦеныToolStripMenuItem.Name = "поДиапазонуЦеныToolStripMenuItem";
            this.поДиапазонуЦеныToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.поДиапазонуЦеныToolStripMenuItem.Text = "По диапазону цены";
            this.поДиапазонуЦеныToolStripMenuItem.Click += new System.EventHandler(this.поДиапазонуЦеныToolStripMenuItem_Click);
            // 
            // поНесколькимКритериямToolStripMenuItem
            // 
            this.поНесколькимКритериямToolStripMenuItem.Name = "поНесколькимКритериямToolStripMenuItem";
            this.поНесколькимКритериямToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.поНесколькимКритериямToolStripMenuItem.Text = "По нескольким критериям";
            this.поНесколькимКритериямToolStripMenuItem.Click += new System.EventHandler(this.поНесколькимКритериямToolStripMenuItem_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.датеПроизводстваToolStripMenuItem,
            this.странеПроизводителяToolStripMenuItem,
            this.названиюToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // датеПроизводстваToolStripMenuItem
            // 
            this.датеПроизводстваToolStripMenuItem.Name = "датеПроизводстваToolStripMenuItem";
            this.датеПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.датеПроизводстваToolStripMenuItem.Text = "Дате производства";
            this.датеПроизводстваToolStripMenuItem.Click += new System.EventHandler(this.датеПроизводстваToolStripMenuItem_Click);
            // 
            // странеПроизводителяToolStripMenuItem
            // 
            this.странеПроизводителяToolStripMenuItem.Name = "странеПроизводителяToolStripMenuItem";
            this.странеПроизводителяToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.странеПроизводителяToolStripMenuItem.Text = "Стране производителя";
            this.странеПроизводителяToolStripMenuItem.Click += new System.EventHandler(this.странеПроизводителяToolStripMenuItem_Click);
            // 
            // названиюToolStripMenuItem
            // 
            this.названиюToolStripMenuItem.Name = "названиюToolStripMenuItem";
            this.названиюToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.названиюToolStripMenuItem.Text = "Названию";
            this.названиюToolStripMenuItem.Click += new System.EventHandler(this.названиюToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DeserButton);
            this.Controls.Add(this.SerButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.OrganizationBox);
            this.Controls.Add(this.ValueWeight);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.TypeNotProdBox);
            this.Controls.Add(this.TypeProdBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Product Information";
            ((System.ComponentModel.ISupportInitialize)(this.CountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton TypeProdBox;
        private System.Windows.Forms.RadioButton TypeNotProdBox;
        private System.Windows.Forms.NumericUpDown CountBox;
        private System.Windows.Forms.TrackBar WeightBox;
        private System.Windows.Forms.Label ValueWeight;
        private System.Windows.Forms.DomainUpDown OrganizationBox;
        private System.Windows.Forms.RichTextBox AddressBox;
        private System.Windows.Forms.MaskedTextBox TelephoneBox;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button SerButton;
        private System.Windows.Forms.Button DeserButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДиапазонуЦеныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датеПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странеПроизводителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНесколькимКритериямToolStripMenuItem;
    }
}

