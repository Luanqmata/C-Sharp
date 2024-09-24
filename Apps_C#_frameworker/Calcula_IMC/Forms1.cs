using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float peso) &&
                float.TryParse(textBox2.Text, out float altura) &&
                altura > 0)
            {
                float imc = peso / (altura * altura);

                label5.Text = $"{imc:F2}";

                string resultado;
                if (imc < 18.5)
                {
                    resultado = "Você está abaixo do peso. ⚠️";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    resultado = "Você está com o peso normal. 🎯";
                }
                else if (imc >= 25 && imc < 30)
                {
                    resultado = "Você está com sobrepeso. 🔔";
                }
                else 
                {
                    resultado = "Você está com obesidade. 🚨";
                }


                label6.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
