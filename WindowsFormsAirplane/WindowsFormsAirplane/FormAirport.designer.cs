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
            this.buttonTakeBomber = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCheckingForFreePlaces = new System.Windows.Forms.Button();
            this.maskedTextBoxCountOfPlane = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxBomber = new System.Windows.Forms.GroupBox();
            this.comboBoxBoombs = new System.Windows.Forms.ComboBox();
            this.labelBoomb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxBomber.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetWarPlane);
            this.groupBox1.Location = new System.Drawing.Point(693, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать";
            // 
            // buttonSetWarPlane
            // 
            this.buttonSetWarPlane.Location = new System.Drawing.Point(6, 19);
            this.buttonSetWarPlane.Name = "buttonSetWarPlane";
            this.buttonSetWarPlane.Size = new System.Drawing.Size(167, 36);
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
            this.groupBox2.Controls.Add(this.buttonTakeBomber);
            this.groupBox2.Controls.Add(this.labelPlace);
            this.groupBox2.Controls.Add(this.maskedTextBoxPlace);
            this.groupBox2.Location = new System.Drawing.Point(693, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 76);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Забрать";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCheckingForFreePlaces);
            this.groupBox3.Controls.Add(this.maskedTextBoxCountOfPlane);
            this.groupBox3.Location = new System.Drawing.Point(693, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сравнить";
            // 
            // buttonCheckingForFreePlaces
            // 
            this.buttonCheckingForFreePlaces.Location = new System.Drawing.Point(40, 56);
            this.buttonCheckingForFreePlaces.Name = "buttonCheckingForFreePlaces";
            this.buttonCheckingForFreePlaces.Size = new System.Drawing.Size(99, 57);
            this.buttonCheckingForFreePlaces.TabIndex = 0;
            this.buttonCheckingForFreePlaces.Text = "Сравнить на кол-во свободных мест";
            this.buttonCheckingForFreePlaces.UseVisualStyleBackColor = true;
            this.buttonCheckingForFreePlaces.Click += new System.EventHandler(this.buttonCheckingForFreePlaces_Click);
            // 
            // maskedTextBoxCountOfPlane
            // 
            this.maskedTextBoxCountOfPlane.Location = new System.Drawing.Point(15, 30);
            this.maskedTextBoxCountOfPlane.Name = "maskedTextBoxCountOfPlane";
            this.maskedTextBoxCountOfPlane.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBoxCountOfPlane.TabIndex = 0;
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
            this.groupBoxBomber.Location = new System.Drawing.Point(693, 79);
            this.groupBoxBomber.Name = "groupBoxBomber";
            this.groupBoxBomber.Size = new System.Drawing.Size(179, 122);
            this.groupBoxBomber.TabIndex = 13;
            this.groupBoxBomber.TabStop = false;
            this.groupBoxBomber.Text = "Бомбардировщик";
            // 
            // comboBoxBoombs
            // 
            this.comboBoxBoombs.FormattingEnabled = true;
            this.comboBoxBoombs.Location = new System.Drawing.Point(79, 19);
            this.comboBoxBoombs.Name = "comboBoxBoombs";
            this.comboBoxBoombs.Size = new System.Drawing.Size(85, 21);
            this.comboBoxBoombs.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Форма бомб:";
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
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxBomber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAirport);
            this.Name = "FormAirport";
            this.Text = "Airport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxBomber.ResumeLayout(false);
            this.groupBoxBomber.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCheckingForFreePlaces;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCountOfPlane;
        private System.Windows.Forms.GroupBox groupBoxBomber;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBoomb;
        private System.Windows.Forms.ComboBox comboBoxBoombs;
    }
}