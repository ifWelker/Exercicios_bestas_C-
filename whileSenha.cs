namespace Curso
{    
    class Program
    {
        static void Main()
        {   
            
            System.Console.WriteLine("Digite a senha: ");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                System.Console.WriteLine("Senha Invalida, digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Acesso Permitido!");
        }
    }
}
