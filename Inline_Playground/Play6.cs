// Play6.cs
// 2022 02 10 11:37 AM

using Play5;

using static Inline_Playground.Test.Play5;
namespace Inline_Playground;

public class Play6
{
    public string Name1{ get; set; }

    private void Test()
    {
        var name = Name;
        new NotPlayClass();
    }
}