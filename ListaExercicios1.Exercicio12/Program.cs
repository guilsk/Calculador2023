namespace ListaExercicios1.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2;
            Console.WriteLine("Digite o lado 1: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Área do terreno: " + (l1 * l2));


        }
    }
}