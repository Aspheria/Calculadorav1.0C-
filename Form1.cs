using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form

    {
        Calculadora CalculadoraV1 = new Calculadora(); //instanciar uma classe

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BSubtracao_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
              result.Text = Calcular(OperationType.Subtracao);
            }
        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
                
                result.Text = Calcular(OperationType.Divisao);
            }
        }

        private void BAdicao_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
                result.Text = Calcular(OperationType.Adicao);
            }
        }
        private void bMultiplicacao_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
             result.Text = Calcular(OperationType.Multiplicao);
            }
        }

        private bool Validacao()
        {
            if (string.IsNullOrEmpty(txtValor1.Text) || string.IsNullOrEmpty(txtValor2.Text))
            {
                MessageBox.Show("nenhuma resposta, informe um valor");
                return false;
            }
            else
            {
                return true;
            }
        }

        private string Calcular(OperationType type)
        {
            return CalculadoraV1.Calcular(
                txtValor1.Text,
                txtValor2.Text,
                type
                ).ToString();
        }
    }
}
