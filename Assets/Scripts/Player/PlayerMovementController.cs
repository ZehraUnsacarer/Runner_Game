using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minZ;
    [SerializeField] float maxZ;

    [SerializeField] private RigidbodyManager rbManager;
    private Rigidbody rb;

    public static bool carptiMi= false;
    private void Start()
    {
        rb = rbManager.GetRigidbody();
    }

    void Update()
    {
        if(!carptiMi)
        {
            Movement();
        }
        ClampPosition();
    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
        
    }

    private void ClampPosition()
    {
        Vector3 clampedPosition = rb.position;
        clampedPosition.x = Mathf.Clamp(rb.position.x, minX, maxX);
        clampedPosition.z = Mathf.Clamp(rb.position.z, minZ, maxZ);
        rb.position = clampedPosition;
    }

}
