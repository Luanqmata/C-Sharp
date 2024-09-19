using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Feito por Luan C";
            //nome 
            string nome = textBox1.Text;
            //data
            DateTime dataNascimento = dateTimePicker1.Value;

            //calculo
            int idade = DateTime.Now.Year - dataNascimento.Year;

            //ajustar a idade se a pessoa nao tiver feito aniverssario
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade--;
            }
            // exibir a idade label 4

            label4.Text = $"Olá, {nome} , voçê tem a idade de: {idade} anos.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            label4.Text = "";
            label5.Text = "Calcula Idade";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
