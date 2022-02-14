// SimpleUsing5.cs
// 2022 02 08 12:31 PM

using AnotherNamespace;

using Extract_Core_Console_net6.GlobalUsingsAreHere;

using Serilog;

using static System.Math;

namespace Extract_Core_Console_net6.Copied_Class;
using GlobalUsingsAreHere2;
public class SimpleUsing5
{
    private ILogger logger;

    private void Test(UseMe parameter, List<UseMe> list)
    {
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
        new ClassInFolder();
    }
}