namespace Insercion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 8, 3, 5, 1, 9, 2 };

            Console.WriteLine("Arreglo desordenado:");
            foreach (int n in arreglo)
            {
                Console.Write(n + " ");
            }

            int[] resultado = OrdenarPorInsercion(arreglo);

            Console.WriteLine("\nArreglo ordenado:");
            foreach (int n in resultado)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }

        static int[] OrdenarPorInsercion(int[] Arreglo)
        {
            int j = 0, Temp = 0;

            for (int i = 1; i < Arreglo.Length; i++)
            {
                Temp = Arreglo[i];
                j = i - 1;

                while (j >= 0 && Arreglo[j] > Temp)
                {
                    Arreglo[j + 1] = Arreglo[j];
                    j = j - 1;
                }

                Arreglo[j + 1] = Temp;
            }

            return Arreglo;
        }

    }
}
