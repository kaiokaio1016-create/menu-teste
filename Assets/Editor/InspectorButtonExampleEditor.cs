using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InspectorButtonExample))]
public class InspectorButtonExampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        InspectorButtonExample script =
            (InspectorButtonExample)target;

        if (GUILayout.Button("Criar Cubo"))
        {
            script.MeuBotao();
        }
    }
}
