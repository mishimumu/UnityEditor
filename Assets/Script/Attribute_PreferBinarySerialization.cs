using UnityEngine;

// Custom asset type that prefers binary serialization.
//
// Create a new asset file by going to "Asset/Create/Custom Data".
// If you open this new asset in a text editor, you can see how it
// is not affected by changing the project asset serialization mode.
//
[CreateAssetMenu]
[PreferBinarySerialization]
public class Attribute_PreferBinarySerialization : ScriptableObject
{
    public float[] lotsOfFloatData = new[] { 1f, 2f, 3f };
    public byte[] lotsOfByteData = new byte[] { 4, 5, 6 };
    
    /*
    *无论项目的资产序列化模式如何，都希望ScriptableObject派生类型使用二进制序列化。
    *这对于包含大量数据的自定义资产类型非常有用。始终将它们保存为二进制文件既可以提高读/写性能，也可以在磁盘上生成更紧凑的表示。
    *主要缺点是二进制资产文件不再是人类可读的，并且您不能再将它们合并到版本控制软件中。
    *Unity中的资产序列化在整个文件中始终使用一致的序列化模式。因此，当一个资产文件包含多个资产时，
    * 可能并不总是能够满足迫使某个特定资产使用二进制序列化的愿望。资产文件的序列化模式由该路径上的主资源控制。
    * 因此，使用AssetDabase.CreateAsset和AssetDatabase.AddObjectToAsset组合复杂资产时必须小心，以确保主资产是具有此属性集的对象。
    * 场景文件始终遵循项目中配置的资产序列化模式，因此对于场景中嵌入的资产，始终会忽略PreferBinarySerialization。
    *该属性只能应用于ScriptableObject派生类，所有其他类型都将被忽略。

    * Prefer ScriptableObject derived type to use binary serialization regardless of project's asset serialization mode.
    *This is useful for custom asset types that contain large amounts of data. Always keeping them stored as binary
    * can both improve read/write performance, as well as produce more compact representations on disk.
    * The major downsides are that binary asset files are no longer humanly readable, 
    * and that you can no longer merge them in your revision control software.
    * Asset serialization in Unity always uses a consistent serialization mode throughout the entirety of each file.
    * As a result, when an asset file contains multiple assets, it might not always be possible to respect the desire to
    * force a specific asset to use binary serialization. The serialization mode of an asset file is controlled by the main asset at that path.
    * As a result, care has to be taken when composing complex assets using AssetDabase.CreateAsset and AssetDatabase.AddObjectToAsset 
    * to ensure that the main asset is the object with this attribute set. 
    * Scene files always follow the asset serialization mode configured in the project, 
    * thus PreferBinarySerialization is always ignored for assets embedded in scenes.
    * The attribute can only be applied to ScriptableObject derived classes, it will be ignored for all other types.
    */
}
