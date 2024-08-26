using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Farmable
{
    public override void Harvest()
    {
        Debug.Log("harvesting the rock");
    }
}
