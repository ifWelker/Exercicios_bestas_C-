namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Calculo de Área de um Cirulo");
            System.Console.WriteLine("=========================================================");

            double r, area;
            System.Console.WriteLine("Digite o raio do Circulo:");
            r = double.Parse(Console.ReadLine());
            area = Math.Pow(r,2) * Math.PI;
            System.Console.WriteLine("A Área do circulo é de {0:F4}", area);
            

        }
    }
}
