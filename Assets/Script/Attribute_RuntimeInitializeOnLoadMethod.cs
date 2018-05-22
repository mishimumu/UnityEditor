using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute_RuntimeInitializeOnLoadMethod  {

    // Create a non-MonoBehaviour class which displays
    // messages when a game is loaded.
    
    [RuntimeInitializeOnLoadMethod]
    static void Load()
    {
        Debug.Log("scene loaded");//场景激活后(awake)调用，在RuntimeInitializeLoadType.AfterSceneLoad之前
    }


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Load1()
    {
        Debug.Log("AfterSceneLoad");//场景加载激活(awake)之后调用
    }


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Load2()
    {
        Debug.Log("BeforeSceneLoad");//场景激活之前调用
    }
    
     /*
     * 当运行时加载游戏时，允许运行时类方法初始化，而不需要用户采取行动。
     * 标记为[RuntimeInitializeOnLoadMethod]的方法在加载游戏后调用。 这是在唤醒方法被调用之后。
     * 注意：标记为[RuntimeInitializeOnLoadMethod]的方法的执行顺序不能保证。
     * 
     * Allow a runtime class method to be initialized when a game is loaded at runtime without action from the user.
     * Methods marked [RuntimeInitializeOnLoadMethod] are invoked after the game has been loaded. This is after the Awake method has been invoked.
     * Note: The execution order of methods marked [RuntimeInitializeOnLoadMethod] is not guaranteed.
     */
}
