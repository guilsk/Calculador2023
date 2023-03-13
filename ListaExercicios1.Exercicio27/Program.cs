namespace ListaExercicios1.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c = 0;
            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n+1; i++) {
                a = b;
                b = c;
                c = a + b;
                
                Console.WriteLine(c);
            }
        }
    }
}