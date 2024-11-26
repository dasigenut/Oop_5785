internal class Program
{
    class OperationTable
    {
        public int[,] results = new int[12, 10];

        public void Calculate()
        {
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for (int col = 0; col < results.GetLength(1); col++)
                {
                    results[row, col] = row * col;
                }

            }
        }

        public override string ToString()
        {
            string res = "";
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for (int col = 0; col < results.GetLength(1); col++)
                {
                    res += results[row, col].ToString();
                    res += ",";
                }
                res += "\n";
            }
            return res;
        }
    }
    private static void Main(string[] args)
    {
        OperationTable table = new OperationTable();
        table.Calculate();
        Console.WriteLine(table);

        Console.WriteLine($"{table.results[1,1]}");
    }
}