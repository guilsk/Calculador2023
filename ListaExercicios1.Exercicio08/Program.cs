namespace ListaExercicios1.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            double altura, raio, volume;
            double pi = 3.14;

            //Resolução
            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            //Saída
            volume = altura * raio * raio * pi;
            Console.WriteLine("O volume da oleo: " + volume);
        }
    }
}