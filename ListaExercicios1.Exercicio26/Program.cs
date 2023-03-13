namespace ListaExercicios1.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite um valor para A:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a-1; i > 1; i--) {
                a *= i;
                Console.WriteLine(a);
            }
            
        }
    }
}