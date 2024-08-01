using BenchmarkDotNet.Attributes;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace FrozenCollections;

[MemoryDiagnoser]
public class CollectionCreationBenchmark
{
    private readonly List<int> _data;

    public CollectionCreationBenchmark()
    {
        _data = Enumerable.Range(0, 10000).ToList();
    }

    [Benchmark]
    public List<int> CreateList()
    {
        return new List<int>(_data);
    }

    [Benchmark]
    public HashSet<int> CreateHashSet()
    {
        return new HashSet<int>(_data);
    }

    [Benchmark]
    public ImmutableHashSet<int> CreateImmutableHashSet()
    {
        return ImmutableHashSet.CreateRange(_data);
    }

    [Benchmark]
    public FrozenSet<int> CreateFrozenSet()
    {
        return _data.ToFrozenSet();
    }
}
