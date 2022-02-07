// WithUnusedUsing.cs
// 2022 02 07 12:37 PM

// ReSharper disable once RedundantUsingDirective
using Inline_Core_Console_net6.Use2;

namespace Inline_Core_Console_net6;

// ReSharper disable once UnusedType.Global
public class WithUnusedUsing
{
    // ReSharper disable once UnusedMember.Local
    private void Test()
    {
        // ReSharper disable once UnusedVariable
        var useMe = new UseMe();
    }
}