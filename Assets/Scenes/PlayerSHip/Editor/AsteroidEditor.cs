using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;


namespace CustomEditor
{
    public class AsteroidEditor : EditorWindow
    {
        [MenuItem("[CustomEditor]/Asteroid Editor Tool")]
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
}
