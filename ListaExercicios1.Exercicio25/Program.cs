namespace ListaExercicios1.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine($"{n} * {i} = {n*i}");
            }
        }
    }
}