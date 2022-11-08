namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Diferença de dois produtos");
            System.Console.WriteLine("=========================================================");

            int a, b, c, d, diferenca;
            System.Console.WriteLine("Entre com 4 valores diferentes");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            System.Console.WriteLine("Diferença {0}", diferenca);
            

        }
    }
}
