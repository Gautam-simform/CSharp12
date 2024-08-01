namespace C_12;

internal static class CollectionExpression
{
    public static void CollectionExpressionMethod()
    {
        // Creating an array:
        int[] numberArray = [1, 2, 3, 4, 5, 6, 7, 8];

        // Creating a list:
        List<string> names1 = ["John", "Mark", "Tom"];

        List<string> names2 = ["Peter", "Patrick"];

        // We can combine two collection. It is called spread operator (Same as spread operator in JS ES6)
        List<string> allNames = [.. names1, .. names2];

        // We had to use the AddRange method before this version.

        // Create a jagged 2D array:
        int[][] twoDArray = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    }

    /*
     
    - It is very eligent way to create and manupilate the collecions in C#.
    - It is just syntetic suger arround the old way to create and manupilate the collecions. Under the hood it create the instances same as old versions. 
    - It doesn't have any impact in performance.
     
     */
}
