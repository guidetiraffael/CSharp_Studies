using System;

namespace MeuProjetoUrbs{
    public class CartaoUrbs
    {
        // Propriedades (O que o cartão TEM)
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtor (Como o cartão nasce)
        public CartaoUrbs(string nomeInicial, double saldoInicial)
        {
            Titular = nomeInicial;
            Saldo = saldoInicial;
        }

        // Métodos (O que o cartão FAZ)
        public void Recarregar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"✅ Recarga de R$ {valor:F2} efetuada para {Titular}.");
            }
        }

        public void PagarPassagem(double valorPassagem)
        {
            if (Saldo >= valorPassagem)
            {
                Saldo -= valorPassagem;
                Console.WriteLine($"🎫 Giro da catraca liberado! Saldo restante: R$ {Saldo:F2}");
            }
            else
            {
                Console.WriteLine("❌ Saldo insuficiente para esta viagem.");
            }
        }
    }
}