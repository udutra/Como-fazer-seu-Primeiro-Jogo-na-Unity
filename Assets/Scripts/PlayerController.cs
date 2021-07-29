using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public int forceX, forceY, forceZ;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        forceX = 1000;
        forceY = 0;
        forceZ = 500;
    }

    private void FixedUpdate() {

        rb.AddForce(0, 0, forceZ * Time.fixedDeltaTime);

        if(Input.GetKey("a") == true) {
            rb.AddForce(-forceX * Time.fixedDeltaTime, 0, 0);
        }
        if(Input.GetKey("d") == true) {
            rb.AddForce(forceX * Time.fixedDeltaTime, 0, 0);
        }
    }
}