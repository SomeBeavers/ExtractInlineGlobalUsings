// Play6.cs
// 2022 02 10 11:37 AM

using A1 = Inline_Playground.Test;

namespace Inline_Playground;

public class Play6
{
    public string Name { get; set; }

    private void Test()
    {
        var name = A1.Play5.Name;
    }
}