namespace C_12;

using Person = System.Collections.Generic.Dictionary<string, object>;
// Before C# 12 we could only create aliases for named types

using Point = (int x, int y);    // After C#12, we can create semantic aliases for tuple types, array types, pointer types, or other unsafe types. Here we have created alias for tupal

using stringAlias = String;

using T = System.Collections.Generic.IEnumerable<int>;

internal class AliasAnyType
{
    public void UsingAliasesForTupal()
    {
        Point point = (45, 25);
        Console.WriteLine(point.x); // 45
        Console.WriteLine(point.y); // 25


        stringAlias myString = "John";

        T t = new List<int>() { 1, 2, 3 };
        foreach (var item in t)
        {
            Console.WriteLine(item); // 1, 2, 3
        }
    }
}
