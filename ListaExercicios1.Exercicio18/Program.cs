namespace ListaExercicios1.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite 3 valores diferentes: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
                Console.WriteLine(a + " " + b + " " + c);
            else if (a > c && c > b)
                Console.WriteLine(a + " " + c + " " + b);
            else if (b > a && a > c)
                Console.WriteLine(b + " " + a + " " + c);
            else if (b > c && c > a)
                Console.WriteLine(b + " " + c + " " + a);
            else if (c > a && a > b)
                Console.WriteLine(c + " " + a + " " + b);
            else if (c > b && b > a)
                Console.WriteLine(c + " " + b + " " + a);
        }
    }
}