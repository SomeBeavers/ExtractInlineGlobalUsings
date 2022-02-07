// Usages5.cs
// 2022 02 07 5:09 PM

using DerivedNamespace;
using InterfaceNamespace;

namespace Inline_Core_Console_net6.Usages;

public class Usages5<T> where T: Usages3
{
    private void Test()
    {
        new Usages5<Usages6>();
    }
}