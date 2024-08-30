using UnityEngine;

public class InteractingSystem : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;
    [SerializeField]
    private Transform _interactionCircle;
    private void Update()
    {
        //Casting a circle to detect objects
        Collider2D hit = Physics2D.OverlapCircle(_interactionCircle.position, 0.4f, ~_layerMask);
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
        UnityEditor.Handles.DrawWireDisc(_interactionCircle.position, Vector3.back, 0.4f);

    }
}
