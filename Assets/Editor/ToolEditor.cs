using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ToolEditor : MonoBehaviour
{

    [MenuItem("Tool/Print")]     //添加菜单命令
    static void Say()
    {
        Debug.Log("打印");
    }

    //0到49
    [MenuItem("GameObject/Custom new obj", priority = 0)]
    static void CustomCreate()
    {
        Object prefab = Resources.Load("NewObj");
        Instantiate(prefab);
    }

    [MenuItem("Tool/Create ScriptableObject")]
    static void CreateScriptableObject()
    {
        CustomData data = ScriptableObject.CreateInstance<CustomData>();
        data.money = 999;
        AssetDatabase.CreateAsset(data, "Assets/Data/CustomData.asset");
        AssetDatabase.Refresh();
    }
}


   

