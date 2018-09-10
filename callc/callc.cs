// compile ẃith msc callc.cs. Assert that test.so is in current directory

using System;
using System.Runtime.InteropServices;     // DLL support

class HelloWorld
{
    [DllImport("./test.so")]
    public static extern int add (int a, int b);

    static void Main ()
    {
        Console.WriteLine ("This is C# program");
        int result = add(10,29);
        Console.WriteLine ("The result is: {0}", result);
    }
}