namespace _06
{
    public class NumeroSwap
    {
        public int A { get; set; }
        public int B { get; set; }

        // Construtor que recebe os valores iniciais de A e B
        public NumeroSwap(int a, int b)
        {
            A = a;
            B = b;
        }

        public void TrocarValores()
        {
            int temp = A;
            A = B;
            B = temp;
        }

        public void ExibirValores()
        {
            Console.WriteLine($"Valor de A: {A}, Valor de B: {B}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número (A): ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número (B): ");
            int valorB = int.Parse(Console.ReadLine());

            NumeroSwap numeros = new NumeroSwap(valorA, valorB);

            Console.WriteLine("\nValores antes da troca:");
            numeros.ExibirValores();


            numeros.TrocarValores();


            Console.WriteLine("\nValores após a troca:");
            numeros.ExibirValores();
        }
    }
}
