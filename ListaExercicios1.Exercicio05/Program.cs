namespace ListaExercicios1.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi = 3.14, volume;
            Console.WriteLine("Digite o valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            volume = (4 * pi * raio * raio * raio)/3;
            Console.WriteLine("Volume: " + volume);
        }
    }
}