// SimpleUsing.cs
// 2022 02 08 12:26 PM

using Extract_Referenced_Lib;

using Serilog;

using Alias = AnotherNamespace;

using static System.Math;

namespace Extract_Core_Console_net6.Copied_Class;
using System;
public class SimpleUsing
{
    private ILogger logger;

    private void Test(Alias.UseMe parameter, List<Alias.UseMe> list)
    {
        var appContext = AppContext.Name;
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
    }
}