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
            Debug.Log("�������I");
        }

        if (GUILayout.Button("EnptyClass�̌Ăяo��"))
        {
            taegetClass.OutputLog();
            Debug.Log("�Ăяo��");
        }
    }
}
