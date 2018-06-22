using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class recordeGameOver : MonoBehaviour {

    Text texto;

	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = PlayerPrefs.GetInt("recorde").ToString();
    }
}
