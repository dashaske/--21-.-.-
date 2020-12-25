namespace WindowsFormsAirplane
{
    partial class FormAirport
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
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCheckPlane = new System.Windows.Forms.Button();
            this.buttonTakeBomber = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.groupBoxAirPort = new System.Windows.Forms.GroupBox();
            this.listBoxAirport = new System.Windows.Forms.ListBox();
            this.buttonDeleteAirport = new System.Windows.Forms.Button();
            this.textBoxLevels = new System.Windows.Forms.TextBox();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеАэропортыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйАэропортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеАэропортыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйАэропортToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.groupBoxAirPort.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(60, 13);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(104, 20);
            this.maskedTextBoxPlace.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCheckPlane);
            this.groupBox2.Controls.Add(this.buttonTakeBomber);
            this.groupBox2.Controls.Add(this.labelPlace);
            this.groupBox2.Controls.Add(this.maskedTextBoxPlace);
            this.groupBox2.Location = new System.Drawing.Point(694, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 97);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Забрать";
            // 
            // buttonCheckPlane
            // 
            this.buttonCheckPlane.Location = new System.Drawing.Point(60, 68);
            this.buttonCheckPlane.Name = "buttonCheckPlane";
            this.buttonCheckPlane.Size = new System.Drawing.Size(104, 23);
            this.buttonCheckPlane.TabIndex = 16;
            this.buttonCheckPlane.Text = "Посмотреть";
            this.buttonCheckPlane.UseVisualStyleBackColor = true;
            this.buttonCheckPlane.Click += new System.EventHandler(this.buttonCheckPlane_Click);
            // 
            // buttonTakeBomber
            // 
            this.buttonTakeBomber.Location = new System.Drawing.Point(60, 39);
            this.buttonTakeBomber.Name = "buttonTakeBomber";
            this.buttonTakeBomber.Size = new System.Drawing.Size(104, 23);
            this.buttonTakeBomber.TabIndex = 11;
            this.buttonTakeBomber.Text = "Забрать";
            this.buttonTakeBomber.UseVisualStyleBackColor = true;
            this.buttonTakeBomber.Click += new System.EventHandler(this.buttonTakeBomber_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(12, 16);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 10;
            this.labelPlace.Text = "Место:";
            // 
            // pictureBoxAirport
            // 
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 31);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(630, 430);
            this.pictureBoxAirport.TabIndex = 0;
            this.pictureBoxAirport.TabStop = false;
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.Location = new System.Drawing.Point(1, 19);
            this.buttonAddAirport.Name = "buttonAddAirport";
            this.buttonAddAirport.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAirport.TabIndex = 14;
            this.buttonAddAirport.Text = "Создать";
            this.buttonAddAirport.UseVisualStyleBackColor = true;
            this.buttonAddAirport.Click += new System.EventHandler(this.buttonAddAirport_Click);
            // 
            // groupBoxAirPort
            // 
            this.groupBoxAirPort.Controls.Add(this.listBoxAirport);
            this.groupBoxAirPort.Controls.Add(this.buttonDeleteAirport);
            this.groupBoxAirPort.Controls.Add(this.textBoxLevels);
            this.groupBoxAirPort.Controls.Add(this.buttonAddAirport);
            this.groupBoxAirPort.Location = new System.Drawing.Point(693, 31);
            this.groupBoxAirPort.Name = "groupBoxAirPort";
            this.groupBoxAirPort.Size = new System.Drawing.Size(178, 99);
            this.groupBoxAirPort.TabIndex = 15;
            this.groupBoxAirPort.TabStop = false;
            this.groupBoxAirPort.Text = "Аэропорт";
            // 
            // listBoxAirport
            // 
            this.listBoxAirport.FormattingEnabled = true;
            this.listBoxAirport.Location = new System.Drawing.Point(78, 45);
            this.listBoxAirport.Name = "listBoxAirport";
            this.listBoxAirport.Size = new System.Drawing.Size(94, 43);
            this.listBoxAirport.TabIndex = 18;
            this.listBoxAirport.SelectedIndexChanged += new System.EventHandler(this.listBoxAirport_SelectedIndexChanged);
            // 
            // buttonDeleteAirport
            // 
            this.buttonDeleteAirport.Location = new System.Drawing.Point(3, 48);
            this.buttonDeleteAirport.Name = "buttonDeleteAirport";
            this.buttonDeleteAirport.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAirport.TabIndex = 17;
            this.buttonDeleteAirport.Text = "Удалить";
            this.buttonDeleteAirport.UseVisualStyleBackColor = true;
            this.buttonDeleteAirport.Click += new System.EventHandler(this.buttonDeleteAirport_Click);
            // 
            // textBoxLevels
            // 
            this.textBoxLevels.Location = new System.Drawing.Point(80, 19);
            this.textBoxLevels.Name = "textBoxLevels";
            this.textBoxLevels.Size = new System.Drawing.Size(77, 20);
            this.textBoxLevels.TabIndex = 16;
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(728, 148);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(108, 51);
            this.buttonAddPlane.TabIndex = 16;
            this.buttonAddPlane.Text = "Посадить самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(884, 24);
            this.msMenu.TabIndex = 17;
            this.msMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеАэропортыToolStripMenuItem,
            this.выбранныйАэропортToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // всеАэропортыToolStripMenuItem
            // 
            this.всеАэропортыToolStripMenuItem.Name = "всеАэропортыToolStripMenuItem";
            this.всеАэропортыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.всеАэропортыToolStripMenuItem.Text = "Все аэропорты";
            this.всеАэропортыToolStripMenuItem.Click += new System.EventHandler(this.всеАэропортыToolStripMenuItem_Click);
            // 
            // выбранныйАэропортToolStripMenuItem
            // 
            this.выбранныйАэропортToolStripMenuItem.Name = "выбранныйАэропортToolStripMenuItem";
            this.выбранныйАэропортToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выбранныйАэропортToolStripMenuItem.Text = "Выбранный аэропорт";
            this.выбранныйАэропортToolStripMenuItem.Click += new System.EventHandler(this.выбранныйАэропортToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеАэропортыToolStripMenuItem1,
            this.выбранныйАэропортToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // всеАэропортыToolStripMenuItem1
            // 
            this.всеАэропортыToolStripMenuItem1.Name = "всеАэропортыToolStripMenuItem1";
            this.всеАэропортыToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.всеАэропортыToolStripMenuItem1.Text = "Все аэропорты";
            this.всеАэропортыToolStripMenuItem1.Click += new System.EventHandler(this.всеАэропортыToolStripMenuItem1_Click);
            // 
            // выбранныйАэропортToolStripMenuItem1
            // 
            this.выбранныйАэропортToolStripMenuItem1.Name = "выбранныйАэропортToolStripMenuItem1";
            this.выбранныйАэропортToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.выбранныйАэропортToolStripMenuItem1.Text = "Выбранный аэропорт";
            this.выбранныйАэропортToolStripMenuItem1.Click += new System.EventHandler(this.выбранныйАэропортToolStripMenuItem1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "default";
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "default";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.groupBoxAirPort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxAirport);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FormAirport";
            this.Text = "Airport";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.groupBoxAirPort.ResumeLayout(false);
            this.groupBoxAirPort.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTakeBomber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.GroupBox groupBoxAirPort;
        private System.Windows.Forms.ListBox listBoxAirport;
        private System.Windows.Forms.Button buttonDeleteAirport;
        private System.Windows.Forms.TextBox textBoxLevels;
        private System.Windows.Forms.Button buttonCheckPlane;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеАэропортыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныйАэропортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеАэропортыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выбранныйАэропортToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}