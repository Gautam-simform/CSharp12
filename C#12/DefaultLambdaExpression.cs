namespace C_12;

internal static class DefaultLambdaExpression
{
    public static string GetName(string? name = null)
    {
        var lambdaDemo = (string name = "User") => $"Hello {name}";

        // We can get the default value of the lambda as below
        var defaultValue = lambdaDemo.Method.GetParameters()[0].DefaultValue;

        // So as we can see, We can call the lambda with argument as well as without argument
        return string.IsNullOrWhiteSpace(name) ? lambdaDemo() : lambdaDemo(name);
    }

    /*
     
    - We can create an default value parameter in the lambda. 
    - Same as the default value paraeter with regular method.
    - Same as regular method, we can't have required parameter after default value parameters. So every default parameter must be at the last in the parameter list.
     
     */
}
