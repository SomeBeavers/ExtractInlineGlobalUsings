// UseUseMe.cs
// 2022 02 07 2:52 PM


namespace Inline_Core_Console_net6;
using Alias = Inline_Core_Console_net6.Use3;
public class UseUseMe
{
    private void Test()
    {
        // ReSharper disable once UnusedVariable
        var useMe = new Alias.UseMe();
        var vector2 = One;
    }
}

public static class Use3
{
    public class UseMe
    {
    }
}