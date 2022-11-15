namespace Curso
{    
    class Program
    {
        static void Main()
        {   
           System.Console.Write("Digite um numero x: ");
           int x = int.Parse(Console.ReadLine());
           int impar = 0;

            System.Console.WriteLine("São os impares de 1 a {0} são:", x);

           for (int i = 1; i <= x; i++)
           {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
           }
        }
    }
}
