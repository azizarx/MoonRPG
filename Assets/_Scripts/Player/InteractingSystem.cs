using UnityEngine;

public class InteractingSystem : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;
    private void Update()
    {
        //Casting a circle to detect objects
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 0.6f, ~_layerMask);
        if (hit != null)
        {
            hit.TryGetComponent(out WorldObject worldObject);
            if (worldObject) worldObject.onDistanceEnter();
        }

    }
    //Draw the interaction radius
    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = Color.blue;
        UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, 0.6f);

    }
}
