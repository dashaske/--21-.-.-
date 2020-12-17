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
        private readonly AirportCollection airportCollection;

        public LinkedList<Plane> plane = new LinkedList<Plane>();

        public FormAirport()
        {
            InitializeComponent();
            comboBoxBoombs.Items.AddRange(new string[] { "6", "8", "10" });
            airportCollection = new AirportCollection(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Draw();
        }
        //Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxAirport.SelectedIndex;
            listBoxAirport.Items.Clear();
            for (int i = 0; i < airportCollection.Keys.Count; i++)
            {
                listBoxAirport.Items.Add(airportCollection.Keys[i]);
            }
            if (listBoxAirport.Items.Count > 0 && (index == -1 || index >=
            listBoxAirport.Items.Count))
            {
                listBoxAirport.SelectedIndex = 0;
            }
            else if (listBoxAirport.Items.Count > 0 && index > -1 && index <
            listBoxAirport.Items.Count)
            {
                listBoxAirport.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxAirport.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirport.Width, pictureBoxAirport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airportCollection[listBoxAirport.SelectedItem.ToString()].Draw(gr);
                pictureBoxAirport.Image = bmp;
            }
        }
        private void buttonSetWarPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var air = new WarPlane(100, 1000, dialog.Color);
                if (airportCollection[listBoxAirport.SelectedItem.ToString()] + air)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не удалось посадить военный самолет");
                }
            }
        }
        private void buttonSetBomber_Click(object sender, EventArgs e)
        {
            if (listBoxAirport.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var bomber = new Bomber(100, 1000, dialog.Color, dialogDop.Color,
                        true, true, true);
                        if (airportCollection[listBoxAirport.SelectedItem.ToString()] + bomber)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось посадить бомбардировщик");
                        }
                    }
                }
            }
        }
        private void buttonTakeBomber_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var aircraft = airportCollection[listBoxAirport.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (aircraft != null)
                {
                    plane.AddFirst(aircraft);
                }
                Draw();
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
        private void buttonAddAirport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLevels.Text))
            {
                MessageBox.Show("Введите название аэропорта!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            airportCollection.AddAirport(textBoxLevels.Text);
            textBoxLevels.Text = "";
            ReloadLevels();
            Draw();
        }

        private void buttonDeleteAirport_Click(object sender, EventArgs e)
        {
            if (listBoxAirport.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэропорт { listBoxAirport.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    airportCollection.DelAirport(listBoxAirport.Text);
                    ReloadLevels();
                }
            }
        }
        private void listBoxAirport_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonCheckPlane_Click(object sender, EventArgs e)
        {
            if (plane.Count > 0)
            {
                FormPlane form = new FormPlane();
                form.SetPlane(plane.First.Value);
                plane.RemoveFirst();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Самолётов не осталось");
            }
        }
    }    
}
