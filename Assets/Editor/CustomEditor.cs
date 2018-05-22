using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(MyPlayer))]
public class CustomInspectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        MyPlayer customInspector = (MyPlayer)target;
        EditorGUILayout.BeginVertical();
        
        customInspector.title=EditorGUILayout.TextField("title",customInspector.title);
        EditorGUILayout.LabelField("内容：", customInspector.content);
        customInspector.type=(MessageType)EditorGUILayout.EnumPopup("消息类型", customInspector.type);
        customInspector.fontColor=EditorGUILayout.ColorField("字体颜色",customInspector.fontColor);
        customInspector.font=EditorGUILayout.IntSlider("字体大小", customInspector.font, 10, 50);
        customInspector.icon = EditorGUILayout.ObjectField("玩家头像", customInspector.icon, typeof(Texture2D), true, GUILayout.ExpandHeight(false)) as Texture2D;
        EditorGUILayout.EndVertical();

    }

    private void OnSceneGUI()
    {
        
    }

    

}

