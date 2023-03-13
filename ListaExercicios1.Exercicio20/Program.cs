namespace ListaExercicios1.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine($"{n} é par!");
            else
                Console.WriteLine($"{n} é impar!");
        }
    }
}