namespace _05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos pães foram vendidos hoje?");
        int quantidadePaesVendidos = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas cucas foram vendidas hoje?");
        int quantidadeCucasVendidas = int.Parse(Console.ReadLine());

        double precoPao = 0.40;
        double precoCuca = 7.80;

        double valorArrecadadoPaes = quantidadePaesVendidos * precoPao;
        double valorArrecadadoCucas = quantidadeCucasVendidas * precoCuca;
        double valorTotal = valorArrecadadoPaes + valorArrecadadoCucas;

        Console.WriteLine($"Quantidade de pães vendidos: {quantidadePaesVendidos}");
        Console.WriteLine($"Quantidade de cucas vendidas: {quantidadeCucasVendidas}");
        Console.WriteLine($"Valor arrecadado com pães: {valorArrecadadoPaes:C}");
        Console.WriteLine($"Valor arrecadado com cucas: {valorArrecadadoCucas:C}");
        Console.WriteLine($"Valor total arrecadado: {valorTotal:C}");
    }
}
