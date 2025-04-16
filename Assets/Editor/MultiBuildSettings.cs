using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

[CreateAssetMenu(fileName = "BuildMultipleSettings", menuName = "My Tools/Build Multiple Settings", order = 1)]
public class MultiBuildSettings : ScriptableObject
{
    public BuildSettings[] buildSettings;

    private void Awake() {
        if (buildSettings == null || buildSettings.Length == 0) {
            buildSettings = new BuildSettings[1];
            buildSettings[0] = new BuildSettings();
            buildSettings[0].buildName = "Default";
            int sceneCount = SceneManager.sceneCountInBuildSettings;     
            string[] scenes = new string[sceneCount];
            for( int i = 0; i < sceneCount; i++ )
            {
                scenes[i] = Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
            }
        }
    }

    [System.Serializable]
    public class BuildSettings
    {
        public string buildName;
        public string[] scenes;
        public string outputFolder;
    }
}
