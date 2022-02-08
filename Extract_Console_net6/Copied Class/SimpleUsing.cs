// SimpleUsing.cs
// 2022 02 08 12:26 PM

using System;
using System.Collections.Generic;
using System.Linq;

using Alias = AnotherNamespace;

using Extract_Referenced_Lib;

using Serilog;

using static System.Math;

namespace Extract_Core_Console_net6.Copied_Class;

public class SimpleUsing
{
    private ILogger logger;

    private void Test(Alias.UseMe parameter, List<Alias.UseMe> list)
    {
        Console.WriteLine(list.Any());
        var fromLib1 = new FromLib1();
        var pi = PI;
        logger.Error("{testMessage}", parameter);
    }
}