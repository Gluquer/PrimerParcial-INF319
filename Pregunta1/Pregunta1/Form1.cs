using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta1
{
    public partial class Form1 : Form
    {
        int valor;
        int valor1;
        int resultado;
        int sws = 0, swr=0, swm =0,swd=0;
        
        public Form1()
        {
            InitializeComponent();
            valor = 0;
            valor1 = 0;
            resultado = 0;
            sws = swr = swm = swd = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != ("+") && ((Button)sender).Text != ("-") && ((Button)sender).Text != ("*")
                && ((Button)sender).Text != ("/") && ((Button)sender).Text != ("C") && ((Button)sender).Text != ("="))
            {
                valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
                textBox1.Text = valor.ToString();
            }
            else
            {
                if (((Button)sender).Text.Equals("="))
                {
                    if (sws == 1)
                    {
                        resultado = valor1 + valor;
                    }
                    if (swr == 1)
                    {
                        resultado = valor1 - valor;
                    }
                    if (swm == 1)
                    {
                        resultado = valor1 * valor;
                    }
                    if (swd == 1)
                    {
                        if (valor != 0) { 
                            resultado = valor1 / valor;
                        }
                    }
                    textBox1.Text = resultado.ToString();
                    resultado = 0;
                    sws = swr = swm = swd = 0;
                }
                else
                {
                    valor1 = valor;
                    if (((Button)sender).Text.Equals("+"))
                    {

                        textBox1.Text = "";
                        //resultado = valor + valor1;
                        valor1 = valor;
                        valor = 0;
                        sws = 1;
                    }
                    if (((Button)sender).Text.Equals("-"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swr = 1;
                    }
                    if (((Button)sender).Text.Equals("*"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swm = 1;
                    }
                    if (((Button)sender).Text.Equals("/"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swd = 1;
                    }
                }
            }
            
    }

        private void button16_Click(object sender, EventArgs e)
        {
            valor = 0;
            textBox1.Text = "";
            valor1 = 0;
            resultado = 0;
            sws = swr = swm = swd = 0;
        }
    }
}
