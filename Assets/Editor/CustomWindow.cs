using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Xml.Linq;

public class CustomWindow : EditorWindow
{
    public static string filePath;
    static List<Role> data = new List<Role>();
    [MenuItem("Tool/OpenWindow")]
    static void OpenWindow()
    {

        CustomWindow window = (CustomWindow)EditorWindow.GetWindow(typeof(CustomWindow));
        window.Show();
        data.Clear();
        filePath = "file://" + Application.dataPath + "/Resources/Role.xml";
        data = ReadXml<Role>.Load(filePath);
    }

    

    private void OnEnable()
    {
       // Debug.Log("OnEnable");
    }

    private void OnSelectionChange()
    {
       // Debug.Log("OnSelectionChange");
    }

    private void OnFocus()
    {
      //  Debug.Log("OnFocus");

    }

    private void OnLostFocus()
    {
      //  Debug.Log("OnLostFocus");

    }

    private void OnHierarchyChange()
    {
      //  Debug.Log("OnHierarchyChange");

    }

    private void OnInspectorUpdate()
    {
       // Debug.Log("OnInspectorUpdate");
    }

    private void OnProjectChange()
    {
      //  Debug.Log("OnProjectChange");
      //  data = ReadXml<Role>.Load(filePath);
    }

    private void OnDisable()
    {
      //  Debug.Log("OnDisable");

    }

    Object audioProperty;
    private void OnGUI()
    {
       // EditorGUILayout.BeginVertical();
        //foreach (var role in data)
        //{
        //}
        //for (int i = 0; i < data.Count; i++)
        //{
        //    EditorGUI.DrawRect(new Rect(10, i * (100 + 10), position.width - 10, 100), Color.white);
        //    EditorGUILayout.BeginHorizontal();
        //    EditorGUILayout.LabelField(data[i].id);
        //    Texture tex = AssetDatabase.LoadAssetAtPath(data[i].icon, typeof(Texture)) as Texture;
        //    EditorGUI.DrawPreviewTexture(new Rect(20, i * (100 + 20), 80, 80), tex);
        //    EditorGUILayout.EndHorizontal();
        //}
       // EditorGUILayout.EndVertical();
        Texture tex = AssetDatabase.LoadAssetAtPath(data[0].icon, typeof(Texture)) as Texture;
        EditorGUI.DrawPreviewTexture(new Rect(20,  20, 80, 80), tex);
        EditorGUI.LabelField(new Rect(120, 30, 60, 30), "玩家名字:");
        EditorGUI.LabelField(new Rect(180, 30, 60, 30), data[0].name);
        EditorGUI.LabelField(new Rect(120, 60, 60, 30), "声音:");
        audioProperty = AssetDatabase.LoadAssetAtPath(data[0].Audio, typeof(AudioClip));
        EditorGUI.ObjectField(new Rect(180, 60, 100, 20),audioProperty,typeof(AudioClip),true);
        EditorGUI.LabelField(new Rect(120, 90, 60, 30), "攻击:");
        EditorGUI.ProgressBar(new Rect(180, 90, 100, 15), data[0].attack/10f, data[0].attack.ToString());
        EditorGUI.LabelField(new Rect(120, 120, 60, 30), "防御:");
        EditorGUI.ProgressBar(new Rect(180, 120, 100, 15), data[0].def / 10f, data[0].def.ToString());
    }

}




