using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interctable
{
    [SerializeField]
    private List<Item> _items = new List<Item>();
    
    public override void onInteracting()
    {
        Debug.Log("Interacting with chest");
    }
    public override void onStopInteracting()
    {
        base.onStopInteracting();
    }
}
