using System;
using MeuProjetoUrbs; // Indica que vamos usar o que está no namespace acima

Console.WriteLine("--- Iniciando Sistema URBS Object-Oriented ---");

// Criando uma "instância" do objeto
CartaoUrbs meuCartao = new CartaoUrbs("Raffael Guideti", 10.00);

// Interagindo com o objeto
meuCartao.PagarPassagem(6.00);
meuCartao.Recarregar(20.00);
meuCartao.PagarPassagem(6.00);

Console.WriteLine($"--- Fim da operação. Saldo final: R$ {meuCartao.Saldo:F2} ---");