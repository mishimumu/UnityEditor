using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GizmosTest : MonoBehaviour
{
    public float length;
    public Texture tex;

    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(new Vector3(transform.position.x,transform.position.y+2,transform.position.z), "btn_bangzhu");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 1f);
        Gizmos.DrawWireSphere(transform.position, length);
        Gizmos.DrawSphere(transform.position, length);
        Gizmos.DrawGUITexture(new Rect(transform.position.x, transform.position.y + 3, 2, 2), tex);
    }

    /*
     * Gizmos are used to give visual debugging or setup aids in the scene view.
     * All gizmo drawing has to be done in either OnDrawGizmos or OnDrawGizmosSelected functions of the script.
     * OnDrawGizmos is called every frame. All gizmos rendered within OnDrawGizmos are pickable.
     * OnDrawGizmosSelected is called only if the object the script is attached to is selected.
     */
}
