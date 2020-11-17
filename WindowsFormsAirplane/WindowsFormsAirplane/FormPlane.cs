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
    public partial class FormPlane : Form
    {
        private ITransport plane;
        public FormPlane()
        {
            InitializeComponent();
            comboBoxBoombs.Items.AddRange(new string[] { "6", "8", "10" });
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawFly(gr);
            pictureBoxAirplane.Image = bmp;
        }
        private void buttonCreateWar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            plane = new WarPlane(rnd.Next(70, 300), rnd.Next(1000, 2000), Color.Green);
            plane.SetPosition(rnd.Next(40, 600), rnd.Next(10, 100), pictureBoxAirplane.Width,
           pictureBoxAirplane.Height);

            Draw();
        }

        private void buttonCreateBomber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            plane = new Bomber(rnd.Next(70, 300), rnd.Next(1000, 2000), Color.Gray,
            Color.Black, Color.Gray, Convert.ToInt32(comboBoxBoombs.SelectedItem), FormOfBombs(), true, true, true);
            plane.SetPosition(50, 100, pictureBoxAirplane.Width,
            pictureBoxAirplane.Height);


            buttonSecondForm.Enabled = true;
            buttonFirstForm.Enabled = true;
            buttonThirdForm.Enabled = true;

            Draw();

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

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    plane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}