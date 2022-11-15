namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            System.Console.Write("Digite uma quantidade: ");
            double N = double.Parse(Console.ReadLine());
            double numerador = 0;
            double denominador = 0;

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                numerador = double.Parse(valores[0]);
                denominador = double.Parse(valores[1]);

                double divisao = numerador / denominador;

                if (denominador == 0)
                {
                    System.Console.WriteLine("Divisão Impossivel");
                } else
                {
                    System.Console.WriteLine("O resutado é: {0}.", divisao);
                }
            }
        }
    }
}
