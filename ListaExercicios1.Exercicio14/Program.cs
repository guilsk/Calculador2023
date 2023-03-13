namespace ListaExercicios1.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasVividos;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            diasVividos = idade * 365;

            Console.WriteLine(nome + " você já viveu pelo menos " + diasVividos + " dias.");

        }
    }
}