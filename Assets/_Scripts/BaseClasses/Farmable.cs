using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmable : WorldObject
{
    public override void onDistanceEnter()
    {
        Debug.Log("Player is close to farmable object");
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Harvest();
        }
    }
    virtual public void Harvest()
    {
        Debug.Log("Harvesting");
    }
}
