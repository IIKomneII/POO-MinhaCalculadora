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
        int numero1 = 0, numero2 = 0, resultado = 0, contador = 0;

            do
            {
                numero1 = int.Parse(txtNumero1.Text);
                numero2 = int.Parse(txtNumero2.Text);

                Calculadora calcular = new Calculadora();

                string operacao = cmbFun��es.SelectedItem.ToString();

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
                        MessageBox.Show("Opera��o inv�lida.");
                        return;
                }

                List<int> lista = new List<int>();

                lista.Add(resultado);

                lblResultado.Text = string.Join(", ", lista);

                contador += contador;
            }
            while (contador < 10);

                this.Close();
        }
    }
}
