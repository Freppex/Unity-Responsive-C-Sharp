/*
 using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ObjectsResponsive))]
public class ObjectResponsiveEditor : Editor
{
    float SHeight = 800; //Min. Screen Height
    float SWidth = 480; //Min. Screen Width

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        ObjectsResponsive ScriptAPI = (ObjectsResponsive)target;
        if (GUILayout.Button("Auto Edited"))
        {
            RectTransform rt = (RectTransform)ScriptAPI.transform;
            ScriptAPI.YourWidthRatio = rt.rect.width * 100 / SWidth;
            ScriptAPI.YourHeightRatio = rt.rect.height * 100 / SHeight;

            ScriptAPI.YourXRatio = ScriptAPI.transform.localPosition.x * 100 / SWidth;
            ScriptAPI.YourYRatio = ScriptAPI.transform.localPosition.y * 100 / SHeight;
            ScriptAPI.YourZRatio = ScriptAPI.transform.localPosition.z;

            Debug.Log(ScriptAPI.name + " / Edited!");
        }
    }



}*/