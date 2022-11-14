namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            
            System.Console.WriteLine("Digite as coordenadas x e y: ");
            int x, y;
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    System.Console.WriteLine("Quadrante 1");
                } else if (x < 0 && y > 0)
                {
                    System.Console.WriteLine("Quadrante 2");
                } else if (x < 0 && y < 0)
                {
                    System.Console.WriteLine("Quadrante 3");
                } else
                {
                    System.Console.WriteLine("Quadrante 4");
                }
                coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);
            }
        }
    }
}
