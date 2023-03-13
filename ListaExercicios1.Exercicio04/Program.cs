namespace ListaExercicios1.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, consumo, consumoKM;
            Console.WriteLine("Digite a km inicial: ");
            kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a km final:");
            kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o consumo:");
            consumo = Convert.ToDouble(Console.ReadLine());

            consumoKM = (kmFinal -  kmInicial) / consumo;
            Console.WriteLine("Consumo por Km: " + consumoKM);
        }
    }
}