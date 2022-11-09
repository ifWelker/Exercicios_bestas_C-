namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Calculo de Compras");
            System.Console.WriteLine("=========================================================");

           int cod1, qtd1, cod2, qtd2;
           double preco1, preco2, total;

            System.Console.WriteLine("Digite as informações da primeira peça:");
           string[] valores1 = Console.ReadLine().Split(' ');
           cod1 = int.Parse(valores1[0]);
           qtd1 = int.Parse(valores1[1]);
           preco1 = double.Parse(valores1[2]);

            System.Console.WriteLine("Digite as informações da segunda peça: ");
           string[] valores2 = Console.ReadLine().Split(' ');
           cod2 = int.Parse(valores2[0]);
           qtd2 = int.Parse(valores2[1]);
           preco2 = double.Parse(valores2[2]);

           total = (qtd1 * preco1) + (qtd2 * preco2);

           System.Console.WriteLine("Valor a pagar {0:F2}", total);
            

        }
    }
}
