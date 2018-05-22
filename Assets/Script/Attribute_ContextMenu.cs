public class Attribute_ContextMenu : MonoBehaviour
{

    /// Add a context menu named "Do Something" in the inspector
    /// of the attached script.
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
    //检视面板上给这个脚本添加菜单命令
    //The ContextMenu attribute allows you to add commands to the context menu.
    //In the inspector of the attached script. When the user selects the context menu, the function will be executed.
    //This is most useful for automatically setting up scene data from the script. The function has to be non-static.

}
