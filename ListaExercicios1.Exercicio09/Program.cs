namespace ListaExercicios1.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, mediaHarmonica;
            Console.WriteLine("Digite a nota da prova 1:");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova 2:");
            p2 = Convert.ToDouble(Console.ReadLine());

            mediaHarmonica = 2 / (1/p1 + 1/p2);
            Console.WriteLine("Media Harmonica: " + mediaHarmonica);
        }
    }
}