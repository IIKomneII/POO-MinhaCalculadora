using MinhaCalculadora.Models;
using System.Runtime.InteropServices;

namespace MinhaCalculadora
{
    public partial class MinhaCalculadora : Form
    {
        public MinhaCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        int numero1, numero2, resultado;

            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);

            Calculadora calcular = new Calculadora();

            string operacao = cmbFunções.SelectedItem.ToString();

            switch (operacao)
            {
                case "+":
                    resultado = calcular.Somar(numero1, numero2);
                    break;
                case "-":
                    resultado = calcular.Subtrair(numero1, numero2);
                    break;
                case "x":
                    resultado = calcular.Multiplicar(numero1, numero2);
                    break;
                case "/":
                    resultado = calcular.Dividir(numero1, numero2);
                    break;
                default:
                    MessageBox.Show("Operação inválida.");
                    return;
            }

            lblResultado.Text = resultado.ToString();
        }
    }
}
