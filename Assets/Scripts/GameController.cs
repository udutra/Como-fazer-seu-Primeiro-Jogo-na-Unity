using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    
    private Vector3 posicaoInicial;
    public GameObject painelGameOver;
    public Text txtPontuacao;
    public PlayerController player;
    public float divisorPontuacao;
    
    private void Start() {
        posicaoInicial = player.transform.position;
    }

    private void Update() {
        Vector3 distanciaPercorrida = player.transform.position - posicaoInicial;
        float pontuacao = distanciaPercorrida.z / divisorPontuacao;
        txtPontuacao.text = pontuacao.ToString("0");
    }

    public void GameOver() {
        painelGameOver.SetActive(true);
    }

    public void RecarregarLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}