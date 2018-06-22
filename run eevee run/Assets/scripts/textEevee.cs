using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textEevee : MonoBehaviour {

    Text texto;

	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        texto.text = orbEevee.orbs.ToString() + "/3";
    }
}
