using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public partial class FormAirport : Form
    {
        private readonly Airport<WarPlane, BoombsCircular> airport;

        public FormAirport()
        {
            InitializeComponent();
            comboBoxBoombs.Items.AddRange(new string[] { "6", "8", "10" });
            airport = new Airport<WarPlane, BoombsCircular>(9, pictureBoxAirport.Width, pictureBoxAirport.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airport.Draw(gr);
            pictureBoxAirport.Image = bmp;
        }
        private void buttonSetWarPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var air = new WarPlane(100, 1000, dialog.Color);
                if (airport + air)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Все места заполнены");
                }
            }
        }
        private void buttonSetBomber_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var air = new Bomber(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color,
                    Convert.ToInt32(comboBoxBoombs.SelectedItem), FormOfBombs(), true, true, true);

                    buttonSecondForm.Enabled = true;
                    buttonFirstForm.Enabled = true;
                    buttonThirdForm.Enabled = true;
                    if (airport + air)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Все места заполнены");
                    }
                   
                }
            }
        }
        private void buttonTakeBomber_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var air = airport - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (air != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(air);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void buttonCheckingForFreePlaces_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCountOfPlane.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxCountOfPlane.Text);
                if (airport == index)
                {
                    MessageBox.Show("Свободных мест в аэропорте = " + index);
                }
                else if (airport != index)
                {
                    MessageBox.Show("Свободных мест в аэропорте не = " + index);
                }
            }
        }
        private void buttonBombsForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonFirstForm)
            {
                buttonSecondForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else if (sender == buttonSecondForm)
            {
                buttonFirstForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else
            {
                buttonFirstForm.Enabled = false;
                buttonSecondForm.Enabled = false;
            }
        }
        private int FormOfBombs()
        {
            if (buttonFirstForm.Enabled == true)
            {
                return 0;
            }
            else if (buttonSecondForm.Enabled == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
