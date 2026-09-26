using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor = 0;
        string operacao = "";

        // Cultura brasileira: usa vírgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //Indica se o último comando foi o botão =
        bool novoCalculo = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        //Números 
        private void AdicionarNumero(String numero)
        {
            //Se acabou de calcular, começa um novo número
            if (novoCalculo)
            {
                txtResultado.Text = "";
                novoCalculo = false;
            }
            txtResultado.Text += numero;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }
    }
