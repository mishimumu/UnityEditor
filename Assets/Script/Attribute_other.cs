using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attribute_other : MonoBehaviour
{
    [Multiline(3)]      //多行文本
    public string message01;

    [TextArea]          //区域文本
    public string message02;
    
    [Tooltip("玩家名字")]   //悬浮提示
    public string playerName;

    [Header("简介")]        //字段前一行添加说明
    public string desc;

    [Range(0f, 10f)]       //给数值类型添加范围,int 和float类型
    public float speed;

    [Range(0, 100)]        
    public int attack;
    
    [ColorUsage(true)]       //在“颜色”上使用此属性可配置“颜色字段”和“颜色选择器”以显示/隐藏Alpha值以及将颜色作为HDR颜色还是作为正常的LDR颜色处理。
    public Color color;      

    [Space(10)]
    public int def;          //添加字段间添加空行
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

