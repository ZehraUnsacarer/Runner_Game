using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        Material collidedMaterial = collision.gameObject.GetComponent<Renderer>().material;
        Material playerMaterial = player.GetComponent<Renderer>().material;

        if (collision.gameObject.CompareTag("Color_Changer"))
        {
            playerMaterial = collidedMaterial;

            player.GetComponent<Renderer>().material = playerMaterial;
            Destroy(collision.gameObject);
        }

        
    }
}
