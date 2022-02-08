// Multi1.cs
// 2022 02 08 12:06 PM

using System;
using System.Collections.Generic;

namespace Extract_Multi;

public class Multi1
{
    private void Test()
    {
        Console.WriteLine();
        foreach (var s in new List<string>())
        {
            Console.WriteLine(s);
            new Multi2(s);
        }
    }
}