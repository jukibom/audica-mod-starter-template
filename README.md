# audica-mod-starter-template

This template bundles melon-mod and a simple dll-building C# solution + csproj.

## Getting Started

You'll need Visual Studio community 2017 setup to build.

Optional: Use `get-started.ps1` (right click => Run With PowerShell) to configure the name / author / version of the mod as well as add a post-build step to automatically copy the last built debug or release dll to the Audica mods directory.

NOTE: I have not tested the audica directory auto-location for non-steam versions of Audica but it should work! If not, the script should prompt for manual input but please let me know if there are any problems.
