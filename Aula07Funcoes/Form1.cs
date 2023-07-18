using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07Funcoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Minhas Funções
        void MostraMensagem() 
        {
            MessageBox.Show("Olá seja bem vindo!");
            MessageBox.Show("Faça login para continuar...");
            MostraNome();
        }

        void MostraNome()
        {
            string nome = textBox1.Text;
            MessageBox.Show("Óla, " + nome);
        }

        double converteDinheiro( Label dindin )
        {
            double dinheiro = double.Parse(dindin.Text.Replace("R$",""));
            return dinheiro;  
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostraMensagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MostraNome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox2.Text);
            double dinheiro = converteDinheiro(label1);
            double soma = valor + dinheiro;
            label1.Text = "R$" + soma;
        }
    }
}
