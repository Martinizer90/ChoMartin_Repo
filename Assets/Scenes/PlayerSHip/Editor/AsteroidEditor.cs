using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class AsteroidEditor : EditorWindow
{
    [MenuItem("Assets/Asteroid Editor Tool")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<AsteroidEditor>("Asteroid Editor Tool");
    }

    private void OnGUI()
    {
        //window code goes here
        GUILayout.Label("Selection Filters: ", EditorStyles.boldLabel);
    }
}
