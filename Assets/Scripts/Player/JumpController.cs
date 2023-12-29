using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] float jumpSpeed;
    [SerializeField]
    private RigidbodyManager rbManager;
    private Rigidbody rb;

    void Start()
    {
        rb = rbManager.GetRigidbody();
    }

    void OnCollisionStay(Collision collision)
    {
        if( collision.gameObject.CompareTag("Ground"))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(PlayerMovementController.carptiMi==false)
                {
                    Jump();

                }
            }
        }
       
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }

}
