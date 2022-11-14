namespace Curso
{    
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1,n2,3);

            System.Console.WriteLine("Maior é = {0}", resultado);
        }

        static int Maior(int a, int b, int c) //fazendo uma função - Nesse exemplo é para mostrar qual o maior de 3 numeros inteiros digitados
                                             // a função é feito dentro do bloco de comando da classe.
        {
            int m;
            if (a > b && a > c) {
                m = a;
            } else if (b > c)
            {
                m = b;
            } else
            {
                m = c;
            }
            return m;
        }
    }
}
