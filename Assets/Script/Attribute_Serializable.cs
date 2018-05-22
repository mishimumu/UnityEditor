using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attribute_Serializable : MonoBehaviour
{
    [HideInInspector]    //使变量不在检查器中显示，但要序列化。
    public int money;

    [SerializeField]     //序列化私有字段
    private uint exp;

    [System.NonSerialized]   //不进行序列化
    public  string playerName;   

    public Player player;
   
}

[System.Serializable]     //将非继承mono对象进行序列化
public class Player
{
    public string playerName;
    public uint exp;
}

