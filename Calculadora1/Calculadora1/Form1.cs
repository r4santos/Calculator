using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_limpar(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_sair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mais(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Não é possivel fazer o cálculo");
            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int resultado = num1 + num2;
                textBox3.Text = resultado.ToString();
            }
        }

        private void btn_menos(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int resultado = num1 - num2;
            textBox3.Text = resultado.ToString();
        }

        private void btn_mult(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int resultado = num1 * num2;
            textBox3.Text = resultado.ToString();
        }

        private void btn_div(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resultado = num1 / num2;
            textBox3.Text = resultado.ToString();
        }
    }
}
