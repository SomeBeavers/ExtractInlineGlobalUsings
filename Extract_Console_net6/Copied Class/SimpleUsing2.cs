// SimpleUsing2.cs
// 2022 02 08 12:31 PM

using Extract_Referenced_Lib;

using Alias2 = AnotherNamespace;

using Serilog;

using static System.Math;

namespace Extract_Core_Console_net6.Copied_Class;

public class SimpleUsing2
{
    private ILogger logger;

    private void Test(Alias2.UseMe parameter, List<Alias2.UseMe> list)
    {
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
    }
}