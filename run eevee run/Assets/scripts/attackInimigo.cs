using UnityEngine;
using System.Collections;

public class attackInimigo : MonoBehaviour {

    pontuacao p;

    // Use this for initialization
    void Start () {
        p = GetComponent<pontuacao>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "attack") {
            Destroy(gameObject);
            pontuacao.pontos += 100;
        }
    }
}
