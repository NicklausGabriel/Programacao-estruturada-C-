namespace _07_
{
    class Program
    {

        public static int ExibirDiasDeVida(int idade)
        {
            int diasDeVida = idade * 365;
            Console.WriteLine($"Você viveu aproximadamente {diasDeVida} dias.");
            return diasDeVida;
        }
        public static void ExibirHorasDeVida(int diasDeVida)
        {
            int horasDeVida = (diasDeVida * 24);
            Console.WriteLine($"Você viveu aproximadamente {horasDeVida} horas.");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());


            int diasDeVida = ExibirDiasDeVida(idade);
            ExibirHorasDeVida(diasDeVida);
        }
    }
}
