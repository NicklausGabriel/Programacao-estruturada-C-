namespace _09_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual seu salario fixo?");
        double salarioFixo = 0;

        salarioFixo = double.Parse(Console.ReadLine());
        double comissao = (20.0 / 100.0) * salarioFixo;

        Console.WriteLine("Quantas vendas você fez?");
        int totalVendasMes = 0;
        totalVendasMes = int.Parse(Console.ReadLine());
        double salarioComComissao = salarioFixo + comissao;
        Console.WriteLine($"Sua comissão esse mẽs foi de ${comissao} junto ao salario fixo de : ${salarioFixo}, voce vai receber ${salarioComComissao}");






    }
}
