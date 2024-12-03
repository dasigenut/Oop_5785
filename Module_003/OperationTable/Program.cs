using OperationTable;
using System.Net.NetworkInformation;

internal class Program
{
    class OperationTable
    {
        public delegate int Operation(int a, int b);

        Operation op;
        public int[,] results = new int[12, 10];

        public OperationTable(Operation _op)
        {
            op = _op;
        }

        public void Calculate()
        {
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for (int col = 0; col < results.GetLength(1); col++)
                {
                    results[row, col] = op(row,col);
                }
            }
        }

        public override string ToString()
        {
            int maxWidth = 0;
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for (int col = 0; col < results.GetLength(1); col++)
                {
                    string s = results[row, col].ToString();
                    maxWidth = Math.Max(maxWidth, s.Length);
                }
            }

            string res = "";
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for (int col = 0; col < results.GetLength(1); col++)
                {
                    res += results[row, col].ToString().PadLeft(maxWidth, ' ');
                    if (col < results.GetLength(1) - 1)
                    {
                        res += ",";
                    }
                }
                res += "\n";
            }
            return res;
        }
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    private static void Main(string[] args)
    {
        //ComparerExample arr1 = new ComparerExample();
        //arr1.SortByLength();
        //Console.WriteLine($"Array sorted by length:\n{arr1.ToString()}");
        //Console.WriteLine("==================");
        //arr1.Sort();
        //Console.WriteLine($"Array sorted with default comparison:\n{arr1}");
        //Console.WriteLine("==================");

        int d = 2;

        OperationTable.Operation op = (int x, int y) =>
        {
            int result = 1;
            for (int i = 0; i<y; i++)
            {
                result *= x;
            }
            return result / d;
        };

        OperationTable table = new OperationTable(op);
        table.Calculate();
        Console.WriteLine(table);

        Console.WriteLine($"table.results[1,1]={table.results[1,1]}");
    }
}