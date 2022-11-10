namespace Curso
{    
    class Program
    {
        static void Main()
        {
            int n, parImpar;
            System.Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            parImpar = n % 2;
            
            if (parImpar == 1)
            {
                System.Console.WriteLine("IMPAR");
            }
            else
            {
                System.Console.WriteLine("Par");
            }
        }
    }
}
