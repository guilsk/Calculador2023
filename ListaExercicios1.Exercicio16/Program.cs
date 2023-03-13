namespace ListaExercicios1.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial, salarioAumentado, salarioFinal;
            Console.WriteLine("Digite o seu salário: ");
            salarioInicial = Convert.ToDouble(Console.ReadLine());
            salarioAumentado = salarioInicial * 115 / 100;
            salarioFinal = salarioAumentado * 92 / 100;
            Console.WriteLine("Salario Inicial: " + salarioInicial);
            Console.WriteLine("Salario Aumentado: " + salarioAumentado);
            Console.WriteLine("Salario Final: " + salarioFinal);

        }
    }
}