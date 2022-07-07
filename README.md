Shared RPC Service for Nine Chronicles
======================================

This repository contains a piece of common interfaces between Nine Chronicles
the Unity project and *NineChronicles.Headless* project.  It also automatically
generate source code files duruing MSBuild process (`dotnet build`).

Note that the generated source code files are not intended to be used with
Unity by default.  For Unity, you should provide `UseUnityAttr` property as
well:

    dotnet build /p:UseUnityAttr=true