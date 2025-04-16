// C# example.
using UnityEditor;
using System.Diagnostics;
using System.IO;

public class ScriptBatch 
{
    [MenuItem("MyTools/Build Multiple")]
    public static void BuildMultiple ()
    {
        // // Get filename.
        // string path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "", "");
        // string[] levels = new string[] {"Assets/Scene1.unity", "Assets/Scene2.unity"};

        // // Build player.
        // BuildPipeline.BuildPlayer(levels, path + "/BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        // Copy a file from the project folder to the build folder, alongside the built game.
        if (!File.Exists ("Assets/Settings/MultiBuildSettings.asset")) {
            UnityEngine.Debug.LogError ("MultiBuildSettings.asset not found. Please create it via the Create menu.");
            return;
        }

        // // Run the game (Process class from System.Diagnostics).
        // Process proc = new Process();
        // proc.StartInfo.FileName = path + "/BuiltGame.exe";
        // proc.Start();
    }
}