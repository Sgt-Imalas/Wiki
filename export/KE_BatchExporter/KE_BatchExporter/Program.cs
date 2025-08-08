// See https://aka.ms/new-console-template for more information
using KE_BatchExporter;
using System.Diagnostics;

var kanimdir = new DirectoryInfo("E:\\Documents\\Klei\\OxygenNotIncluded\\mods\\dev\\RonivansLegacy_ChemicalProcessing_dev\\anim");
var kanimfiles = KanimFinder.FindKanimFilesRecursively(kanimdir);

return;
foreach (var kanim in kanimfiles)
{
	ProcessStartInfo startInfo = new ProcessStartInfo();
	startInfo.FileName = @"E:\Documents\GitHub\kanim-explorer\src\KanimExplorer\bin\Release\net8.0-windows\KanimExplorer.exe";
	startInfo.Arguments = $"--exportFrame --build \"{kanim.Build}\" --anim \"{kanim.Anim}\" --texture \"{kanim.SpriteSheet}\" --animName \"off\" --frameNumber 0";
	var process = Process.Start(startInfo);
}
