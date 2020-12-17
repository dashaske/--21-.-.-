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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSetWarPlane = new System.Windows.Forms.Button();
            this.buttonSetBomber = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCheckPlane = new System.Windows.Forms.Button();
            this.buttonTakeBomber = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.groupBoxBomber = new System.Windows.Forms.GroupBox();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBoomb = new System.Windows.Forms.Label();
            this.comboBoxBoombs = new System.Windows.Forms.ComboBox();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.groupBoxAirPort = new System.Windows.Forms.GroupBox();
            this.listBoxAirport = new System.Windows.Forms.ListBox();
            this.buttonDeleteAirport = new System.Windows.Forms.Button();
            this.textBoxLevels = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.groupBoxBomber.SuspendLayout();
            this.groupBoxAirPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetWarPlane);
            this.groupBox1.Location = new System.Drawing.Point(693, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать";
            // 
            // buttonSetWarPlane
            // 
            this.buttonSetWarPlane.Location = new System.Drawing.Point(16, 19);
            this.buttonSetWarPlane.Name = "buttonSetWarPlane";
            this.buttonSetWarPlane.Size = new System.Drawing.Size(124, 23);
            this.buttonSetWarPlane.TabIndex = 8;
            this.buttonSetWarPlane.Text = "Военный самолет";
            this.buttonSetWarPlane.UseVisualStyleBackColor = true;
            this.buttonSetWarPlane.Click += new System.EventHandler(this.buttonSetWarPlane_Click);
            // 
            // buttonSetBomber
            // 
            this.buttonSetBomber.Location = new System.Drawing.Point(8, 79);
            this.buttonSetBomber.Name = "buttonSetBomber";
            this.buttonSetBomber.Size = new System.Drawing.Size(71, 27);
            this.buttonSetBomber.TabIndex = 7;
            this.buttonSetBomber.Text = "Создать";
            this.buttonSetBomber.UseVisualStyleBackColor = true;
            this.buttonSetBomber.Click += new System.EventHandler(this.buttonSetBomber_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(693, 290);
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
            this.pictureBoxAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(630, 461);
            this.pictureBoxAirport.TabIndex = 0;
            this.pictureBoxAirport.TabStop = false;
            // 
            // groupBoxBomber
            // 
            this.groupBoxBomber.Controls.Add(this.buttonThirdForm);
            this.groupBoxBomber.Controls.Add(this.buttonFirstForm);
            this.groupBoxBomber.Controls.Add(this.buttonSecondForm);
            this.groupBoxBomber.Controls.Add(this.label1);
            this.groupBoxBomber.Controls.Add(this.labelBoomb);
            this.groupBoxBomber.Controls.Add(this.comboBoxBoombs);
            this.groupBoxBomber.Controls.Add(this.buttonSetBomber);
            this.groupBoxBomber.Location = new System.Drawing.Point(693, 162);
            this.groupBoxBomber.Name = "groupBoxBomber";
            this.groupBoxBomber.Size = new System.Drawing.Size(179, 122);
            this.groupBoxBomber.TabIndex = 13;
            this.groupBoxBomber.TabStop = false;
            this.groupBoxBomber.Text = "Бомбардировщик";
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(85, 79);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(79, 27);
            this.buttonThirdForm.TabIndex = 13;
            this.buttonThirdForm.Text = "3Ф";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.Click += new System.EventHandler(this.buttonBombsForm_Click);
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(85, 46);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(39, 28);
            this.buttonFirstForm.TabIndex = 12;
            this.buttonFirstForm.Text = "1Ф";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.Click += new System.EventHandler(this.buttonBombsForm_Click);
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(126, 46);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(38, 27);
            this.buttonSecondForm.TabIndex = 11;
            this.buttonSecondForm.Text = "2Ф";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.Click += new System.EventHandler(this.buttonBombsForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Форма бомб:";
            // 
            // labelBoomb
            // 
            this.labelBoomb.AutoSize = true;
            this.labelBoomb.Location = new System.Drawing.Point(3, 22);
            this.labelBoomb.Name = "labelBoomb";
            this.labelBoomb.Size = new System.Drawing.Size(73, 13);
            this.labelBoomb.TabIndex = 9;
            this.labelBoomb.Text = "Кол-во бомб:";
            // 
            // comboBoxBoombs
            // 
            this.comboBoxBoombs.FormattingEnabled = true;
            this.comboBoxBoombs.Location = new System.Drawing.Point(79, 19);
            this.comboBoxBoombs.Name = "comboBoxBoombs";
            this.comboBoxBoombs.Size = new System.Drawing.Size(85, 21);
            this.comboBoxBoombs.TabIndex = 8;
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
            this.groupBoxAirPort.Location = new System.Drawing.Point(694, 0);
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
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxAirPort);
            this.Controls.Add(this.groupBoxBomber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAirport);
            this.Name = "FormAirport";
            this.Text = "Airport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.groupBoxBomber.ResumeLayout(false);
            this.groupBoxBomber.PerformLayout();
            this.groupBoxAirPort.ResumeLayout(false);
            this.groupBoxAirPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSetWarPlane;
        private System.Windows.Forms.Button buttonSetBomber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTakeBomber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.GroupBox groupBoxBomber;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBoomb;
        private System.Windows.Forms.ComboBox comboBoxBoombs;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.GroupBox groupBoxAirPort;
        private System.Windows.Forms.ListBox listBoxAirport;
        private System.Windows.Forms.Button buttonDeleteAirport;
        private System.Windows.Forms.TextBox textBoxLevels;
        private System.Windows.Forms.Button buttonCheckPlane;
    }
}