using System;

namespace MeuProjetoUrbs
{
    public class CartaoUrbs
    {
        public int Id { get; set; } 
        public string Titular { get; set; }
        
        public double Saldo { get; set; } 

        public CartaoUrbs() { }

        public CartaoUrbs(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Recarregar(double valor)
        {
            if (valor > 0) Saldo += valor;
        }

        public void PagarPassagem(double valor)
        {
            if (Saldo >= valor) Saldo -= valor;
        }
    }
}