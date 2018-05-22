using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Attribute_ExecuteInEditorMode : MonoBehaviour
{
    public Color color;
    public Text myTxt;
    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        myTxt.color = color;
    }

    /*
    使编辑模式下的脚本的所有实例都可以执行。
    默认情况下，MonoBehaviours仅在播放模式下执行。 通过添加此属性，MonoBehaviour的任何实例都将在编辑器未处于播放模式时执行其回调函数。

    这些功能并不像它们处于播放模式那样不断地被调用。
    Update- 仅当场景中的某些内容发生更改时才会调用更新。
    OnGUI- 当Game View收到事件时，OnGUI被调用。
    OnRenderObject- 每次重新绘制场景视图或游戏视图时，都会调用OnRenderObject和其他渲染回调函

    Makes all instances of a script execute in edit mode.
    By default, MonoBehaviours are only executed in play mode. By adding this attribute, any instance of the MonoBehaviour will have its callback functions executed while the Editor is not in playmode.

    The functions are not called constantly like they are in play mode.
    - Update is only called when something in the scene changed.
    - OnGUI is called when the Game View recieves an Event.
    - OnRenderObject and the other rendering callback functions are called on every repaint of the Scene View or Game View.
    */
}

