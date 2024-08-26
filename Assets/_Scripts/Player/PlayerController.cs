using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private Rigidbody2D rb;
    [HideInInspector]
    public Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition( rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    
    }

}
