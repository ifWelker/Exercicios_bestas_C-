namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Calcular area de figuras geométricas, \na partir de 3 valores predefinidos!!!");
            System.Console.WriteLine("=========================================================");
           double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
           
           System.Console.WriteLine("Digite 3 valores:");
           string[] valores = Console.ReadLine().Split(' ');
           a = double.Parse(valores[0]);
           b = double.Parse(valores[1]);
           c = double.Parse(valores[2]);

           triangulo = (a*c)/2;
           circulo = Math.Pow(c,2) * 3.14159;
           trapezio = ((a + b) * c)/2;
           quadrado = Math.Pow(b,2);
           retangulo = a * b;

           System.Console.WriteLine("Triangulo: {0:F3}",triangulo);
           System.Console.WriteLine("Circulo: {0:F3}", circulo);
           System.Console.WriteLine("Trapezio: {0:F3}", trapezio);
           System.Console.WriteLine("Quadrado: {0:F3}", quadrado);
           System.Console.WriteLine("Retangulo: {0:F3}",retangulo);
        }
    }
}
