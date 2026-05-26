using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolbarButton
{
    [MenuItem("Ferramentas/Criar Esfera")]
    public static void CriarEsfera()
    {
        GameObject sphere =
            GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sphere.transform.position = Vector3.zero;

        Debug.Log("Esfera criada!");
    }
}