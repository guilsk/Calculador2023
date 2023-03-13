namespace ListaExercicios1.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if(a + b < c)
            {
                Console.WriteLine($"{a}+{b} é menor que {c}!");
            }
            else
            {
                Console.WriteLine($"{a}+{b} é maior ou igual que {c}!");
            }
        }
    }
}