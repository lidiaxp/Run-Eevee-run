using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botaoInicio : MonoBehaviour {
    
    int naoSom;
    int naoMusica;

	// Use this for initialization
	void Start () {
        naoMusica = PlayerPrefs.GetInt("musica");
        musica();
        musica();
        naoSom = PlayerPrefs.GetInt("som");
        som();
        som();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void play() {
        SceneManager.LoadScene("corrida");
    }

    public void musica() {
        if (naoMusica == 0) {
            naoMusica = 1;
            PlayerPrefs.SetInt("musica",naoMusica);
        }
        else {
            naoMusica = 0;
            PlayerPrefs.SetInt("musica", naoMusica);
        }
    }

    public void som() {
        if (naoSom == 0) {
            naoSom = 1;
            PlayerPrefs.SetInt("som", naoSom);
        }  else {
            naoSom = 0;
            PlayerPrefs.SetInt("som", naoSom);
        }
    }
}
