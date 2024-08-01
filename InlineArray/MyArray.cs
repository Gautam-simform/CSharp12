using System.Runtime.CompilerServices;

namespace InlineArray;

[InlineArray(100)]
public struct MyArray<T>
{
    private T element;
}

