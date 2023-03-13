namespace ListaExercicios1.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pao, broa, poup, total;
            Console.WriteLine("Digite quantos pães: ");
            pao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantas broas: ");
            broa = Convert.ToDouble(Console.ReadLine());
            total = (pao * 0.12) + (broa * 1.5);
            poup = (total * 10) / 100;
            Console.WriteLine("O dono arrecadou: " + total);
            Console.WriteLine("O dono deve guardar: " + poup);
        }
    }
}