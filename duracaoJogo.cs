namespace Curso
{    
    class Program
    {
        static void Main()
        {
            int inicial, final, duracao;
            System.Console.WriteLine("Entre com a hora inicial e final: ");
            string[] valores = Console.ReadLine().Split(' ');
            inicial = int.Parse(valores[0]);
            final = int.Parse(valores[1]);

            if (final < inicial)
            {
                duracao = 24 + final - inicial;
            }
            else
            {
                duracao = 24 - inicial + final;
            }
            System.Console.WriteLine("O jogo durou {0} Horas", duracao);
        }
    }
}
