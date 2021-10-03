using UnityEngine;

public class LevaNaveAoPlaneta : MonoBehaviour {
    public PlayerController player;
    public SeguirJogador seguirJogador;
    public GameObject planeta;
    public float forcaAoPlaneta;

    private void FixedUpdate() {
        Vector3 direcaoAoPlaneta = planeta.transform.position - player.transform.position;
        if(direcaoAoPlaneta.magnitude < 50.0f) {
            this.enabled = false;
            player.rb.velocity = new Vector3(0, 0, 0);
            return;
        }
        
        direcaoAoPlaneta.Normalize();
        player.rb.AddForce(direcaoAoPlaneta * Time.fixedDeltaTime * forcaAoPlaneta);
    }

    public void LeveNaveAoPlaneta() {
        this.enabled = true;
        seguirJogador.enabled = false;
        player.enabled = false;
    }
}