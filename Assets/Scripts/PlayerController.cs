using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public Rigidbody rb;
    public int forceX, forceY, forceZ;
    public GameController gameController;
    public float velocidadeMaximaZ, anguloAlvo, velocidadeRotacao;
    public GameObject fxExplosaoPrefab;

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
            Quaternion rotacaoAtual = rb.rotation;
            Quaternion rotacaoAlvo = Quaternion.Euler(0, 0, anguloAlvo);
            Quaternion novaRotacao = Quaternion.Lerp(rotacaoAtual, rotacaoAlvo, Time.fixedDeltaTime * velocidadeRotacao);
            rb.MoveRotation(novaRotacao);
        }
        else if(Input.GetKey("d") == true) {
            rb.AddForce(forceX * Time.fixedDeltaTime, 0, 0);
            Quaternion rotacaoAtual = rb.rotation;
            Quaternion rotacaoAlvo = Quaternion.Euler(0, 0, -anguloAlvo);
            Quaternion novaRotacao = Quaternion.Lerp(rotacaoAtual, rotacaoAlvo, Time.fixedDeltaTime * velocidadeRotacao);
            rb.MoveRotation(novaRotacao);
        }

        else {
            Quaternion rotacaoAtual = rb.rotation;
            Quaternion rotacaoAlvo = Quaternion.Euler(0, 0, 0);
            Quaternion novaRotacao = Quaternion.Lerp(rotacaoAtual, rotacaoAlvo, Time.fixedDeltaTime * velocidadeRotacao);
            rb.MoveRotation(novaRotacao);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        switch(collision.collider.tag) {
            case "Inimigo1": {
                    gameController.GameOver();
                    GameObject.Instantiate(fxExplosaoPrefab, this.transform.position,this.transform.rotation);
                    Destroy(this.gameObject);
                    break;
                }
            case "Inimigo2": {
                    gameController.GameOver();
                    GameObject.Instantiate(fxExplosaoPrefab, this.transform.position, this.transform.rotation);
                    Destroy(this.gameObject);
                    break;
                }
            case "Inimigo3": {
                    gameController.GameOver();
                    GameObject.Instantiate(fxExplosaoPrefab, this.transform.position, this.transform.rotation);
                    Destroy(this.gameObject);
                    break;
                }
            case "Parede": {
                    gameController.GameOver();
                    GameObject.Instantiate(fxExplosaoPrefab, this.transform.position, this.transform.rotation);
                    Destroy(this.gameObject);
                    break;
                }
            default:
                Debug.LogError("Erro no switch no método: OnCollisionEnter do Script PlayerControler! collision:" + collision.gameObject.name);
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