using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex3
{
    class Aluno
    {
        public double N1, N2, N3;
        public string Nome;

        public double Media()
        {
            return ((N1 + N2 + N3) / 3);
        }
    }
}
