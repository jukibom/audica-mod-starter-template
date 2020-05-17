# audica-mod-starter-template

This template bundles melon-mod and a simple dll-building C# solution + csproj.

## Getting Started

You'll need Visual Studio community 2017 setup to build.

Optional: Use `get-started.ps1` (right click => Run With PowerShell) to configure the name / author / version of the mod as well as add a post-build step to automatically copy the last built debug or release dll to the Audica mods directory.

NOTE: I have not tested the audica directory auto-location for non-steam versions of Audica but it should work! If not, the script should prompt for manual input but please let me know if there are any problems.

## What now?

Open the main `AudicaModding.sln` and browse to `Main.cs`. You'll see it's setup to log out when you press T on the keyboard. 
Run a build and you should see a new dll file matching the name provided in the get-started script appear in both the local `bin/[Release | Debug]/` and `Audica/Mods` folder.

With MelonMod installed (see discord below), add `--melonloader.console` to audica's launch options in steam or however you're loading Audica.exe and a debug console should spawn along with Audica. If everything's working, pressing T should log out a message!

## Next Steps

Get involved in the Audica Modding Discord, we're lovely and we can point you in the right direction! https://discord.gg/cakQUt5
For MelonMod specific discussion, advice and updates join the MelonMod discord at https://discord.gg/M6VDhjv
