using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using AudicaModding;

[assembly: AssemblyTitle(MyMod.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(MyMod.BuildInfo.Company)]
[assembly: AssemblyProduct(MyMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + MyMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(MyMod.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(MyMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(MyMod.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(MyMod), MyMod.BuildInfo.Name, MyMod.BuildInfo.Version, MyMod.BuildInfo.Author, MyMod.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]