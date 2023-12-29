using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyManager : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
