using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botaoGameOver : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void menu() {
        SceneManager.LoadScene("inicio");
    }

    public void again() {
        SceneManager.LoadScene("corrida");
    }
}
