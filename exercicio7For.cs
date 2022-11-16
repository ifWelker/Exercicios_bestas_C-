namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            System.Console.Write("Digite um Numero: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double primeiro = Math.Pow(i,2);
                double segundo = Math.Pow(i, 3);
                System.Console.WriteLine("#{0} {1} {2}", i, primeiro ,segundo);
            }
        }
    }
}

//A função math.Pow só funciona se declarado como variavel flutuante, e não como inteiro.
