// UseNuget.cs
// 2022 02 07 3:37 PM


namespace Inline_Core_Console_net6;
using NugetAlias = OverwriteNuget1;
public class UseNuget
{
    private void Test()
    {
        new NugetAlias.JsonArray();
        new System.Text.Json.Nodes.JsonArray();
    }
}