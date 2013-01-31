using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {

        Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaCorrente();
            conta.Numero = 12;
            conta.Titular = new Cliente("Armando");

            try
            {
                conta.Deposita(100);
                conta.Saca(500);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }
    }
}
