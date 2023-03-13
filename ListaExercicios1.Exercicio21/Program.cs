namespace ListaExercicios1.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("Digite A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                c = a + b;
                Console.WriteLine(c);
            }
            else
            {
                c = a * b;
                Console.WriteLine(c);
            }
        }
    }
}