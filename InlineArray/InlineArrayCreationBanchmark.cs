using BenchmarkDotNet.Attributes;

namespace InlineArray;

[MemoryDiagnoser]
public class InlineArrayCreationBanchmark
{
    private readonly Random _random = new(100);

    [Benchmark]
    public int[] CreateArray()
    {
        var array = new int[100];

        for (int i = 0; i < 100; i++)
        {
            array[i] = _random.Next();
        }

        return array;
    }

    [Benchmark]
    public MyArray<int> CreateInlineARray()
    {
        var array = new MyArray<int>();

        for (int i = 0; i < 100; i++)
        {
            array[i] = _random.Next();
        }

        return array;
    }
}
