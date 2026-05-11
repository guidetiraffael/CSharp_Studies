namespace Aula02;

// Aprendendo a usar variáveis e tipos de dados em C#
public class Program
{
    public static void Main()
    {
        string texto;
        int numerointeiro;
        double numerodecimal;
        bool verdadeirooufalso;

        texto = Console.ReadLine();
        numerointeiro = int.Parse(Console.ReadLine());
        numerodecimal = double.Parse(Console.ReadLine());
        verdadeirooufalso = bool.Parse(Console.ReadLine());

        Console.WriteLine($"O texto digitado foi: {texto}");
        Console.WriteLine($"O número inteiro digitado foi: {numerointeiro}");
        Console.WriteLine($"O número decimal digitado foi: {numerodecimal}");
        Console.WriteLine($"O valor booleano digitado foi: {verdadeirooufalso}");
    }
}

// Fato interessante: O método readline() le algo como se fosse uma string, então no caso de outros tipos de variaveis se usa o "tipodevariavel.Parse()"