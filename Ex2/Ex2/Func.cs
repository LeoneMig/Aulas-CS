using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex2
{
    class Func
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double pct)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * pct / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
