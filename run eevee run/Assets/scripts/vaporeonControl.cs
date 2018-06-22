using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class vaporeonControl : MonoBehaviour {
    public Rigidbody2D vaporeonRigidbody;
    public int forceJump;
    botaoRunner br;
    public AudioSource begin;
    public AudioClip pulo;
    public AudioClip aguaMusic;

    public Animator anime;
    public LayerMask oqechao;
    public Transform groundCheck;
    public Canvas pauseCanvas;
    public Transform colisor;

    public GameObject geevee;
    public GameObject gflareon;
    public GameObject gjolteon;
    public GameObject gvaporeon;

    public GameObject gota;

    bool ground;
    bool attack;
    bool ataqueEspecial;
    float tempo;
    float tempo2;

    // Use this for initialization
    void Start(){
        br = geevee.GetComponent<botaoRunner>();
        pauseCanvas.enabled = false;
        attack = false;
    }

    // Update is called once per frame
    void Update() {
        br.eevee(); 
        br.flareon(); 
        br.jolteon(); 
        br.vaporeon(); 
        //para transformação

        if (transform.rotation.z > 0.08 || transform.rotation.z < -0.05){
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

        if (transform.position.x <= -4) {
            SceneManager.LoadScene("gameOver");
        }
        //-----------------to jump---------------------------------------------
        ground = Physics2D.OverlapCircle(groundCheck.position, 0.2f, oqechao);

        anime.SetBool("jump", !ground);
        //-----------------to attack-------------------------------------------
        anime.SetBool("attack", attack);
        if (botaoRunner.sVaporeon)  {
            if (attack)  {
                tempo += Time.deltaTime;
            }
            if (tempo > 0) {
                tempo += Time.deltaTime;
            }
            if (tempo > 0.5f) {
                colisor.position = new Vector3(-10, -6, colisor.position.z);
                tempo = 0;
            }
        }
        attack = false;
        //---------------to special attack--------------------------------------
        anime.SetBool("ataqueEspecial", ataqueEspecial);  

        if (botaoRunner.sVaporeon) {
            if (ataqueEspecial) {
                tempo += Time.deltaTime;
                for (int x = 0; x < 10; x++)  {
                    GameObject tempPrefab = Instantiate(gota) as GameObject;
                    tempPrefab.transform.position = new Vector3(Random.Range(-4.73f, 4.55f), Random.Range(3, 3.5f), tempPrefab.transform.position.z);
                }
            }
            if (tempo2 > 0) {
                tempo2 += Time.deltaTime;
            }
            if (tempo2 > 0.5f) {
                colisor.position = new Vector3(-10, -6, colisor.position.z); 
            }
        }
        ataqueEspecial = false;
    }

    public void pular(){
        if (ground){
            vaporeonRigidbody.AddForce(new Vector2(0, forceJump));
            if (PlayerPrefs.GetInt("som") == 1) {
                begin.clip = pulo;
                begin.Play();
            }
        }
    }

    public void atacar(){
        if (botaoRunner.sVaporeon){
            if (orbVaporeon.orbs >= 1 && orbVaporeon.orbs != 5){
                attack = true;
                orbVaporeon.orbs -= 1;
                colisor.position = new Vector3(2, gvaporeon.transform.position.y, colisor.position.z);
                if (PlayerPrefs.GetInt("som") == 1) {
                    begin.clip = aguaMusic;
                    begin.Play();
                }
            }
        }
    }

    public void specialAttack() {
        if (botaoRunner.sVaporeon) {
            if (orbVaporeon.orbs >= 5) {
                ataqueEspecial = true;
                orbVaporeon.orbs -= 5;
                colisor.position = new Vector3(2, gvaporeon.transform.position.y, colisor.position.z);
                if (PlayerPrefs.GetInt("som") == 1) {
                    begin.clip = aguaMusic;
                    begin.Play();
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy") {
            pontuacao.die();
            Destroy(gameObject);
        }
    }
}
