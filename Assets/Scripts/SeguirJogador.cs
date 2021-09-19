using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJogador : MonoBehaviour {

    public PlayerController playerController;
    public Vector3 distanciaJogador;

    private void Update() {
        this.transform.position = playerController.transform.position + distanciaJogador;
    }
}