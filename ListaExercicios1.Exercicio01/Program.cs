namespace ListaExercicios1.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O volume é: " + (a * b * c));
        }
    }
}