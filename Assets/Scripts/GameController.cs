using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private Vector3 posicaoInicial;
    public GameObject painelGameOver, painelVitoria;
    public Text txtPontuacao;
    public PlayerController player;
    public float divisorPontuacao;

    private void Start() {
        posicaoInicial = player.transform.position;
    }

    private void Update() {
        if(player == null) {
            return;
        }
        Vector3 distanciaPercorrida = player.transform.position - posicaoInicial;
        float pontuacao = distanciaPercorrida.z / divisorPontuacao;
        txtPontuacao.text = pontuacao.ToString("0");
    }

    public void VencerJogo() {
        painelVitoria.SetActive(true);
    }

    public void GameOver() {
        painelGameOver.SetActive(true);
    }

    public void RecarregarLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}