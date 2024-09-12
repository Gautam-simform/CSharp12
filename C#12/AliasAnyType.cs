namespace C_12;

using Person = Dictionary<string, object>;
// Before C# 12 we could only create aliases for named types like above Dictionary

// After C#12, we can create semantic aliases for tuple types, array types, pointer types, or other unsafe types.

// Tuple alias
using Point = (int x, int y);

// Array alias
using IntArray = int[];  // Alias for an array of integers

// Multi-dimensional array alias
using Matrix = int[,];   // Alias for a 2D array (matrix) of integers

// named type alias
using stringAlias = String;

using T = System.Collections.Generic.IEnumerable<int>;

internal class AliasAnyType
{
    public static void AllAliasesUsage()
    {
        // Example usage of the aliases

        // Tuple alias
        Point point = (45, 25);
        Console.WriteLine(point.x); // 45
        Console.WriteLine(point.y); // 25

        // Array alias
        IntArray numbers = { 1, 2, 3, 4 };

        // Multi-dimensional array alias
        Matrix matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Get the number of rows and columns
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        // Print the matrix
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // named type alias
        stringAlias myString = "John";

        // Enumerable alias
        T t = new List<int>() { 1, 2, 3 };
        foreach (var item in t)
        {
            Console.WriteLine(item); // 1, 2, 3
        }
    }
}
