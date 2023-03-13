namespace ListaExercicios1.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, comissao, salarioTotal; 
            Console.WriteLine("Digite o salário base: ");
            salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a comissão: ");
            comissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (comissao * totalVendas) / 100;

            Console.WriteLine("O salário total: " + salarioTotal);
        }
    }
}