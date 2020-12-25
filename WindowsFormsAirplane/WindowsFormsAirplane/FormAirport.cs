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
            airportCollection = new AirportCollection(pictureBoxAirport.Width, pictureBoxAirport.Height);
            plane = new LinkedList<Plane>();
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
        private void AddPlane(Plane plane)
        {
            if (plane != null && listBoxAirport.SelectedIndex > -1)
            {
                if ((airportCollection[listBoxAirport.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
        }
        private void buttonAddPlane_Click(object sender, EventArgs e)
        {
            var formTeplonfig = new FormPlaneConfig();
            formTeplonfig.AddEvent(AddPlane);
            formTeplonfig.Show();
        }
        private void всеАэропортыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void выбранныйАэропортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (listBoxAirport.SelectedIndex > -1)
                {
                    if (airportCollection.SaveData(saveFileDialog.FileName, listBoxAirport.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void всеАэропортыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.LoadAirportCollection(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private void выбранныйАэропортToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (airportCollection.LoadAirport(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}    
