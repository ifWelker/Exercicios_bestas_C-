namespace Curso
{    
    class Program
    {
        static void Main()
        {   
           System.Console.Write("Digite um numero x: ");
           int n = int.Parse(Console.ReadLine());

          int count_in = 0;
          int count_out = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    count_in = count_in + 1;
                } else
                {
                    count_out = count_out + 1;
                }
            }
            System.Console.WriteLine(count_in + " In");
            System.Console.WriteLine(count_out + " Out");
        }
    }
}
