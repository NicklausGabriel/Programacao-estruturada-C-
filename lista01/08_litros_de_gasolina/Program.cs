namespace _08_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boa tarde, quanto deseja de gasolina?");
        double precoGasolinaLitro = 1.09;
        double gasolinaLitro = 0.0;
        double valorRecebido = double.Parse(Console.ReadLine());
        gasolinaLitro = (valorRecebido / precoGasolinaLitro) * 1.0;
        Console.WriteLine($"Certo com R$ {valorRecebido} conseguimos abastecer {gasolinaLitro} litros");
    }
}
