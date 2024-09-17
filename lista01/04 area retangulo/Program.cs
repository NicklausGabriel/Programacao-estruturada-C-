namespace _04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ola, seja bem vindo! \nQual a base do terreno");
        double basee = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a altura do terreno");
        double altura = double.Parse(Console.ReadLine());
        double area = basee * altura;
        Console.WriteLine("A area do terreno é de: " + area);
    }
}
