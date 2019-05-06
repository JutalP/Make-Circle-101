using UnityEditor;
using UnityEngine;

public class CircleWindow : EditorWindow
{
    public int myVertexFloat;
    public float myRadiusFloat;

    [MenuItem("Window/CircleWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CircleWindow));
    }

    private void OnGUI()
    {
        Circle MyCircle = null;
        if (Selection.gameObjects.Length > 0)
        {
            MyCircle = Selection.gameObjects[0]?.GetComponent<Circle>();
        }
        if (!MyCircle)
        {
            return;
        }
        myVertexFloat = EditorGUILayout.IntSlider("VertexCount", MyCircle.vertexCount, 3, 40);
        myRadiusFloat = EditorGUILayout.Slider("Radius", MyCircle.radius, 1, 100);
        MyCircle.radius = myRadiusFloat;
        MyCircle.vertexCount = myVertexFloat;
        MyCircle.SetupCircle();
        SceneView.RepaintAll();
    }
}