using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Compuertas_Logicas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Form mainForm = new Form();
            //mainForm.WindowState = FormWindowState.Maximized;

            //this.WindowState = FormWindowState.Maximized;

            this.Controls.OfType<Control>().Where(ctr => ctr is PictureBox).ToList().ForEach(ctr =>
            {
                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;
            });
        }

        //mouse_down, mouse_up, mouse_move
        bool down = false;
        Point inicial;

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
            }
        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) 
        {
            down = false;
            
            Control ctr = (Control)sender;

            if ((ctr.Left >= 100 && ctr.Left <= 206) && (ctr.Top >= 203 && ctr.Top <= 353))//Primera Casilla
            {
                ctr.Location = new Point(111, 223);
                Compuerta1Label.Text = ctr.Name;
            }
            else if ((ctr.Left >= 337 && ctr.Left <= 443) && (ctr.Top >= 203 && ctr.Top <= 353))//Primera Casilla
            {
                ctr.Location = new Point(349, 223);
                Compuerta2Label.Text = ctr.Name;
            }
            else if ((ctr.Left >= 570 && ctr.Left <= 676) && (ctr.Top >= 203 && ctr.Top <= 353))
            {
                ctr.Location = new Point(583, 222);
                Compuerta3Label.Text = ctr.Name;
            }
        }

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                down = true;
                inicial = e.Location;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Confirmar1Button_Click(object sender, EventArgs e)
        {
            C1V1NumericUpDown.Enabled = false;
            C1V2NumericUpDown.Enabled = false;

            if (Compuerta1Label.Text == "AND")
            {
                if (C1V1NumericUpDown.Value == 1 && C1V2NumericUpDown.Value == 1)
                    C2V1NumericUpDown.Value = 1;
                else
                    C2V1NumericUpDown.Value = 0;

                C2V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta1Label.Text == "OR")
            {
                if (C1V1NumericUpDown.Value == 0 && C1V2NumericUpDown.Value == 0)
                    C2V1NumericUpDown.Value = 0;
                else
                    C2V1NumericUpDown.Value = 1;

                C2V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta1Label.Text == "NAND")
            {
                if (C1V1NumericUpDown.Value == 1 && C1V2NumericUpDown.Value == 1)
                    C2V1NumericUpDown.Value = 0;
                else
                    C2V1NumericUpDown.Value = 1;

                C2V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta1Label.Text == "XOR")
            {
                if (C1V1NumericUpDown.Value == C1V2NumericUpDown.Value)
                    C2V1NumericUpDown.Value = 0;
                else
                    C2V1NumericUpDown.Value = 1;

                C2V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta1Label.Text == "NOR")
            {
                if (C1V1NumericUpDown.Value == 0 && C1V2NumericUpDown.Value == 0)
                    C2V1NumericUpDown.Value = 1;
                else
                    C2V1NumericUpDown.Value = 0;

                C2V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta1Label.Text == "NOT")
            {
                if (C1V1NumericUpDown.Value == 0)
                    C2V1NumericUpDown.Value = 1;
                else
                    C2V1NumericUpDown.Value = 0;

                C2V1NumericUpDown.Enabled = false;
            }
        }

        private void Confirmar2Button_Click(object sender, EventArgs e)
        {
            C2V1NumericUpDown.Enabled = false;
            C2V2NumericUpDown.Enabled = false;

            if (Compuerta2Label.Text == "AND")
            {
                if (C2V1NumericUpDown.Value == 1 && C2V2NumericUpDown.Value == 1)
                    C3V1NumericUpDown.Value = 1;
                else
                    C3V1NumericUpDown.Value = 0;

                C3V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta2Label.Text == "OR")
            {
                if (C2V1NumericUpDown.Value == 0 && C2V2NumericUpDown.Value == 0)
                    C3V1NumericUpDown.Value = 0;
                else
                    C3V1NumericUpDown.Value = 1;

                C3V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta2Label.Text == "NAND")
            {
                if (C2V1NumericUpDown.Value == 1 && C2V2NumericUpDown.Value == 1)
                    C3V1NumericUpDown.Value = 0;
                else
                    C3V1NumericUpDown.Value = 1;

                C3V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta2Label.Text == "XOR")
            {
                if (C2V1NumericUpDown.Value == C2V2NumericUpDown.Value)
                    C3V1NumericUpDown.Value = 0;
                else
                    C3V1NumericUpDown.Value = 1;

                C3V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta2Label.Text == "NOR")
            {
                if (C2V1NumericUpDown.Value == 0 && C2V2NumericUpDown.Value == 0)
                    C3V1NumericUpDown.Value = 1;
                else
                    C3V1NumericUpDown.Value = 0;

                C3V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta2Label.Text == "NOT")
            {
                if (C2V1NumericUpDown.Value == 0)
                    C3V1NumericUpDown.Value = 1;
                else
                    C3V1NumericUpDown.Value = 0;

                C3V1NumericUpDown.Enabled = false;
            }
        }

        private void Confirmar3button_Click(object sender, EventArgs e)
        {
            C3V1NumericUpDown.Enabled = false;
            C3V2NumericUpDown.Enabled = false;

            if (Compuerta3Label.Text == "AND")
            {
                if (C3V1NumericUpDown.Value == 1 && C3V2NumericUpDown.Value == 1)
                    C4V1NumericUpDown.Value = 1;
                else
                    C4V1NumericUpDown.Value = 0;

                C4V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta3Label.Text == "OR")
            {
                if (C3V1NumericUpDown.Value == 0 && C3V2NumericUpDown.Value == 0)
                    C4V1NumericUpDown.Value = 0;
                else
                    C4V1NumericUpDown.Value = 1;

                C4V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta3Label.Text == "NAND")
            {
                if (C3V1NumericUpDown.Value == 1 && C3V2NumericUpDown.Value == 1)
                    C4V1NumericUpDown.Value = 0;
                else
                    C4V1NumericUpDown.Value = 1;

                C4V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta3Label.Text == "XOR")
            {
                if (C3V1NumericUpDown.Value == C3V2NumericUpDown.Value)
                    C4V1NumericUpDown.Value = 0;
                else
                    C4V1NumericUpDown.Value = 1;

                C4V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta3Label.Text == "NOR")
            {
                if (C3V1NumericUpDown.Value == 0 && C3V2NumericUpDown.Value == 0)
                    C4V1NumericUpDown.Value = 1;
                else
                    C4V1NumericUpDown.Value = 0;

                C4V1NumericUpDown.Enabled = false;
            }
            else if (Compuerta3Label.Text == "NOT")
            {
                if (C3V1NumericUpDown.Value == 0)
                    C4V1NumericUpDown.Value = 1;
                else
                    C4V1NumericUpDown.Value = 0;

                C4V1NumericUpDown.Enabled = false;
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            AND.Location = new Point(89, 66);
            OR.Location = new Point(200, 66);
            NAND.Location = new Point(308, 66);
            XOR.Location = new Point(418, 66);
            NOR.Location = new Point(524, 66);
            NOT.Location = new Point(632, 66);

            C1V1NumericUpDown.Value = 0;
            C1V2NumericUpDown.Value = 0;
            C2V1NumericUpDown.Value = 0;
            C2V2NumericUpDown.Value = 0;
            C3V1NumericUpDown.Value = 0;
            C3V2NumericUpDown.Value = 0;
            C4V1NumericUpDown.Value = 0;

            C1V1NumericUpDown.Enabled = true;
            C1V2NumericUpDown.Enabled = true;
            C2V2NumericUpDown.Enabled = true;
            C3V2NumericUpDown.Enabled = true;
        }
    }
}
