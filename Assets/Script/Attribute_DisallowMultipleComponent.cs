using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Attribute_DisallowMultipleComponent : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //同一个对象上，不可以添加相同脚本
    //Prevents MonoBehaviour of same type (or subtype) to be added more than once to a GameObject.
}
