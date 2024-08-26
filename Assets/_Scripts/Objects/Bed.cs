using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Interctable
{
    
    public override void onInteracting()
    {
        Debug.Log("Interacting with bed");
    }
    public override void onStopInteracting()
    {
        Debug.Log("Stopped interacting with bed");
    }
}
