namespace QuicksortPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 10, 3, 7, 1, 9, 2 };

            Console.WriteLine("Arreglo desordenado:");
            foreach (int n in arreglo) Console.Write(n + " ");


            int[] ordenado = Quicksort(arreglo);

            Console.WriteLine("\nArreglo ordenado:");
            foreach (int n in ordenado) Console.Write(n + " ");

            Console.ReadKey();
        }

        static int[] Quicksort(int[] Array)
        {
            int Y = 0, Z = 0;

            if (Array.Length <= 1)
            {
                return Array;
            }

            int[] ArrayIzq = new int[Array.Length];
            int[] ArrayDer = new int[Array.Length];

            for (int x = 1; x < Array.Length - 1; x++)
            {
                if (Array[x] > Array[Array.Length - 1])
                {
                    ArrayDer[Y] = Array[x];
                    Y++;
                }
                else
                {
                    ArrayIzq[Z] = Array[x];
                    Z++;
                }
            }

            int[] IzqOrdenado = Quicksort(Recortar(ArrayIzq, Z));
            int[] DerOrdenado = Quicksort(Recortar(ArrayDer, Y));

            int[] Resultado = new int[IzqOrdenado.Length + 1 + DerOrdenado.Length];

            //Pegar en un solo vector
            int pos = 0;

            for (int i = 0; i < IzqOrdenado.Length; i++)
            {
                Resultado[pos] = IzqOrdenado[i];
                pos++;
            }

            //Pivote
            Resultado[pos] = Array[Array.Length - 1];
            pos++;

            for (int i = 0; i < DerOrdenado.Length; i++)
            {
                Resultado[pos] = DerOrdenado[i];
                pos++;
            }

            return Resultado;
        }

        
        //Obtener un vector de tamaño real a los numeros de datos
        static int[] Recortar(int[] v, int cantidad)
        {
            int[] n = new int[cantidad];
            for (int i = 0; i < cantidad; i++) n[i] = v[i];
            return n;
        }
    }
}
