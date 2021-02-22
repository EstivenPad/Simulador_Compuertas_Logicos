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
            this.Controls.OfType<Control>().Where(ctr => ctr is GroupBox).ToList().ForEach(ctr =>
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
    }
}
