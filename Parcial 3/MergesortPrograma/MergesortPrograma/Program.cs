namespace MergesortPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 3, 7, 1, 9, 2, 8 };

            Console.WriteLine("Arreglo desordenado:");
            foreach (int n in array) Console.Write(n + " ");

            int[] ordenado = MergeSort(array);

            Console.WriteLine("\nArreglo ordenado:");
            foreach (int n in ordenado) Console.Write(n + " ");

            Console.ReadKey();
        }

        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            int a = 0;
            while (a < mid)
            {
                left[a] = array[a];
                a++;
            }

            int origen = mid;
            int b = 0;
            while (b < right.Length)
            {
                right[b] = array[origen];
                origen++;
                b++;
            }

            left = MergeSort(left);
            right = MergeSort(right);

            int[] result = new int[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    k++;
                    j++;
                }
            }

            while (i < left.Length)
            {
                result[k] = left[i];
                k++;
                i++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                k++;
                j++;
            }

            return result;
        }
    }
}
