using System;

Console.WriteLine("---Sistema de Transporte URBS (Protótipo)---");

string nomeUsuario = "Raffael";
double saldo = 2.00;
double valorPassagem = 6.00;

Console.WriteLine($"Usuário: {nomeUsuario}");
Console.WriteLine($"Saldo Atual: R$ {saldo:F2}");

if (saldo >= valorPassagem)
{
    saldo -= valorPassagem; 
    Console.WriteLine("✅ Acesso Liberado! Boa viagem.");
    Console.WriteLine($"Novo saldo: R$ {saldo:F2}");
}
else
{
    Console.WriteLine("❌ Saldo Insuficiente. Por favor, recarregue seu cartão.");
}