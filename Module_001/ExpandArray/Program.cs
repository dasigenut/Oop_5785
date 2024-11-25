namespace ExpandArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            ExpandArray(a);

            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void ExpandArray(int[] array)
        {
            int[] oldArray = array;

            array = new int[oldArray.Length * 2];
            for (int i = 0; i < oldArray.Length; i++)
            {
                array[i] = oldArray[i];
                array[i + oldArray.Length] = oldArray[i];
            }
        }
    }
}
