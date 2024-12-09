public class ArrayProcessor
{
    public static void ProcessArray(int[] array, Action<int> processor)
    {
        foreach (int item in array)
        {
            processor(item);
        }
    }
}

public class SumCalculator
{
    private int _sum;

    public void AddToSum(int number)
    {
        _sum += number;
    }

    public int GetSum()
    {
        return _sum;
    }

    public class MaxCalculator
{
    private int _max = int.MinValue;

    public void UpdateMax(int number)
    {
        if (number > _max)
        {
            _max = number;
        }
    }

    public int GetMax()
    {
        return _max;
    }
}
    public static void Main()
    {
       int[] numbers = { 1, 2, 3, 4, 5 };
       var sumCalculator = new SumCalculator();
        
       ArrayProcessor.ProcessArray(numbers, sumCalculator.AddToSum);
        
       int totalSum = sumCalculator.GetSum(); // Returns 15
       Console.WriteLine($"Total sum: {totalSum}");
    }
    var maxCalculator = new MaxCalculator();
        ArrayProcessor.ProcessArray(numbers, maxCalculator.UpdateMax);
        int max = maxCalculator.GetMax();
        Console.WriteLine($"Maximum value: {max}");
}
