using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Marcus_Marrero
{
    public partial class Form1 : Form
    {
        private double num1, num2, resultado;
        private int op;

        public Form1()
        {
            InitializeComponent();
            PanelEstan.Visible = true;
            PanelProgra.Visible = false;
            PanelCientifica.Visible = false;
            this.ClientSize = new Size(400, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Limpiar toda la barra "C"
            MostrarNum.Text = "";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            MostrarNum.Text = "";
            op = 1;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            MostrarNum.Text = "";
            op = 2;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            MostrarNum.Text = "";
            op = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //boton de division
            num1 = Convert.ToDouble(MostrarNum.Text);
            MostrarNum.Text = "";
            op = 4;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(MostrarNum.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
            }

            MostrarNum.Text = resultado.ToString();
        }

        private void btnPtoDec_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = MostrarNum.Text + ".";
        }

        private void btnSupr_Click(object sender, EventArgs e)
        {
            if (MostrarNum.Text.Length > 0)
            {
                MostrarNum.Text = MostrarNum.Text.Substring(0, MostrarNum.Text.Length - 1);
            }
            //gracias stackoverflow
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            resultado = Math.Sqrt(num1);
            MostrarNum.Text = resultado.ToString();
        }

        private void btnPctg_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            resultado = num1 / 100;
            MostrarNum.Text = resultado.ToString();
        }

        private void btnFraccion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            resultado = 1 / num1;
            MostrarNum.Text = resultado.ToString();
        }

        private void btnMasMen_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(MostrarNum.Text);
            resultado = -num1;
            MostrarNum.Text = resultado.ToString();
        }

        private void PanelEstan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelProgra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModoEstandar_Click(object sender, EventArgs e)
        {
            PanelEstan.Visible = true;
            PanelProgra.Visible = false;
            PanelCientifica.Visible = false;
            this.ClientSize = new Size(400, 500);
        }

        private void ModoProgramadora_Click(object sender, EventArgs e)
        {
            PanelEstan.Visible = false;
            PanelProgra.Visible = true;
            PanelCientifica.Visible = false;
            this.ClientSize = new Size(670, 500);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button4.Enabled = false;

            button14.Enabled = true;
            button15.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true; 
            button6.Enabled = true; 
            button7.Enabled = true; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button4.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            button23.Enabled = true;
            button22.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button4.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button23.Enabled = false;
            button22.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button4.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            resultado = -num1;
            textBox1.Text = resultado.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            resultado = Math.Sqrt(num1);
            textBox1.Text = resultado.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
            }

            textBox1.Text = resultado.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            resultado = 1 / num1;
            textBox1.Text = resultado.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            resultado = num1 / 100;
            textBox1.Text = resultado.ToString();
        }

        private void MostrarNum_TextChanged(object sender, EventArgs e)
        {

        }

        //CIENTIFICA
        private void modoCientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelEstan.Visible = false;
            PanelProgra.Visible = false;
            PanelCientifica.Visible = true;
            this.ClientSize = new Size(670, 500);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "0";
        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "1";
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "2";
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "3";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "4";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "5";
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "6";
        }

        private void button89_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "7";
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "8";
        }

        private void button80_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + "9";
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + ".";
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button84_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button83_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = -num1;
            textBox4.Text = resultado.ToString();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Sqrt(num1);
            textBox4.Text = resultado.ToString();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = num1 / 100;
            textBox4.Text = resultado.ToString();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = 1 / num1;
            textBox4.Text = resultado.ToString();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 1;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 2;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 3;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 4;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox4.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    break;
            }

            textBox4.Text = resultado.ToString();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Log(num1);
            textBox4.Text = resultado.ToString();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = 1 / num1;
            textBox4.Text = resultado.ToString();
        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Pow(num1, 2);
            textBox4.Text = resultado.ToString();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Sin(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Sinh(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Round(num1);
            textBox4.Text = resultado.ToString();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Cosh(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Cos(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Tan(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Tanh(num1 * Math.PI / 180);
            textBox4.Text = resultado.ToString();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Log10(num1);
            textBox4.Text = resultado.ToString();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            resultado = Math.Pow(num1, 3);
            textBox4.Text = resultado.ToString();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 5;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            MostrarNum.Text = "";
        }

        private void button50_Click(object sender, EventArgs e)
        {

        }
    }
}
