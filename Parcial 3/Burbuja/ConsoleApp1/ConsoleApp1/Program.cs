namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 5, 2, 9, 1, 7, 3 };

            Console.WriteLine("Arreglo original:");
            Imprimir(arreglo);

            Burbuja(ref arreglo);

            Console.WriteLine("\nArreglo ordenado:");
            Imprimir(arreglo);

            Console.ReadKey();
        }

        static void Burbuja(ref int[] arreglo)
        {
            int temp;

            for (int x = 0; x < arreglo.Length - 1; x++)
            {
                for (int y = 0; y < arreglo.Length - 1 - x; y++)
                {
                    if (arreglo[y] > arreglo[y + 1])
                    {
                        temp = arreglo[y];
                        arreglo[y] = arreglo[y + 1];
                        arreglo[y + 1] = temp;
                    }
                }
            }
        }

        static void Imprimir(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
