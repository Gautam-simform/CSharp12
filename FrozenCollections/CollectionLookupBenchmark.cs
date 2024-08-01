using BenchmarkDotNet.Attributes;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace FrozenCollections;

[MemoryDiagnoser]
public class CollectionLookupBenchmark
{
    private readonly List<int> _data;
    private readonly List<int> _list;
    private readonly HashSet<int> _hashSet;
    private readonly ImmutableHashSet<int> _immutableHashSet;
    private readonly FrozenSet<int> _frozenSet;

    public CollectionLookupBenchmark()
    {
        _data = Enumerable.Range(0, 10000).ToList();
        _list = new List<int>(_data);
        _hashSet = new HashSet<int>(_data);
        _immutableHashSet = ImmutableHashSet.CreateRange(_data);
        _frozenSet = _data.ToFrozenSet();
    }

    [Benchmark]
    public bool ListLookup()
    {
        return _list.Contains(5000);
    }

    [Benchmark]
    public bool HashSetLookup()
    {
        return _hashSet.Contains(5000);
    }

    [Benchmark]
    public bool ImmutableHashSetLookup()
    {
        return _immutableHashSet.Contains(5000);
    }

    [Benchmark]
    public bool FrozenSetLookup()
    {
        return _frozenSet.Contains(5000);
    }
}
