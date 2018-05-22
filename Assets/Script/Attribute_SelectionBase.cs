using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Attribute_SelectionBase : MonoBehaviour {

       /*
     * 将此属性添加到脚本类以将其GameObject标记为场景视图拾取的选择基础对象。
     * 在Unity场景视图中，单击以选择对象时，Unity会尝试找出最适合您的对象。
     * 如果您单击属于预制件一部分的对象，则会选中预制件的根部，因为预制根被视为选择基础。
     * 您也可以将其他对象视为选择基础。 您需要使用SelectionBase属性创建一个脚本类，然后您需要将该脚本添加到GameObject中。
     * 
     * Add this attribute to a script class to mark its GameObject as a selection base object for Scene View picking.
     * In the Unity Scene View, when clicking to select objects, Unity will try to figure out the best object to select for you.
     * If you click on an object that is part of a prefab, the root of the prefab is selected,
     * because a prefab root is treated as a selection base. You can make other objects be treated as selection base too.
     * You need to create a script class with the SelectionBase attribute, and then you need to add that script to the GameObject.
     */
}
