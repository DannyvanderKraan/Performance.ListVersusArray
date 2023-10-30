using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class StringConcatenationBenchmark
{
    [Benchmark]
    public List<int> UsingList()
    {
        List<int> numbersList = new List<int>(1000);
        for (int i = 0; i < 1000; i++)
        {
            numbersList.Add(i);
        }
        return numbersList;
    }

    [Benchmark]
    public int[] UsingArray()
    {
        int[] numbersArray = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            numbersArray[i] = i;
        }
        return numbersArray;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringConcatenationBenchmark>();
    }
}
