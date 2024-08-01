using BenchmarkDotNet.Running;
using FrozenCollections;

var summary = BenchmarkRunner.Run<CollectionLookupBenchmark>();

/*
 
* List 
- It is mutable data structure. Meaning, one can add, remove and check the element within same object without creating another object.
- It allows duplicate elements.
- It is less performant in terms of time and memory for add and remove operation.

* Hashset
- It uses hash to store the data.
- Doesn't allow duplicate elements.
- For Add, Remove and lookup (Contain), It is very performant irrespective of how big the collection is.

* ImmutableHashSet
- It is a immutable version of Hashset. Meaning once it is created, one can not change it.
- Doesn't allow duplicate elements.
- Even though it is an immutable collection, It has got Add(), Remove() method. But when we use these methods, then new ImmutableHashSet object will be returned instead of existing object.

* FrozenSet
- It is also immutable collection.
- Optimized for scenarios where the set is created once and then only read from (no modifications). SO this data structure does not have Add() and Remove() method. It is specially designed for read operations.
- The freezing process can be costly, so it's best suited for collections that don’t change after being created.


Summary of Key Differences:
- Mutability: List and HashSet are mutable, while ImmutableHashSet and FrozenSet are immutable.
- Order: Only List maintains the order of elements.
- Performance: HashSet and FrozenSet provide O(1) lookups, with FrozenSet being slightly faster for reads. List is slower for lookups (O(n)), but offers fast indexed access.
- Duplicates: Only List allows duplicates; HashSet, ImmutableHashSet, and FrozenSet do not.

Use Case Recommendations:
- Use List for ordered collections where duplicates are allowed and fast indexed access is needed.
- Use HashSet for unordered collections where uniqueness is required and you need fast lookups or set operations.
- Use ImmutableHashSet for thread-safe, immutable collections where you still need fast lookups and set operations.
- Use FrozenSet for read-only collections where the highest lookup performance is crucial and the set is not modified after creation.
 
 */