using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calcula_IMC
{
    public partial class Form1 : Form
    {
        private int Id_pessoa = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Peso (kg)";
            dataGridView1.Columns[2].Name = "Altura (m)";
            dataGridView1.Columns[3].Name = "IMC";
            dataGridView1.Columns[4].Name = "Nome:";
            dataGridView1.Columns[5].Name = "Qualf.";

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 70;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 22)
            {
                MessageBox.Show("O limite de 20 credenciais foi atingido.");
                return; 
            }

            if (float.TryParse(textBox1.Text, out float peso) &&
                float.TryParse(textBox2.Text, out float altura) &&
                altura > 0)
            {
                string nome = textBox3.Text;

                try
                {
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new ArgumentException("O nome não pode ser vazio ou conter apenas espaços em branco.");
                    }

                    if (nome.Any(c => !Char.IsLetter(c)))
                    {
                        throw new ArgumentException("O nome não pode conter números ou caracteres especiais.");
                    }

                    float imc = peso / (altura * altura);

                    label5.Text = $"{imc:F2}";

                    string resultado;
                    string qualificacao;

                    if (imc < 18.5)
                    {
                        resultado = "Você está abaixo do peso. ⚠️";
                        qualificacao = "Abaixo/peso";
                    }
                    else if (imc >= 18.5 && imc < 25)
                    {
                        resultado = "Você está com o peso normal. 🎯";
                        qualificacao = "Normal";
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        resultado = "Você está com sobrepeso. 🔔";
                        qualificacao = "Acima/Peso";
                    }
                    else
                    {
                        resultado = "Você está com obesidade. 🚨";
                        qualificacao = "Obesidade";
                    }
                    label6.Text = resultado;

                    dataGridView1.Rows.Add(Id_pessoa, peso.ToString("F2"), altura.ToString("F2"), imc.ToString("F2"), nome, qualificacao);

                    Id_pessoa++;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0)
                {
                    throw new InvalidOperationException("Não há nada para remover, adicione algum registro.");
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label6.Text = "";
                label5.Text = "";

                dataGridView1.Rows.Clear();
                DesmarcarTodasCheckboxes();
                Id_pessoa = 1;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 21) 
            {
                MessageBox.Show("O limite de 20 credenciais foi atingido.");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> linhasParaRemover = new List<int>();

            if (checkBox1.Checked) linhasParaRemover.Add(0);
            if (checkBox2.Checked) linhasParaRemover.Add(1);
            if (checkBox3.Checked) linhasParaRemover.Add(2);
            if (checkBox4.Checked) linhasParaRemover.Add(3);
            if (checkBox5.Checked) linhasParaRemover.Add(4);
            if (checkBox6.Checked) linhasParaRemover.Add(5);
            if (checkBox7.Checked) linhasParaRemover.Add(6);
            if (checkBox8.Checked) linhasParaRemover.Add(7);
            if (checkBox9.Checked) linhasParaRemover.Add(8);
            if (checkBox10.Checked) linhasParaRemover.Add(9);
            if (checkBox11.Checked) linhasParaRemover.Add(10);
            if (checkBox12.Checked) linhasParaRemover.Add(11);
            if (checkBox13.Checked) linhasParaRemover.Add(12);
            if (checkBox14.Checked) linhasParaRemover.Add(13);
            if (checkBox15.Checked) linhasParaRemover.Add(14);
            if (checkBox16.Checked) linhasParaRemover.Add(15);
            if (checkBox17.Checked) linhasParaRemover.Add(16);
            if (checkBox18.Checked) linhasParaRemover.Add(17);
            if (checkBox19.Checked) linhasParaRemover.Add(18);
            if (checkBox20.Checked) linhasParaRemover.Add(19);
            if (checkBox21.Checked) linhasParaRemover.Add(20);

            if (linhasParaRemover.Count > 0)
            {
                foreach (int linha in linhasParaRemover.OrderByDescending(i => i))
                {
                    RemoverLinha(linha);
                    if (Id_pessoa > 1) Id_pessoa--;
                    label6.Text = "";
                    label5.Text = "";
                }
                DesmarcarTodasCheckboxes();
            }
            else
            {
                MessageBox.Show("Nenhuma Check Box Marcada , Marque uma para remover");
            }
        }

        private void RemoverLinha(int indice)
        {
            if (dataGridView1.Rows.Count > indice)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(indice);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar remover o registro no índice " + indice + ": " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não Há Nada Armazenado ali, Marque uma Check Box que contenha alguma Informação.");
            }
        }

        private void DesmarcarTodasCheckboxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
        }
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 22)
            {
                MessageBox.Show("O limite de 20 credenciais foi atingido.");
                return;
            }

            Random random = new Random();

            float pesoAleatorio = (float)(random.Next(40, 120) + random.NextDouble()); 
            float alturaAleatoria = 1.50f + (float)(random.NextDouble() * 0.50);

            float imc = pesoAleatorio / (alturaAleatoria * alturaAleatoria);

            string[] nomes = { "Romes", "Sandir", "Juliana", "joão", "Cauê", "Luan", "Pedro", "Pablo", "Daniela", "Rafaela","Habert","Veronica","Thiago","luis","Vitor","Daniel","Gabi","Gabriel","Jonas","Cida","Ivone","Kaic","Paulo","Gabriela","Thaina","Não posso morrer!" };
            string nomeAleatorio = nomes[random.Next(nomes.Length)];

            string qualificacao;
            if (imc < 18.5)
            {
                qualificacao = "Magro";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                qualificacao = "IMC Normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                qualificacao = "Acima Peso";
            }
            else
            {
                if (imc >= 30 && imc < 35)
                {
                    qualificacao = "Obeso I";
                }
                else if (imc >= 35 && imc < 40)
                {
                    qualificacao = "Obeso II";
                }
                else
                {
                    qualificacao = "Obeso III";
                }
            }

            dataGridView1.Rows.Add(Id_pessoa, pesoAleatorio.ToString("F2"), alturaAleatoria.ToString("F2"), imc.ToString("F2"), nomeAleatorio, qualificacao);
            Id_pessoa++;
        }

    }
}
