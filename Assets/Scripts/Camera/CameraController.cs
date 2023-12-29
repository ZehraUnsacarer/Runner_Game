using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    Vector3 distance;

    private void Start()
    {
        distance = transform.position - Player.transform.position;
    }

    private void Update()
    {
        transform.position = Player.transform.position + distance;
    }
}
