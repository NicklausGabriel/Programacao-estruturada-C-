namespace _03_conjunto_numerico;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos numeros vamos verificar?");
        int x = int.Parse(Console.ReadLine());
        int pares = 0;
        int impares = 0;
        for (int i = 1; i <= x; i++)
        {

            if (i % 2 == 0)
            {
                pares = pares + 1;
            }
            else
            {
                impares = impares + 1;
            }
        }
        Console.WriteLine("Pares = " + pares);
        Console.WriteLine("Impares = " + impares);
    }
}
