namespace Curso
{    
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("=========================================================");
            System.Console.WriteLine("Calculo de Salário por horas trabalhadas");
            System.Console.WriteLine("=========================================================");

            int cod, timeWorked;
            double cash, salary;

            System.Console.WriteLine("Entre com o codigo do funcionario, horas trabalhadas e valor por hora:");
            cod = int.Parse(Console.ReadLine());
            timeWorked = int.Parse(Console.ReadLine());
            cash = double.Parse(Console.ReadLine());
            salary = timeWorked * cash;
            System.Console.WriteLine("Number: {0};\n Salary: U$ {1:F2}", cod, salary);
            

        }
    }
}
