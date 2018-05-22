using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attribute_ContextMenuItem : MonoBehaviour
{
    [ContextMenuItem("Reset", "ResetBiography")]
    [Multiline(8)]
    public string playerBiography = "";
    void ResetBiography() {
        playerBiography = "";
    }
    
    //给字段添加右击菜单命令
    //Use this attribute to add a context menu to a field that calls a named method.
}

