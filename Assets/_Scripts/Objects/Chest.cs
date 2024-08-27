using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interctable
{
    [SerializeField]
    private List<Item> _items = new List<Item>();

    [SerializeField]
    private Animator _anim;

    private bool _isOpenned;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        
    }

    public override void onInteracting()
    {
        _isOpenned = true;
        _anim.SetBool("OpenChest", _isOpenned);
        Debug.Log("Interacting with chest");
    }
    public override void onStopInteracting()
    {
        _isOpenned = false;
        _anim.SetBool("OpenChest",_isOpenned);
       Debug.Log("stopped interraction with chest");
       
    }
}
