namespace _03_conjunto_numerico;

class Program
{
    static void Main(string[] args)
    {
        /* Faça um algoritmo que leia um conjunto de números (X) e escreva na tela a quantidade de números pares e a quantidade de números ímpares digitados pelo usuário. Ex.: 1,2,3,4,5 => Pares=2 Impares=3  */
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
