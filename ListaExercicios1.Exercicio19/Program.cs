namespace ListaExercicios1.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso / (altura * altura);
            
            if(imc < 18.5) 
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if(imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal!");
            }
            else if(imc >= 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso!");
            }
            else
            {
                Console.WriteLine("Obeso!");
            }

        }
    }
}