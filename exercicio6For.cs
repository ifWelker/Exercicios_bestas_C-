namespace Curso
{    
    class Program
    {
        static void Main()
        {   

            //Ler um número inteiro N e calcular todos os seus divisores.

            System.Console.Write("Digite um Numero: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 )
                {
                    System.Console.WriteLine(i);
                }                
            }
        }
    }
}
