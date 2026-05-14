namespace Aula03;
//Constantes

public class Program
{
    public static void Main()
    {

        const string name = "Ycro";
       // string name = "Ycro";

        Console.WriteLine("O nome do individuo é: " + name);


        dynamic idade = 20;

        idade = "Saiko";

        Console.WriteLine("A idade do individuo é: " + idade);

        //var e dynamic são genuinamente interessantes.
    }
}

//Em resumo, constantes são valores fixos que não mudam