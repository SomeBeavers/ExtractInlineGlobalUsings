// Play4.cs
// 2022 02 10 11:32 AM
using System;

using Inline_Playground.Test;
using Play5;

namespace Inline_Playground
{
    public class Play4
    {
        public string Name1 { get; set; }

        private void Test()
        {
            new List<string>();
            new NotPlayClass();
        }
    }
}

namespace Play5
{
    class NotPlayClass
    {
        
    }
}