using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pontuacao : MonoBehaviour {

    int divisor;
    public static int pontos;
    float p2;
    Text texto;
	// Use this for initialization
	void Start () {
        orbEevee.orbs = 0;
        orbFlareon.orbs = 0;
        orbJolteon.orbs = 0;
        orbVaporeon.orbs = 0;
        texto = GetComponent<Text>();
        pontos = 0;
        p2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (botaoRunner.play) {
            p2 += 0.1f;
            if (p2 >= 1) {
                p2 = 0;
                pontos += 1;
            }
        }
        texto.text = "Score: " + pontos.ToString();
	}

    public static void die() {
        PlayerPrefs.SetInt("pontuacao", pontos);
        if (pontos > PlayerPrefs.GetInt("recorde")) {
            PlayerPrefs.SetInt("recorde", pontos);
        }
        SceneManager.LoadScene("gameOver");
    }
}
