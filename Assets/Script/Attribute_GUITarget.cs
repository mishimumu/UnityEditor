using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Attribute_GUITarget : MonoBehaviour
{
    [GUITarget(0)]
    private void OnGUI()
    {
        GUI.Button(new Rect(300, 100, 200, 100), "button01");
    }
   //通过display来控制ongui显示，GUITarget(0)表示第一个display时，调用这个ongui
   //参数可以多个如GUITarget(0,1,4)
   //Allows to control for which display the OnGUI is called.
}
