namespace сяп_2
{
	partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createListStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openListStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.safeListStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nextStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.delStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForPrev = new System.Windows.Forms.Button();
            this.btnForNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createListStrip,
            this.openListStrip,
            this.safeListStrip});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createListStrip
            // 
            this.createListStrip.Name = "createListStrip";
            this.createListStrip.Size = new System.Drawing.Size(180, 22);
            this.createListStrip.Text = "Создать";
            this.createListStrip.Click += new System.EventHandler(this.createListStrip_Click);
            // 
            // openListStrip
            // 
            this.openListStrip.Name = "openListStrip";
            this.openListStrip.Size = new System.Drawing.Size(180, 22);
            this.openListStrip.Text = "Открыть";
            this.openListStrip.Click += new System.EventHandler(this.openListStrip_Click);
            // 
            // safeListStrip
            // 
            this.safeListStrip.Enabled = false;
            this.safeListStrip.Name = "safeListStrip";
            this.safeListStrip.Size = new System.Drawing.Size(180, 22);
            this.safeListStrip.Text = "Сохранить как";
            this.safeListStrip.Click += new System.EventHandler(this.safeListStrip_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prevStripMenu,
            this.nextStripMenu});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // prevStripMenu
            // 
            this.prevStripMenu.Enabled = false;
            this.prevStripMenu.Name = "prevStripMenu";
            this.prevStripMenu.Size = new System.Drawing.Size(180, 22);
            this.prevStripMenu.Text = "Пред.студент";
            this.prevStripMenu.Click += new System.EventHandler(this.btnForPrev_Click);
            // 
            // nextStripMenu
            // 
            this.nextStripMenu.Enabled = false;
            this.nextStripMenu.Name = "nextStripMenu";
            this.nextStripMenu.Size = new System.Drawing.Size(180, 22);
            this.nextStripMenu.Text = "След.студент";
            this.nextStripMenu.Click += new System.EventHandler(this.btnForNext_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStrip,
            this.delStrip});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // addStrip
            // 
            this.addStrip.Enabled = false;
            this.addStrip.Name = "addStrip";
            this.addStrip.Size = new System.Drawing.Size(180, 22);
            this.addStrip.Text = "Добавить";
            this.addStrip.Click += new System.EventHandler(this.addStrip_Click);
            // 
            // delStrip
            // 
            this.delStrip.Enabled = false;
            this.delStrip.Name = "delStrip";
            this.delStrip.Size = new System.Drawing.Size(180, 22);
            this.delStrip.Text = "Удалить";
            this.delStrip.Click += new System.EventHandler(this.delStrip_Click);
            // 
            // btnForPrev
            // 
            this.btnForPrev.Enabled = false;
            this.btnForPrev.Location = new System.Drawing.Point(12, 270);
            this.btnForPrev.Name = "btnForPrev";
            this.btnForPrev.Size = new System.Drawing.Size(141, 38);
            this.btnForPrev.TabIndex = 1;
            this.btnForPrev.Text = "Предыдущий";
            this.btnForPrev.UseVisualStyleBackColor = true;
            this.btnForPrev.Click += new System.EventHandler(this.btnForPrev_Click);
            // 
            // btnForNext
            // 
            this.btnForNext.Enabled = false;
            this.btnForNext.Location = new System.Drawing.Point(170, 270);
            this.btnForNext.Name = "btnForNext";
            this.btnForNext.Size = new System.Drawing.Size(141, 38);
            this.btnForNext.TabIndex = 2;
            this.btnForNext.Text = "Следующий";
            this.btnForNext.UseVisualStyleBackColor = true;
            this.btnForNext.Click += new System.EventHandler(this.btnForNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(12, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.TextChangeName);
            // 
            // tbSurname
            // 
            this.tbSurname.Enabled = false;
            this.tbSurname.Location = new System.Drawing.Point(12, 95);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(289, 20);
            this.tbSurname.TabIndex = 5;
            this.tbSurname.TextChanged += new System.EventHandler(this.TextChangeSurname);
            // 
            // tbFack
            // 
            this.tbFack.Enabled = false;
            this.tbFack.Location = new System.Drawing.Point(12, 138);
            this.tbFack.Name = "tbFack";
            this.tbFack.Size = new System.Drawing.Size(289, 20);
            this.tbFack.TabIndex = 6;
            this.tbFack.TextChanged += new System.EventHandler(this.TextChangeFack);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Факультет";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(24, 161);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "open";
            this.openFileDialog.Filter = "XML files(*.xml)|*.xml";
            this.openFileDialog.InitialDirectory = "Directory.GetCurrentDirectory()";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "save";
            this.saveFileDialog.Filter = "XML files(*.xml)|*.xml";
            this.saveFileDialog.InitialDirectory = "Directory.GetCurrentDirectory();";
            // 
            // myComboBox
            // 
            this.myComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Факультет"});
            this.myComboBox.Location = new System.Drawing.Point(12, 206);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(99, 21);
            this.myComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Поиск";
            // 
            // myTextBox
            // 
            this.myTextBox.Enabled = false;
            this.myTextBox.Location = new System.Drawing.Point(156, 207);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(155, 20);
            this.myTextBox.TabIndex = 14;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(226, 233);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 20);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(323, 353);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFack);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForNext);
            this.Controls.Add(this.btnForPrev);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createListStrip;
		private System.Windows.Forms.ToolStripMenuItem openListStrip;
		private System.Windows.Forms.ToolStripMenuItem safeListStrip;
		private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prevStripMenu;
		private System.Windows.Forms.ToolStripMenuItem nextStripMenu;
		private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addStrip;
		private System.Windows.Forms.ToolStripMenuItem delStrip;
		private System.Windows.Forms.Button btnForPrev;
		private System.Windows.Forms.Button btnForNext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbFack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label errorMessage;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ComboBox myComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox myTextBox;
		private System.Windows.Forms.Button btnFind;
	}
}

