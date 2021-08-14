using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeLogic))]
public class CubeLogicEditor : Editor
{
    Color m_color;
    float m_cubeSize;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CubeLogic cubeLogic = (CubeLogic)target;

        GUILayout.Label("Press Button below to generate random color");
        if (GUILayout.Button("Generate Color"))
        {
            if (cubeLogic)
            {
                cubeLogic.GenerateColor();
            }
           
        }
        m_color = EditorGUILayout.ColorField("Select your color", m_color);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Set color field color"))
        {
            if (cubeLogic)
            {
                cubeLogic.SetColor(m_color);
            }

        }

        if (GUILayout.Button("Reset Color"))
        {
            if (cubeLogic)
            {
                cubeLogic.SetColor(Color.white);
            }

        }
        GUILayout.EndHorizontal();


       m_cubeSize =  EditorGUILayout.Slider(m_cubeSize, 0, 5);
        if (cubeLogic)
        {
            cubeLogic.SetScale(m_cubeSize);
        }

    }
    
}
