namespace _02;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite a primeira nota do aluno!");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno!");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota do aluno!");
        double nota3 = double.Parse(Console.ReadLine());

        double media = nota1 + nota2 + nota3 / 3;
        if (media == 10)
        {
            Console.WriteLine("Aluno apropvado com louvor com media de:" + media);
        }
        else if (media >= 7)
        {
            Console.WriteLine("Aluno apropvado com media de:" + media);
        }
        else
        {
            Console.WriteLine("Aluno Reprovado! Com media de:" + media);
        }

    }
}
