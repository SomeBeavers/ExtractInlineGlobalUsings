﻿// SimpleUsing3.cs
// 2022 02 08 12:31 PM

using System;
using System.Collections.Generic;
using System.Linq;

using AnotherNamespace;

using Serilog;

namespace Extract_Core_Console_net6.Copied_Class;

public class SimpleUsing3
{
    private ILogger logger;

    private void Test(UseMe parameter, List<UseMe> list)
    {
        Console.WriteLine(list.Any());

        logger.Error("{testMessage}", parameter);
    }
}