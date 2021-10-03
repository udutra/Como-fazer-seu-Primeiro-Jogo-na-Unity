using UnityEngine;

public class SeguirJogador : MonoBehaviour {

    public PlayerController playerController;
    public Vector3 distanciaJogador;

    private void Update() {
        if(playerController == null) {
            return;
        }
        this.transform.position = playerController.transform.position + distanciaJogador;
    }
}