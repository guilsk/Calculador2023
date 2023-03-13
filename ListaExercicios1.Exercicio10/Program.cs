namespace ListaExercicios1.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, p1, n2, p2, mediaPonderada;
            Console.WriteLine("Digite a nota 1:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da nota 1:");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da nota 2:");
            p2 = Convert.ToDouble(Console.ReadLine());

            mediaPonderada = ((n1*p1) + (n2*p2))/(p1+p2);

            Console.WriteLine("Media Ponderada: "+mediaPonderada);
        }
    }
}