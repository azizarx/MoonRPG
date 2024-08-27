using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interctable : WorldObject
{

    protected bool isInteracting = false;

    public override void onDistanceEnter()
    {
        Debug.Log("player is in distance of and interactable object");
        if (!isInteracting && Input.GetKeyDown(KeyCode.E))
        {
            isInteracting = true;
            onInteracting();
        }
        else if(isInteracting && Input.GetKeyDown(KeyCode.E))
        {
            isInteracting = false;
            onStopInteracting();
        }
    }

    virtual public void onInteracting()
    {
        //Debug.Log("Interacting with object");
    }
    virtual public void onStopInteracting()
    {
        Debug.Log("Interaction Stopped");
    }

}
