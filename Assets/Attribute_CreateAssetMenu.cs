[CreateAssetMenu(fileName = "playerData", menuName = "CreateAssetMenu", order = 0)]
public class Attribute_CreateAssetMenu : ScriptableObject
{
    public string playerName ="zhangsan";
    public uint money = 1000;
    public uint exp = 10;
    public uint[] propID = new uint[] { 1, 2, 3 };
    
    //将ScriptableObject派生类型标记为在Assets / Create子菜单中自动列出，以便可以轻松创建该类型的实例并将其作为“.asset”文件存储在项目中。
    //Mark a ScriptableObject-derived type to be automatically listed in the Assets/Create submenu, 
    //so that instances of the type can be easily created and stored in the project as ".asset" files.
}
