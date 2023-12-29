using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathController : MonoBehaviour
{
    [SerializeField] GameObject player;

    Color redColor = Color.red;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrier")) 
        {
            Material collidedMaterial = collision.gameObject.GetComponent<Renderer>().material;
            Color collidedColor = collidedMaterial.color;

            Material playerMaterial = player.GetComponent<Renderer>().material;
            Color playerColor = playerMaterial.color;

            if (playerColor == collidedColor)
            {
                Destroy(collision.gameObject);

            }
            else
            {
                collidedMaterial.color= redColor;
                PlayerMovementController.carptiMi = true;
            }
        }
    }
}
