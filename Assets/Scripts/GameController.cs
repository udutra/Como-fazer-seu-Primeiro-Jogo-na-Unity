using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


    public void GameOver() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}