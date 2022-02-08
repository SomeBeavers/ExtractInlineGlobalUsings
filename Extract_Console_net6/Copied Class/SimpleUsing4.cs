// SimpleUsing4.cs
// 2022 02 08 12:31 PM

using AnotherNamespace;

using A = Extract_Core_Console_net6.GlobalUsingsAreHere;

using Extract_Referenced_Lib;

using Serilog;

using static System.Math;

using B = System.Collections.Generic.List<string?>;

namespace Extract_Core_Console_net6.Copied_Class;
using A = Extract_Core_Console_net6.GlobalUsingsAreHere2;
public class SimpleUsing4
{
    private ILogger logger;

    private void Test(UseMe parameter, List<UseMe> list)
    {
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
        new A.ClassInFolder();
        B b = new List<string?>();
    }
}