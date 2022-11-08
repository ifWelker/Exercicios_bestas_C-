namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Soma de dois numers inteiros");
            System.Console.WriteLine("=========================================================");
          
            int a, b , soma;
            System.Console.WriteLine("Digite dois valores para a soma:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            System.Console.WriteLine("Soma = {0}", soma);

        }
    }
}
