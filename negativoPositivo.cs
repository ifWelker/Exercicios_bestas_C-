namespace Curso
{    
    class Program
    {
        static void Main()
        {
            int n;
            System.Console.WriteLine("Digite um numero qualquer: ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                System.Console.WriteLine("NEGATIVO");
            }
            else
            {
                System.Console.WriteLine("POSITIVO");
            }
        }
    }
}
