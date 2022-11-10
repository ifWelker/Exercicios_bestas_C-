namespace Curso
{    
    class Program
    {
        static void Main()
        {
            int a, b;
               
            System.Console.WriteLine("Insira dois numeros: ");
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            if (a % b == 0 || b % a == 0)
            {
                System.Console.WriteLine("São multiplos");
            }
            else
            {
                System.Console.WriteLine("Não São Multiplos");
            }
        }
    }
}
