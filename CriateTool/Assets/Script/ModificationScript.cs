using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnptyScript))]
public class ModificationScript : Editor
{
    public override void OnInspectorGUI()
    {
        var taegetClass = target as EnptyScript;
        if (GUILayout.Button("Button"))
        {
            Debug.Log("押した！");
        }

        if (GUILayout.Button("EnptyClassの呼び出し"))
        {
            taegetClass.OutputLog();
            Debug.Log("呼び出し");
        }
    }
}
