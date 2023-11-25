using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AsteroidEditor : EditorWindow
{
    [MenuItem("GameObject/Asteroid Editor Tools")]
    public static void ShowWindow()
    {
        GetWindow<AsteroidEditor>("Asteroid Editor Tools");
    }

    private void OnGUI()
    {
        //window code goes here
        GUILayout.Label("Selection Filters: ", EditorStyles.boldLabel);
    }
}
