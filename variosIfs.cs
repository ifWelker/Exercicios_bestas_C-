namespace Curso
{    
    class Program
    {
        static void Main()
        {
            int cod, qtd;
             System.Console.WriteLine("Digite o codigo do produto e a quantidade desejada: ");
            string[] valores = Console.ReadLine().Split(' ');
            cod = int.Parse(valores[0]);
            qtd = int.Parse(valores[1]);
           
            double total = 0;
            if (cod == 1)
            {
                total = qtd * 4.00;
            } else if (cod == 2)
            {
                total = qtd * 4.50;
            } else if (cod == 3)
            {
                total = qtd * 5.00;
            } else if (cod == 4)
            {
                total = qtd * 2.00;
            } else if (cod == 5)
            {
                total = qtd * 1.50;
            }
            System.Console.WriteLine("Total: R$ {0}", total);
        }
    }
}
