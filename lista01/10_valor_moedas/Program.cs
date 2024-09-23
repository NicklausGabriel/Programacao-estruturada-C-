namespace _10_;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeMoedas = 0;
        double valorTotal = 0.0;
        double valorMoeda;

        while (true)
        {
            Console.WriteLine("Informe o valor da moeda (0.01, 0.05, 0.10, 0.25, 0.50, 1.00) ou digite 0 para encerrar:");
            valorMoeda = double.Parse(Console.ReadLine());

            if (valorMoeda == 0)
            {
                break;
            }
            else if (valorMoeda == 0.01 || valorMoeda == 0.05 || valorMoeda == 0.10 || valorMoeda == 0.25 || valorMoeda == 0.50 || valorMoeda == 1.00)
            {
                quantidadeMoedas++;
                valorTotal += valorMoeda;
            }
        }

        Console.WriteLine($"Quantidade de moedas: {quantidadeMoedas}");
        Console.WriteLine($"Valor total poupado: R$ {valorTotal:F2}");
    }
}
