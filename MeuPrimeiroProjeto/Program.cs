using System;
using System.Linq;
using MeuProjetoUrbs;

using (var db = new AppDbContext())
{ 
    Console.WriteLine("Verificando banco de dados...");
    db.Database.EnsureCreated(); 

    var meuCartao = db.Cartoes.FirstOrDefault();

    if (meuCartao == null)
    {
        
        Console.WriteLine("Banco vazio! Criando registro inicial para Raffael...");
        meuCartao = new CartaoUrbs("Raffael Guideti", 50.00);
        db.Cartoes.Add(meuCartao);
        db.SaveChanges(); // Salva no arquivo urbs.db
    }
    else
    {
        Console.WriteLine($"Bem-vindo de volta, {meuCartao.Titular}!");
    }

    Console.WriteLine($"Saldo atual no banco: R$ {meuCartao.Saldo:F2}");

    Console.WriteLine("Efetuando pagamento de passagem: - R$ 6,00");
    meuCartao.PagarPassagem(6.00);

    db.SaveChanges(); 

    Console.WriteLine($"Operação concluída. Novo saldo salvo: R$ {meuCartao.Saldo:F2}");
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}