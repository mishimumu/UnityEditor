using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{
    public string title;
    public string content = "hello boy";
    public MessageType type;
    public Color fontColor;
    public int font;
    public Texture2D icon;
    
}

//自定义检视面板
//新建类
//然后editor文件夹下新建类，添加特性CustomEditor，如[CustomEditor(typeof(MyPlayer))]
//重写OnInspectorGUI
//Tells an Editor class which run-time type it's an editor for.
//When you make a custom editor for a component, you need put this attribute on the editor class.

public enum MessageType
{
    Normal,
    Reward,
    Notification
}

