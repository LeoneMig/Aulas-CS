using System.Globalization;

namespace Ex5
{
    internal class Conta
    {
        public string Nome { get; private set; }
        public int CNumber { get; private set; }

        public double Valor { get; private set; }

        public Conta(string nome, int cNumber, double valor)
        {
            Nome = nome;
            CNumber = cNumber;
            Valor = valor;
        }

        public void Deposito(double new_value)
        {
            Valor += new_value;
        }

        public void Saque(double v_saque)
        {
            if (Valor > v_saque + 5.0)
            {
                Valor -= (v_saque + 5.0);
            }
            else
            {
                Console.WriteLine("Valor indisponível para saque!");
            }
        }

        public override string ToString()
        {
            return "Conta " + CNumber + ", Titular: " + Nome + ", Saldo: $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
