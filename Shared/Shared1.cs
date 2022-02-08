using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    internal class Shared1
    {
        public string SharedName { get; set; }

        private void Test()
        {
            SharedName = "";
            Console.WriteLine();
            foreach (var s in new List<string>())
            {
                Console.WriteLine(s);
            }
        }
    }
}
