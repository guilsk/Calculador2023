namespace ListaExercicios1.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("Digite a temperatura em Fahrenheit");
            f = Convert.ToDouble(Console.ReadLine());
            c = (f - 32) / 1.8;
            Console.WriteLine("ºC: " + c);
        }
    }
}