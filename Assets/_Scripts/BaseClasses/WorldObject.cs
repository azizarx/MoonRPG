using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{
    virtual public void onDistanceEnter()
    {
        Debug.Log("Player is close to object");
    }
}
