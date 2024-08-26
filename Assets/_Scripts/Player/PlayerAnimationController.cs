using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private Animator animator;
    private Vector2 movement;
    private float speed;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = playerController.movement.x;
        movement.y = playerController.movement.y;
        speed = movement.sqrMagnitude;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", speed);
    }

}
