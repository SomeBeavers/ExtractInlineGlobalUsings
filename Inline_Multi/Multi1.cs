// Multi1.cs
// 2022 02 07 12:12 PM


namespace Inline_Multi
{

    public class Multi1
    {
#if NET6_0
    public void Test()
    {
        var list = new List<string>();
    }
#else
        public void Test()
        {
            //new List<string>();
        }
#endif
    }
}