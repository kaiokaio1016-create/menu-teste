using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorButtonExample : MonoBehaviour
{
    public void MeuBotao()
    {
        Debug.Log("Botão clicado!");

        GameObject cube =
            GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = Vector3.zero;
    }
}