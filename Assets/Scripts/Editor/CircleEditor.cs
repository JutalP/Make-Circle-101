using UnityEngine;
using UnityEditor;
using System.Collections;

class MyWindow : Editor
{
    SerializedProperty vertexCount;

    [MenuItem("Window/My Window")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CircleWindow));
    }


    private void OnEnable()
    {
        vertexCount = serializedObject.FindProperty("vertexCount");
    }

    void OnGUI()
    {
        // The actual window code goes here
    }
}
