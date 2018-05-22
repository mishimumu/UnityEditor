using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
[CustomEditor(typeof(HandleTest))]
public class HandleEditor : Editor
{

    private void OnSceneGUI()
    {
        Handles.BeginGUI();
        if (GUILayout.Button("按钮", GUILayout.Width(100))) { Debug.Log("点击按钮"); }

        GUILayout.Label("你好");

        Handles.EndGUI();

        HandleTest test = (HandleTest)target;
        Handles.CubeHandleCap(0, test.transform.position + Vector3.one, Quaternion.identity, 0.5f, EventType.Repaint);
        
        //绘制3d按钮
        HandleTest buttonExample = (HandleTest)target;
        Vector3 position = buttonExample.transform.position + Vector3.up * 2f;
        float size = 2f;
        float pickSize = size * 2f;

        if (Handles.Button(position, Quaternion.identity, size, pickSize, Handles.RectangleHandleCap))
            Debug.Log("The button was pressed!");
    }
        /*
     * 自定义3D GUI控件并在场景视图中绘制。
     * 手柄是Unity用于操纵场景视图中项目的3D控件。 有许多内置的Handle GUI，例如通过Transform组件定位，缩放和旋转对象的常用工具。
     *  但是，也可以定义您自己的Handle GUI以与定制组件编辑器一起使用。
     *  这些图形用户界面可以是编辑程序生成的场景内容，“隐形”项目和相关对象组（如航点和位置标记）的非常有用的方法。
     *  您还可以使用2D按钮和覆盖在场景视图上的其他控件补充场景中的3D手柄GUI。 
     *  这是通过将标准的Unity GUI调用封装在Editor.OnSceneGUI函数的Handles.BeginGUI和Handles.EndGUI对中来完成的。
     *  您可以使用HandleUtility.GUIPointToWorldRay和HandleUtility.WorldToGUIPoint转换2D GUI和3D世界坐标之间的坐标。
     *  
     *  Custom 3D GUI controls and drawing in the scene view.
     *  Handles are the 3D controls that Unity uses to manipulate items in the scene view. 
     *  There are a number of built-in Handle GUIs, such as the familiar tools to position, scale and rotate an object via the Transform component.
     *  However, it is also possible to define your own Handle GUIs to use with custom component editors. 
     *  Such GUIs can be a very useful way to edit procedurally-generated scene content,
     *  "invisible" items and groups of related objects, such as waypoints and location markers.
     *  You can also supplement the 3D Handle GUI in the scene with 2D buttons and other controls overlaid on the scene view.
     *  This is done by enclosing standard Unity GUI calls in a Handles.BeginGUI and Handles.EndGUI pair within the Editor.
     *  OnSceneGUI function. You can use HandleUtility.GUIPointToWorldRay and HandleUtility.
     *  WorldToGUIPoint to convert coordinates between 2D GUI and 3D world coordinates.
     */
}
