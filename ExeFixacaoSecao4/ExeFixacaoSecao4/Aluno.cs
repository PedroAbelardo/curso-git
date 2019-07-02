using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFixacaoSecao4
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }
        public bool ConceitoFinal()
        {
            if (NotaFinal() >= 60)
                return true;
            else
                return false;
        }
        public double Recuperacao()
        {
            return 60 - NotaFinal();
        }
    }
}
