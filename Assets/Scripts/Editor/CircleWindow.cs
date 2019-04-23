using UnityEditor;
using UnityEngine;

public class CircleWindow : EditorWindow
{
    Circle MyCircle;
    public float myVertexFloat;
    public float myRadiusFloat;

    private void Awake()
    {
        MyCircle = FindObjectOfType<Circle>();
    }

    [MenuItem("Window/CircleWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CircleWindow));
    }

    private void OnGUI()
    {
        myVertexFloat = EditorGUILayout.Slider("VertexCount", MyCircle.vertexCount, 3, 40);
        myRadiusFloat = EditorGUILayout.Slider("Radius", MyCircle.radius, 1, 100);
        MyCircle.radius = myRadiusFloat;
        //MyCircle.vertexCount = myVertexFloat;
    }
}