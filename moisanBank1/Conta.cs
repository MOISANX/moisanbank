using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moisanBank1
{
    internal class Conta
    {
        private decimal saldo;

        public void Deposita(decimal valor)
        {
            saldo += valor;
        }

        public void Saca(decimal valor)
        {
            saldo -= valor;
        }

        public decimal ConsultaSaldo()
        {
            return saldo;
        }

    }
}
