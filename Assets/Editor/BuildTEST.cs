using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildTEST : MonoBehaviour
{
    public static void Build64()
    {
        string path = "C:/Program Files/Unity/Hub/Editor/2021.3.7f1/Editor";
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };

        BuildPipeline.BuildPlayer(scenes, path, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}