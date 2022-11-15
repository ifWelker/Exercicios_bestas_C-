namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            System.Console.Write("Digite uma quantidade: ");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            System.Console.WriteLine(fat);
        }
    }
}
