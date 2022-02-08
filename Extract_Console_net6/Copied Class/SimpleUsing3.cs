// SimpleUsing3.cs
// 2022 02 08 12:31 PM

using AnotherNamespace;

using Extract_Referenced_Lib;

using Serilog;

using static System.Math;
// comment
using C = System.Collections.Generic.List<string?>;
using B = System.Collections.Generic.List<int?>;
using System.Security.Authentication;

namespace Extract_Core_Console_net6.Copied_Class;

public class SimpleUsing3
{
    private ILogger logger;

    private void Test(UseMe parameter, List<UseMe> list)
    {
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
        C b = new C();
        B bb = new B();
    }
}