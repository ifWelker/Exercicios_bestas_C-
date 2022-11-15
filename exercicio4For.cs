//Media ponderada com valores predefinidos

namespace Curso
{    
    class Program
    {
        static void Main()
        {   
          System.Console.Write("Digite o numero de testes: ");
          int n = int.Parse(Console.ReadLine());
          for (int i = 0; i < n; i++)
          {
            string[] notas = (Console.ReadLine().Split(' '));
            double nota1 = double.Parse(notas[0]);
            double nota2 = double.Parse(notas[1]);
            double nota3 = double.Parse(notas[2]);

            double media = (nota1 * 2 + nota2 * 3 + nota3 * 5)/10;

             System.Console.WriteLine("Media:\n{0}", media.ToString("F1"));
          }
        }
    }
}
