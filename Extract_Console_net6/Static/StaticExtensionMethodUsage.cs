using static Inline_Console_net6.Namespace1.StaticExtensionMethodDeclaration;
using static System.Console;

namespace Inline_Console_net6.Namespace2;

public class StaticExtensionMethodUsage
{
    public void Test(int num)
    {
        var test = num.TestExtensionMethod();
        WriteLine();
    }
}