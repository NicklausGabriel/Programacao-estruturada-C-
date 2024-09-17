namespace _01;

class Program
{
    static void Main(string[] args)
    {
        int tabuada;
        Console.WriteLine("Por favor infor um numero de 0 a 10");
        tabuada = int.Parse(Console.ReadLine());
        Console.WriteLine("A tabuada de " + tabuada + "é: ");
        for (int algarismos = 0; algarismos < 10; algarismos++)
        {
            int resultado = tabuada * algarismos;
            Console.WriteLine(tabuada + " * " + algarismos + " == " + resultado);
        }
    }
}
