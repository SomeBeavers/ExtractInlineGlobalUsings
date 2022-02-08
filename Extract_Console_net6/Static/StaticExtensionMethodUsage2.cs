// StaticExtensionMethodUsage2.cs
// 2022 02 08 12:39 PM

using Inline_Console_net6.Namespace1;

namespace Inline_Console_net6.Namespace2;

public class StaticExtensionMethodUsage2
{
    public void Test(int num)
    {
        var test = num.TestExtensionMethod();
        Console.WriteLine();
    }
}