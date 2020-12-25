namespace WindowsFormsAirplane
{
    partial class FormPlaneConfig
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
            this.checkBoxStar = new System.Windows.Forms.CheckBox();
            this.checkBoxGun = new System.Windows.Forms.CheckBox();
            this.checkBoxFastening = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBomber = new System.Windows.Forms.Label();
            this.labelWarPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBombs = new System.Windows.Forms.GroupBox();
            this.labelPointedBombs = new System.Windows.Forms.Label();
            this.labelBoombsCircular = new System.Windows.Forms.Label();
            this.labelBoombsStandart = new System.Windows.Forms.Label();
            this.labelChangeBombs = new System.Windows.Forms.Label();
            this.labelTenBombs = new System.Windows.Forms.Label();
            this.labelEightBombs = new System.Windows.Forms.Label();
            this.labelSixBombs = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxBombs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxStar);
            this.groupBox1.Controls.Add(this.checkBoxGun);
            this.groupBox1.Controls.Add(this.checkBoxFastening);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // checkBoxStar
            // 
            this.checkBoxStar.AutoSize = true;
            this.checkBoxStar.Location = new System.Drawing.Point(99, 73);
            this.checkBoxStar.Name = "checkBoxStar";
            this.checkBoxStar.Size = new System.Drawing.Size(65, 17);
            this.checkBoxStar.TabIndex = 6;
            this.checkBoxStar.Text = "Звезды";
            this.checkBoxStar.UseVisualStyleBackColor = true;
            // 
            // checkBoxGun
            // 
            this.checkBoxGun.AutoSize = true;
            this.checkBoxGun.Location = new System.Drawing.Point(99, 53);
            this.checkBoxGun.Name = "checkBoxGun";
            this.checkBoxGun.Size = new System.Drawing.Size(78, 17);
            this.checkBoxGun.TabIndex = 5;
            this.checkBoxGun.Text = "Пулеметы";
            this.checkBoxGun.UseVisualStyleBackColor = true;
            // 
            // checkBoxFastening
            // 
            this.checkBoxFastening.AutoSize = true;
            this.checkBoxFastening.Location = new System.Drawing.Point(99, 32);
            this.checkBoxFastening.Name = "checkBoxFastening";
            this.checkBoxFastening.Size = new System.Drawing.Size(132, 17);
            this.checkBoxFastening.TabIndex = 4;
            this.checkBoxFastening.Text = "Крепление пулемета";
            this.checkBoxFastening.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 74);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес самолета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс скорость:";
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(295, 262);
            this.pictureBoxPlane.TabIndex = 1;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBomber);
            this.groupBox2.Controls.Add(this.labelWarPlane);
            this.groupBox2.Location = new System.Drawing.Point(21, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип самолета";
            // 
            // labelBomber
            // 
            this.labelBomber.AllowDrop = true;
            this.labelBomber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBomber.Location = new System.Drawing.Point(26, 75);
            this.labelBomber.Name = "labelBomber";
            this.labelBomber.Size = new System.Drawing.Size(108, 37);
            this.labelBomber.TabIndex = 1;
            this.labelBomber.Text = "Бомбардировщик";
            this.labelBomber.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.labelBomber.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            this.labelBomber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBomber_MouseDown);
            // 
            // labelWarPlane
            // 
            this.labelWarPlane.AllowDrop = true;
            this.labelWarPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarPlane.Location = new System.Drawing.Point(26, 26);
            this.labelWarPlane.Name = "labelWarPlane";
            this.labelWarPlane.Size = new System.Drawing.Size(108, 37);
            this.labelWarPlane.TabIndex = 0;
            this.labelWarPlane.Text = "Военный самолет";
            this.labelWarPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            this.labelWarPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            this.labelWarPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(220, 15);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(324, 292);
            this.panelPlane.TabIndex = 3;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Controls.Add(this.panelBlue);
            this.groupBox3.Controls.Add(this.panelGreen);
            this.groupBox3.Controls.Add(this.panelWhite);
            this.groupBox3.Controls.Add(this.panelBlack);
            this.groupBox3.Controls.Add(this.panelOrange);
            this.groupBox3.Controls.Add(this.panelGray);
            this.groupBox3.Controls.Add(this.panelYellow);
            this.groupBox3.Controls.Add(this.panelRed);
            this.groupBox3.Location = new System.Drawing.Point(571, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(112, 20);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 27);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelDopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(6, 20);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(100, 27);
            this.labelBaseColor.TabIndex = 3;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(177, 84);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(32, 26);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(127, 84);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(32, 26);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelWhite.Location = new System.Drawing.Point(177, 52);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(32, 26);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelBlack.Location = new System.Drawing.Point(127, 52);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(32, 26);
            this.panelBlack.TabIndex = 2;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(57, 84);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(32, 26);
            this.panelOrange.TabIndex = 1;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelGray.Location = new System.Drawing.Point(6, 84);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(32, 26);
            this.panelGray.TabIndex = 1;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(57, 52);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(32, 26);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 52);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(32, 26);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(713, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 32);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxBombs
            // 
            this.groupBoxBombs.Controls.Add(this.labelPointedBombs);
            this.groupBoxBombs.Controls.Add(this.labelBoombsCircular);
            this.groupBoxBombs.Controls.Add(this.labelBoombsStandart);
            this.groupBoxBombs.Controls.Add(this.labelChangeBombs);
            this.groupBoxBombs.Controls.Add(this.labelTenBombs);
            this.groupBoxBombs.Controls.Add(this.labelEightBombs);
            this.groupBoxBombs.Controls.Add(this.labelSixBombs);
            this.groupBoxBombs.Location = new System.Drawing.Point(392, 342);
            this.groupBoxBombs.Name = "groupBoxBombs";
            this.groupBoxBombs.Size = new System.Drawing.Size(215, 125);
            this.groupBoxBombs.TabIndex = 7;
            this.groupBoxBombs.TabStop = false;
            this.groupBoxBombs.Text = "Бомбы";
            // 
            // labelPointedBombs
            // 
            this.labelPointedBombs.AllowDrop = true;
            this.labelPointedBombs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPointedBombs.Location = new System.Drawing.Point(93, 73);
            this.labelPointedBombs.Name = "labelPointedBombs";
            this.labelPointedBombs.Size = new System.Drawing.Size(101, 21);
            this.labelPointedBombs.TabIndex = 6;
            this.labelPointedBombs.Text = "Пулеобразные";
            this.labelPointedBombs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelBoombsForm_MouseDown);
            // 
            // labelBoombsCircular
            // 
            this.labelBoombsCircular.AllowDrop = true;
            this.labelBoombsCircular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoombsCircular.Location = new System.Drawing.Point(93, 97);
            this.labelBoombsCircular.Name = "labelBoombsCircular";
            this.labelBoombsCircular.Size = new System.Drawing.Size(100, 22);
            this.labelBoombsCircular.TabIndex = 5;
            this.labelBoombsCircular.Text = "Заостренные";
            this.labelBoombsCircular.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelBoombsForm_MouseDown);
            // 
            // labelBoombsStandart
            // 
            this.labelBoombsStandart.AllowDrop = true;
            this.labelBoombsStandart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoombsStandart.Location = new System.Drawing.Point(93, 48);
            this.labelBoombsStandart.Name = "labelBoombsStandart";
            this.labelBoombsStandart.Size = new System.Drawing.Size(101, 22);
            this.labelBoombsStandart.TabIndex = 4;
            this.labelBoombsStandart.Text = "Стандартные";
            this.labelBoombsStandart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelBoombsForm_MouseDown);
            // 
            // labelChangeBombs
            // 
            this.labelChangeBombs.AllowDrop = true;
            this.labelChangeBombs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChangeBombs.Location = new System.Drawing.Point(83, 15);
            this.labelChangeBombs.Name = "labelChangeBombs";
            this.labelChangeBombs.Size = new System.Drawing.Size(100, 23);
            this.labelChangeBombs.TabIndex = 3;
            this.labelChangeBombs.Text = "Изменить бомбы";
            this.labelChangeBombs.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelChangeBombs_DragDrop);
            this.labelChangeBombs.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelChangeBombs_DragEnter);
            // 
            // labelTenBombs
            // 
            this.labelTenBombs.AllowDrop = true;
            this.labelTenBombs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTenBombs.Location = new System.Drawing.Point(22, 74);
            this.labelTenBombs.Name = "labelTenBombs";
            this.labelTenBombs.Size = new System.Drawing.Size(29, 28);
            this.labelTenBombs.TabIndex = 2;
            this.labelTenBombs.Text = "10";
            this.labelTenBombs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberBombs_MouseDown);
            // 
            // labelEightBombs
            // 
            this.labelEightBombs.AllowDrop = true;
            this.labelEightBombs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEightBombs.Location = new System.Drawing.Point(41, 32);
            this.labelEightBombs.Name = "labelEightBombs";
            this.labelEightBombs.Size = new System.Drawing.Size(29, 28);
            this.labelEightBombs.TabIndex = 1;
            this.labelEightBombs.Text = "8";
            this.labelEightBombs.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelChangeBombs_DragDrop);
            this.labelEightBombs.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelChangeBombs_DragEnter);
            this.labelEightBombs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberBombs_MouseDown);
            // 
            // labelSixBombs
            // 
            this.labelSixBombs.AllowDrop = true;
            this.labelSixBombs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSixBombs.Location = new System.Drawing.Point(6, 32);
            this.labelSixBombs.Name = "labelSixBombs";
            this.labelSixBombs.Size = new System.Drawing.Size(29, 28);
            this.labelSixBombs.TabIndex = 0;
            this.labelSixBombs.Text = "6";
            this.labelSixBombs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberBombs_MouseDown);
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 479);
            this.Controls.Add(this.groupBoxBombs);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlaneConfig";
            this.Text = "Выбор самолета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxBombs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxStar;
        private System.Windows.Forms.CheckBox checkBoxGun;
        private System.Windows.Forms.CheckBox checkBoxFastening;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelBomber;
        private System.Windows.Forms.Label labelWarPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxBombs;
        private System.Windows.Forms.Label labelTenBombs;
        private System.Windows.Forms.Label labelEightBombs;
        private System.Windows.Forms.Label labelSixBombs;
        private System.Windows.Forms.Label labelChangeBombs;
        private System.Windows.Forms.Label labelPointedBombs;
        private System.Windows.Forms.Label labelBoombsCircular;
        private System.Windows.Forms.Label labelBoombsStandart;
    }
}