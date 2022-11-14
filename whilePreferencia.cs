namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            System.Console.WriteLine("Digite a preferencia de combustivel: \n1 - Alcool\n2 - Gasolina\n3 - Diesel\n4 - Fim");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int tipo = int.Parse(Console.ReadLine());
            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                } else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                } else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(" Muito Obrigado");
            System.Console.WriteLine("Alcool: {0}", alcool);
             System.Console.WriteLine("Gasolina: {0}", gasolina);
             System.Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
