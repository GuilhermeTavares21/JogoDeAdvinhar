using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class Form1 : Form
    {
        private int numberGenerate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Number jogo = new Number();
            numberGenerate = jogo.Numero();
           
        }

        private void Resposta_Click(object sender, EventArgs e)
        {

        }

        private void Chute_Click(object sender, EventArgs e)
        {
            int numeroJogador = int.Parse(txtNumeroJogador.Text);
            Number jogo = new Number();
            if (jogo.Jogar(numeroJogador,numberGenerate) == Number.Resultado.PerderMenor)
            {
                Resposta.Text = "O número que você advinhou é menor! Tente um maior";
                Resposta.ForeColor = Color.Red;

            } else if (jogo.Jogar(numeroJogador,numberGenerate) == Number.Resultado.PerderMaior)
            {
                Resposta.Text = "O número que você advinhou é maior! Tente um menor";
                Resposta.ForeColor = Color.Red;
            } else if (jogo.Jogar(numeroJogador, numberGenerate) == Number.Resultado.Ganhar)
            {
                Resposta.Text = "PARABÉNS! VOCÊ ACERTOU";
                Resposta.ForeColor = Color.Green;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
