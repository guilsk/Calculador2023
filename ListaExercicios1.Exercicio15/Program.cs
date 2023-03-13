namespace ListaExercicios1.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("Digite o valor em ºC: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 1.8) + 32;
            Console.WriteLine("ºF: " + f);
        }
    }
}