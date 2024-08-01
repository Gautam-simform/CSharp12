namespace C_12;


internal class PrimaryConstructor(string firstName, string lastName, int age = 25)
{
    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
}

internal static class PrimaryConstructorCaller
{
    public static void FullNameCaller()
    {
        PrimaryConstructor primaryConstructor = new("Gautam", "Makwana");

        Console.WriteLine(primaryConstructor.GetFullName());
    }
}

/*
 
- Primary constructor is elegant way to create a constructor in C# class. Privious versions of C# we had to create an explicit constructor. The Only advange we get from this feature is, simplifying the syntax and less lines of code.

- The only drawback i feel is, If we have many constructor parameters, then readability reduces.

- We can also use default value same as regular constructor.
- If we have logic to perform within the constructor then we can't use Primary constructor.

 */