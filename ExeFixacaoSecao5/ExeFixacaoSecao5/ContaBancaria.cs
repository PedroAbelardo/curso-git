using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeFixacaoSecao5
{
    class ContaBancaria
    {
        public int Nconta { get; private set; }
        public string NomeT { get; set; }
        public double Saldo { get; private set; }
        public ContaBancaria(int nomeconta, string nometitular)
        {
            Nconta = nomeconta;
            NomeT = nometitular;
        }
        public ContaBancaria(int nomeconta,string nometitular,double valordep) : this(nomeconta,nometitular)
        {
            Deposito(valordep); /*dessa forma se a alteração de depósito mudar, automaticamente 
            muda o Deposit(valordep) vai ficar atualizado também*/
        }
        public override string ToString()
        {
            return "Conta " 
                + Nconta + ", Titular: " 
                + NomeT + ", Saldo: $ " 
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }
    }
}
