using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mudaSprite : MonoBehaviour {

    public Button som;
    public Sprite somOn;
    public Sprite somOff;
    public Button musica;
    public Sprite musicaOn;
    public Sprite musicaOff;
    public AudioSource begin;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("som") == 0) {
            som.image.overrideSprite = somOff;
        }
        else {
            som.image.overrideSprite = somOn;
        }
        if (PlayerPrefs.GetInt("musica") == 0) {
            begin.mute = true;
            musica.image.overrideSprite = musicaOff;
        }
        else  {
            begin.mute = false;
            musica.image.overrideSprite = musicaOn;
        }
    }
}
