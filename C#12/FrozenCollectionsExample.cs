using System.Collections.Frozen;

namespace C_12;

/*
 
- Frozen collections are immutable, Means once it is created, then it can't be modify

* Feature of Frozen Collections
- Immutability: Frozen collections are immutable, elements cannot be modified or removed, So data integrity can be ensured.
- Performance Optimization: Frozen collection is designed for faster read operations.
- Thread Safety: Multiple thread can read from one frozen collection without need of synchronization. SO it is thread safe.

 
 */

internal static class FrozenCollectionsExample
{
    public static void FrozenDictionaryMethod()
    {
        // FrozenDictionary<TKey,TValue>: This is a read-only dictionary optimized for fast key lookups. It is ideal for scenarios where the dictionary is created once and read frequently.

        var dictionary = new Dictionary<int, string>
        {
            { 1, "John" },
            { 2, "TOm" },
            { 3, "Harry" }
        };

        // Convert to a FrozenDictionary
        var frozenDictionary = dictionary.ToFrozenDictionary();

        // reading elements
        Console.WriteLine(frozenDictionary[1]);
    }

    public static void FrozenSetMethod()
    {
        // FrozenSet<T>: A read-only set that provides fast lookup times for checking the presence of elements.

        var set = new HashSet<int> { 1, 2, 3 };

        // Convert to a FrozenSet
        var frozenSet = set.ToFrozenSet();

        // Check for the presence of elements
        Console.WriteLine(frozenSet.Contains(1));
    }
}
