using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody rb;
    public int forceX, forceY, forceZ;
    public GameController gameController;
    public float velocidadeMaximaZ;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        //forceX = 3600;
        //forceY = 0;
        //forceZ = 900;
    }

    private void FixedUpdate() {
        if(rb.velocity.z < velocidadeMaximaZ) {
            rb.AddForce(0, 0, forceZ * Time.fixedDeltaTime);
        }

        if(Input.GetKey("a") == true) {
            rb.AddForce(-forceX * Time.fixedDeltaTime, 0, 0);
        }
        if(Input.GetKey("d") == true) {
            rb.AddForce(forceX * Time.fixedDeltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        switch(collision.collider.tag) {
            case "Inimigo1": {
                    gameController.GameOver();
                    break;
                }
            case "Inimigo2": {
                    gameController.GameOver();
                    break;
                }
            case "Inimigo3": {
                    gameController.GameOver();
                    break;
                }
            case "Parede": {
                    gameController.GameOver();
                    break;
                }
            default:
                Debug.LogError("Erro no switch no método: OnCollisionEnter do Script PlayerControler!");
                break;
        }
    }

    private void OnTriggerEnter(Collider other) {
        switch(other.tag) {
            case "Planeta": {
                    gameController.VencerJogo();
                    break;
                }
            default:
                break;
        }
    }
}