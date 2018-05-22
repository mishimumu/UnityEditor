using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class Attribute_FormerSerializedAs : MonoBehaviour
{
    //[FormerlySerializedAs("myName")]  重命名时取消注释，并将myName修改为新命的字段名
    public string myName;
    
    //使用此属性可以重命名字段而不会丢失其序列化值。
    //Use this attribute to rename a field without losing its serialized value.
}
