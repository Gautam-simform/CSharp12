using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_12;

internal class RefReadonlyExample
{
    // Without readonly keyword, Method can change the value of argument value.
    public void Print(ref int number)
    {
        Console.WriteLine($"Your number is {number}");
        number++;      // Changing the value of reference argument value.
    }

    // So if we want to restrict the method to change the value of reference value then we can use readonly along with ref keyword like below

    public void PrintWithRefReadonly(ref readonly int number)
    {
        Console.WriteLine($"Your number is {number}");
        //number++;      // So we got compile time error. if method attempt to change the value.
    }
}
