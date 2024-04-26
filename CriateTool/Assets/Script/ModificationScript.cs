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
            Debug.Log("‰Ÿ‚µ‚½I");
        }

        if (GUILayout.Button("EnptyClass‚ÌŒÄ‚Ño‚µ"))
        {
            taegetClass.OutputLog();
            Debug.Log("ŒÄ‚Ño‚µ");
        }
    }
}
