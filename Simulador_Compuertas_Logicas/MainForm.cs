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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            //Columna 1 Fila 1
            ANDC1F1.Visible = false;
            ORC1F1.Visible = false;
            NANDC1F1.Visible = false;
            XORC1F1.Visible = false;
            NORC1F1.Visible = false; 
            NOTC1F1.Visible = false;
            C1F1ComboBox.Text = " ";

            //Columna 2 Fila 1
            ANDC2F1.Visible = false;
            ORC2F1.Visible = false;
            NANDC2F1.Visible = false;
            XORC2F1.Visible = false;
            NORC2F1.Visible = false;
            NOTC2F1.Visible = false;
            C2F1ComboBox.Text = " ";

            //Columna 3 Fila 1
            ANDC3F1.Visible = false;
            ORC3F1.Visible = false;
            NANDC3F1.Visible = false;
            XORC3F1.Visible = false;
            NORC3F1.Visible = false;
            NOTC3F1.Visible = false;
            C3F1ComboBox.Text = " ";

            //Columna 1 Fila 2
            ANDC1F2.Visible = false;
            ORC1F2.Visible = false;
            NANDC1F2.Visible = false;
            XORC1F2.Visible = false;
            NORC1F2.Visible = false;
            NOTC1F2.Visible = false;
            C1F2ComboBox.Text = " ";

            //Columna 2 Fila 2
            ANDC2F2.Visible = false;
            ORC2F2.Visible = false;
            NANDC2F2.Visible = false;
            XORC2F2.Visible = false;
            NORC2F2.Visible = false;
            NOTC2F2.Visible = false;
            C2F2ComboBox.Text = " ";

            //Columna 3 Fila 2
            ANDC3F2.Visible = false;
            ORC3F2.Visible = false;
            NANDC3F2.Visible = false;
            XORC3F2.Visible = false;
            NORC3F2.Visible = false;
            NOTC3F2.Visible = false;
            C3F2ComboBox.Text = " ";

            //Columna 1 Fila 3
            ANDC1F3.Visible = false;
            ORC1F3.Visible = false;
            NANDC1F3.Visible = false;
            XORC1F3.Visible = false;
            NORC1F3.Visible = false;
            NOTC1F3.Visible = false;
            C1F3ComboBox.Text = " ";

            //Columna 2 Fila 3
            ANDC2F3.Visible = false;
            ORC2F3.Visible = false;
            NANDC2F3.Visible = false;
            XORC2F3.Visible = false;
            NORC2F3.Visible = false;
            NOTC2F3.Visible = false;
            C2F3ComboBox.Text = " ";

            //Columna 3 Fila 3
            ANDC3F3.Visible = false;
            ORC3F3.Visible = false;
            NANDC3F3.Visible = false;
            XORC3F3.Visible = false;
            NORC3F3.Visible = false;
            NOTC3F3.Visible = false;
            C3F3ComboBox.Text = " ";


            //Horizontal
            //Fila 1
            HC1F1V1NumericUpDown.Value = 0;
            HC1F1V2NumericUpDown.Value = 0;
            HC2F1V1NumericUpDown.Value = 0;
            HC2F1V2NumericUpDown.Value = 0;
            HC3F1V1NumericUpDown.Value = 0;
            HC3F1V2NumericUpDown.Value = 0;
            RF1NumericUpDown.Value = 0;

            //Fila 2
            HC1F2V1NumericUpDown.Value = 0;
            HC1F2V2NumericUpDown.Value = 0;
            HC2F2V1NumericUpDown.Value = 0;
            HC2F2V2NumericUpDown.Value = 0;
            HC3F2V1NumericUpDown.Value = 0;
            HC3F2V2NumericUpDown.Value = 0;
            RF2NumericUpDown.Value = 0;

            //Fila 3
            HC1F3V1NumericUpDown.Value = 0;
            HC1F3V2NumericUpDown.Value = 0;
            HC2F3V1NumericUpDown.Value = 0;
            HC2F3V2NumericUpDown.Value = 0;
            HC3F3V1NumericUpDown.Value = 0;
            HC3F3V2NumericUpDown.Value = 0;
            RF3NumericUpDown.Value = 0;

            //Vertical
            //Fila 1
            VC1F1V1NumericUpDown.Value = 0;
            VC1F1V2NumericUpDown.Value = 0;
            VC2F1V1NumericUpDown.Value = 0;
            VC2F1V2NumericUpDown.Value = 0;
            VC3F1V1NumericUpDown.Value = 0;
            VC3F1V2NumericUpDown.Value = 0;
            RC1NumericUpDown.Value = 0;

            //Fila 2
            VC1F2V1NumericUpDown.Value = 0;
            VC1F2V2NumericUpDown.Value = 0;
            VC2F2V1NumericUpDown.Value = 0;
            VC2F2V2NumericUpDown.Value = 0;
            VC3F2V1NumericUpDown.Value = 0;
            VC3F2V2NumericUpDown.Value = 0;
            RC2NumericUpDown.Value = 0;

            //Fila 3
            VC1F3V1NumericUpDown.Value = 0;
            VC1F3V2NumericUpDown.Value = 0;
            VC2F3V1NumericUpDown.Value = 0;
            VC2F3V2NumericUpDown.Value = 0;
            VC3F3V1NumericUpDown.Value = 0;
            VC3F3V2NumericUpDown.Value = 0;
            RC3NumericUpDown.Value = 0;

        }

        public void DeterminarCompuerta(ComboBox combo, PictureBox AND, PictureBox OR, PictureBox NAND, PictureBox XOR, PictureBox NOR, PictureBox NOT)
        {
            if (combo.Text == "AND")
                AND.Visible = true;
            else if (combo.Text == "OR")
                OR.Visible = true;
            else if (combo.Text == "NAND")
                NAND.Visible = true;
            else if (combo.Text == "XOR")
                XOR.Visible = true;
            else if (combo.Text == "NOR")
                NOR.Visible = true;
            else if (combo.Text == "NOT")
                NOT.Visible = true;
        }   

        //Fila 1
        private void C1F1ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 1
        {
            DeterminarCompuerta(C1F1ComboBox, ANDC1F1, ORC1F1, NANDC1F1, XORC1F1, NORC1F1, NOTC1F1);
        }

        private void C2F1ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 2
        {
            DeterminarCompuerta(C2F1ComboBox, ANDC2F1, ORC2F1, NANDC2F1, XORC2F1, NORC2F1, NOTC2F1);
        }

        private void C3F1ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 3
        {
            DeterminarCompuerta(C3F1ComboBox, ANDC3F1, ORC3F1, NANDC3F1, XORC3F1, NORC3F1, NOTC3F1);
        }

        //Fila 2
        private void C1F2ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 1
        {
            DeterminarCompuerta(C1F2ComboBox, ANDC1F2, ORC1F2, NANDC1F2, XORC1F2, NORC1F2, NOTC1F2);
        }

        private void C2F2ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 2
        {
            DeterminarCompuerta(C2F2ComboBox, ANDC2F2, ORC2F2, NANDC2F2, XORC2F2, NORC2F2, NOTC2F2);
        }

        private void C3F2ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 3
        {
            DeterminarCompuerta(C3F2ComboBox, ANDC3F2, ORC3F2, NANDC3F2, XORC3F2, NORC3F2, NOTC3F2);
        }

        //Fila 3
        private void C1F3ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 1
        {
            DeterminarCompuerta(C1F3ComboBox, ANDC1F3, ORC1F3, NANDC1F3, XORC1F3, NORC1F3, NOTC1F3);
        }

        private void C2F3ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 2
        {
            DeterminarCompuerta(C2F3ComboBox, ANDC2F3, ORC2F3, NANDC2F3, XORC2F3, NORC2F3, NOTC2F3);
        }

        private void C3F3ComboBox_SelectedIndexChanged(object sender, EventArgs e)//Columna 3
        {
            DeterminarCompuerta(C3F3ComboBox, ANDC3F3, ORC3F3, NANDC3F3, XORC3F3, NORC3F3, NOTC3F3);
        }

        public void Calcular(NumericUpDown Valor1, NumericUpDown Valor2, NumericUpDown Resultado, ComboBox Combo)
        {
            if (Combo.Text == "AND")
            {
                if (Valor1.Value == 1 && Valor2.Value == 1)
                    Resultado.Value = 1;
                else
                    Resultado.Value = 0;
            }
            else if (Combo.Text == "OR")
            {
                if (Valor1.Value == 0 && Valor2.Value == 0)
                    Resultado.Value = 0;
                else
                    Resultado.Value = 1;
            }
            else if (Combo.Text == "NAND")
            {
                if (Valor1.Value == 1 && Valor2.Value == 1)
                    Resultado.Value = 0;
                else
                    Resultado.Value = 1;
            }
            else if (Combo.Text == "XOR")
            {
                if (Valor1.Value == Valor2.Value)
                    Resultado.Value = 0;
                else
                    Resultado.Value = 1;
            }
            else if (Combo.Text == "NOR")
            {
                if (Valor1.Value == 0 && Valor2.Value == 0)
                    Resultado.Value = 1;
                else
                    Resultado.Value = 0;
            }
            else if (Combo.Text == "NOT")
            {
                if (Valor1.Value == 0)
                    Resultado.Value = 1;
                else
                    Resultado.Value = 0;
            }
        }

        //------------------------Confirmar------------------------//
        private void Confirmar1Button_Click(object sender, EventArgs e)
        {
            Calcular(HC1F1V1NumericUpDown, HC1F1V2NumericUpDown, HC2F1V1NumericUpDown, C1F1ComboBox);
            Calcular(VC1F1V1NumericUpDown, VC1F1V2NumericUpDown, VC1F2V1NumericUpDown, C1F1ComboBox);
        }

        private void Confirmar2Button_Click(object sender, EventArgs e)
        {
            Calcular(HC2F1V1NumericUpDown, HC2F1V2NumericUpDown, HC3F1V1NumericUpDown, C2F1ComboBox);
            Calcular(VC2F1V1NumericUpDown, VC2F1V2NumericUpDown, VC2F2V1NumericUpDown, C2F1ComboBox);
        }

        private void Confirmar3button_Click(object sender, EventArgs e)
        {
            Calcular(HC3F1V1NumericUpDown, HC3F1V2NumericUpDown, RF1NumericUpDown, C3F1ComboBox);
            Calcular(VC3F1V1NumericUpDown, VC3F1V2NumericUpDown, VC3F2V1NumericUpDown, C3F1ComboBox);
        }

        private void ConfirmarC1F2Button_Click(object sender, EventArgs e)
        {
            Calcular(HC1F2V1NumericUpDown, HC1F2V2NumericUpDown, HC2F2V1NumericUpDown, C1F2ComboBox);
            Calcular(VC1F2V1NumericUpDown, VC1F2V2NumericUpDown, VC1F3V1NumericUpDown, C1F2ComboBox);
        }

        private void ConfirmarC2F2Button_Click(object sender, EventArgs e)
        {
            Calcular(HC2F2V1NumericUpDown, HC2F2V2NumericUpDown, HC3F2V1NumericUpDown, C2F2ComboBox);
            Calcular(VC2F2V1NumericUpDown, VC2F2V2NumericUpDown, VC2F3V1NumericUpDown, C2F2ComboBox);
        }

        private void ConfirmarC3F2Button_Click(object sender, EventArgs e)
        {
            Calcular(HC3F2V1NumericUpDown, HC3F2V2NumericUpDown, RF2NumericUpDown, C3F2ComboBox);
            Calcular(VC3F2V1NumericUpDown, VC3F2V2NumericUpDown, VC3F3V1NumericUpDown, C3F2ComboBox);
        }

        private void ConfirmarC1F3Button_Click(object sender, EventArgs e)
        {
            Calcular(HC1F3V1NumericUpDown, HC1F3V2NumericUpDown, HC2F3V1NumericUpDown, C1F3ComboBox);
            Calcular(VC1F3V1NumericUpDown, VC1F3V2NumericUpDown, RC1NumericUpDown, C1F3ComboBox);
        }

        private void ConfirmarC2F3Button_Click(object sender, EventArgs e)
        {
            Calcular(HC2F3V1NumericUpDown, HC2F3V2NumericUpDown, HC3F3V1NumericUpDown, C2F3ComboBox);
            Calcular(VC2F3V1NumericUpDown, VC2F3V2NumericUpDown, RC2NumericUpDown, C2F3ComboBox);
        }

        private void ConfirmarC3F3Button_Click(object sender, EventArgs e)
        {
            Calcular(HC3F3V1NumericUpDown, HC3F3V2NumericUpDown, RF3NumericUpDown, C3F3ComboBox);
            Calcular(VC3F3V1NumericUpDown, VC3F3V2NumericUpDown, RC3NumericUpDown, C3F3ComboBox);
        }
    }
}
