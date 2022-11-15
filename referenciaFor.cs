namespace Curso
{    
    class Program
    {
        static void Main()
        {   
             System.Console.Write("Quantos numeros inteiros voce vai digitar? ");
             int n = int.Parse(Console.ReadLine());
            
             int soma = 0;
             for (int i = 1; i <= n ; i++)
             {
                System.Console.WriteLine("O valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma += valor;
             }
             System.Console.WriteLine("Soma = {0}", soma);
        }
    }
}
