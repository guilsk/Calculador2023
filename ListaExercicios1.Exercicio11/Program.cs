namespace ListaExercicios1.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool primo = true;
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    primo = false;
                }
            }
            Console.WriteLine("É primo? " + primo);
        }
    }
}