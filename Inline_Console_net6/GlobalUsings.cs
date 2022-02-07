// GlobalUsings.cs
// 2022 02 07 4:32 PM

extern alias Dll1;
extern alias Dll2;
global using StaticMethodsNamespace1;
global using CustomNamespace;
global using a = System.Collections.Generic.List<string?>;
global using Inline_Referenced_Lib3;
global using NugetAlias = System.Text.Json.Nodes;
global using Inline_Referenced_Lib;
global using static Inline_Console_net6.Namespace1.StaticExtensionMethodDeclaration;
global using Inline_Shared;
//global using NotExisting;

// TODO: type global using Alias = System;

//global using Inline_Core_Console_net6.Use;
global using static System.Numerics.Vector2;
global using Alias = Inline_Core_Console_net6.Use;
global using Dll1::Dll;
global using A = Dll1::Dll.Class1;
//global using Dll2::Dll;
global using static System.Console;