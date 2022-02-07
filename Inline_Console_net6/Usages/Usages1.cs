// Usages1.cs
// 2022 02 07 4:33 PM

namespace Inline_Core_Console_net6.Usages;

using Alias2 = Alias;

public class Usages1
{
    public void Test()
    {
        new Alias2.UseMe();
        new Use1();
        1.ExtensionMethod();
    }
}