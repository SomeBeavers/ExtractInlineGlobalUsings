// Multi1.cs
// 2022 02 07 12:12 PM


namespace Inline_Multi
{

    public class Multi1
    {
        private void Test21()
        {
        }

#if NET6_0
    public void Test()
    {
        Test21();
        var list = new List<string>();
    }
#else
        public void Test()
        {
Test21();
            //new List<string>();
        }
#endif
    }
}