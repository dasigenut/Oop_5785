internal class Program
{
    struct PointStruct
    {
        public int x;
        public int y;
        public int x1;
        public int y1;
        public int x2;
        public int y2;
    }

    class PointClass
    {
        public int x;
        public int y;
    }


    static void ModifyPoint(PointStruct p)
    {
        p.x += 10;
        p.y += 20;
        Console.WriteLine($"In ModifyPoint: p.x={p.x} p.y={p.y}");
    }

    static int counter = 0;
    static void Recursion()
    {
        int[] arr = new int[10];
        PointStruct p1, p2, p3, p4;
        PointStruct p5, p6, p7, p8;
        counter++;
        Console.WriteLine($"counter={counter}");
        Recursion();
    }

    static void MeasureMemory()
    {
        long before = GC.GetAllocatedBytesForCurrentThread();
        PointClass[] array = new PointClass[100]; 
        long after = GC.GetAllocatedBytesForCurrentThread();
        Console.WriteLine($"Memory={after}-{before}={after - before}");
    }

    public static void ModifyArray(int[] arr)
    {
        arr[0] = 999; // Modifies original array
        arr = [10, 20, 30]; // Only modifies local reference
    }

    private static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4 };
        Console.WriteLine(string.Join(",", arr1));
        ModifyArray(arr1);
        Console.WriteLine(string.Join(",", arr1));

        // Recursion();

        // MeasureMemory();

        //PointStruct p = new PointStruct();
        //p.x = 4;
        //p.y = 5;
        //ModifyPoint(p);
        //Console.WriteLine($"p.x={p.x} p.y={p.y}");
    }
}

