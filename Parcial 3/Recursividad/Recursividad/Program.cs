namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            int x = CalcularFactorial(numero);

            Console.WriteLine("Factorial: " + x);
            Console.ReadKey();
        }

        static int CalcularFactorial(int Num)
        {
            if (Num <= 1)
            {
                if (Num < 0)
                {
                    Console.WriteLine("Error: No hay factorial de negativos");
                    Console.ReadKey();

                  //  throw new ArgumentException("El argumento proporcionado no es válido: No hay factorial de negativos");
                }

                return 1;
            }
            else
            {
                return Num * CalcularFactorial(Num - 1);
            }
        }
    }
}
