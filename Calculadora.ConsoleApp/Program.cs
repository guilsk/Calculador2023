namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] resultados = new string[10];
            int i = 0;
            while (true)
            {
                if(i == 10)
                    i = 0;
                
                Console.Clear();
                Console.WriteLine("Qual operação você quer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Sair");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 6)
                {
                    break;
                }
                if(op != 1 && op != 2 && op != 3 && op != 4 && op != 5)
                {
                    while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5)
                    {
                        Console.WriteLine("Digite um número válido: ");
                        op = Convert.ToInt32(Console.ReadLine());
                    }

                }
                if(op == 5)
                {
                    Console.WriteLine("Digite um número para gerar a tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());
                    for (int k=1; k<=10; k++)
                    {
                        Console.WriteLine(tabuada + " * " + k + " = " + tabuada*k);
                    }
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o primeiro valor: ");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                decimal y = Convert.ToDecimal(Console.ReadLine());
                decimal z = 0;

                if (op == 1)
                {
                    z = x + y;
                }
                else if (op == 2)
                {
                    z = x - y;
                }
                else if (op == 3)
                {
                    z = x * y;
                }
                else if (op == 4)
                {
                    while(y == 0)
                    {
                        Console.WriteLine("Não se pode dividir por zero!");
                        Console.WriteLine("Digite um valor válido: ");
                        y = Convert.ToDecimal(Console.ReadLine());
                    }
                    z = x / y;
                }
                
                Console.WriteLine("O resultado é: " + z);
                resultados[i] = x + " + " + y + " = " + z.ToString();

                
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine(resultados[j]);
                }
                
                i++;

                Console.ReadLine();
            }
            
        }
    }
}