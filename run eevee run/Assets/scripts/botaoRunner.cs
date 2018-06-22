using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class botaoRunner : MonoBehaviour {
    
    public Rigidbody2D eeveeRigidbody;
    public Rigidbody2D FlareonRigidbody;
    public int forceJump;
    public static bool play;
    public Transform colisor;
    public AudioSource begin;
    public AudioClip pulo;
    public AudioClip eeveeMusic;

    public Animator anime;
    public Animator animef;
    public LayerMask oqechao;
    public Transform groundCheck;
    public Canvas pauseCanvas;
    public Image story;
    public Canvas storyCanvas;

    public GameObject geevee;
    public GameObject gflareon;
    public GameObject gjolteon;
    public GameObject gvaporeon;

    public static bool sEevee;
    public static bool sFlareon;
    public static bool sJolteon;
    public static bool sVaporeon;

    bool ground;
    bool attack;
    float tempo;
    Vector3 characterPosition;
    int x;
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
        pauseCanvas.enabled = false;
        attack = false;
        //story.enabled = true;
        //Time.timeScale = 0;
        play = true;
        storyCanvas.enabled = true;
        sEevee = true;
    }

    // Update is called once per frame
    void Update() {
        eevee(); 
        flareon(); 
        jolteon(); 
        vaporeon(); 
        //para transformação
        
        /*if (x <= 222) {   //nao fa;o ideia de quanto tempo isso eh
            x++;
        }*/
        if (/*x > 222 && */!storyCanvas.enabled) {      //tira a historinha e comeca o jogo
            story.enabled = false;
            play = true;
            storyCanvas.enabled = false;
            Time.timeScale = 1;
        }

        if (transform.rotation.z > 0.08 || transform.rotation.z < -0.05) {    //pro bichinho nao sair girando por ai
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

        if (transform.position.x <= -4.5f) {     //se ele sair da tela morre logo
            pontuacao.die();
        }
        //-----------------to jump---------------------------------------------
        ground = Physics2D.OverlapCircle(groundCheck.position, 0.2f, oqechao);

        anime.SetBool("jump", !ground);
        //-----------------to attack-------------------------------------------
        anime.SetBool("attack", attack);
        if (sEevee) {
            if (attack){
                tempo += Time.deltaTime;
            }
            if (tempo > 0){
                tempo += Time.deltaTime;
            }
            if (tempo > 0.5f) {
                colisor.position = new Vector3(-10, -6, colisor.position.z);
                tempo = 0;
            }
        }
        attack = false;
    }

    public void pular() {
        if (Time.timeSinceLevelLoad > 0.7f) {
            if (ground)
            {
                eeveeRigidbody.AddForce(new Vector2(0, forceJump));
                if (PlayerPrefs.GetInt("som") == 1)
                {
                    begin.clip = pulo;
                    begin.Play();
                }
            }
        }
    }

    public void atacar() {
        if (sEevee) {
            if (orbEevee.orbs >= 1){
                attack = true;
                orbEevee.orbs -= 1;
                colisor.position = new Vector3(2, geevee.transform.position.y, colisor.position.z);
                if (PlayerPrefs.GetInt("som") == 1) {
                    begin.clip = eeveeMusic;
                    begin.Play();
                }
            }
        }    
    }

    public void pause()  {
        if (pauseCanvas.enabled && !play){
            pauseCanvas.enabled = false;
            play = true;
            Time.timeScale = 1;
        }
        else {
            pauseCanvas.enabled = true;
            play = false;
            Time.timeScale = 0;
        }
    }

    public void eevee() {
        if (!sEevee && orbEevee.orbs == 3){
            if (sEevee) {
                characterPosition = geevee.transform.position;
                geevee.SetActive(false);
                geevee.SetActive(true);
                geevee.transform.position = characterPosition;
            } else if (sFlareon) {
                characterPosition = gflareon.transform.position;
                gflareon.SetActive(false);
                geevee.SetActive(true);
                geevee.transform.position = characterPosition;
            } else if(sJolteon){
                characterPosition = gjolteon.transform.position;
                gjolteon.SetActive(false);
                geevee.SetActive(true);
                geevee.transform.position = characterPosition;
            } else if (sVaporeon) {
                characterPosition = gvaporeon.transform.position;
                gvaporeon.SetActive(false);
                geevee.SetActive(true);
                geevee.transform.position = characterPosition;
            }
                sEevee = true;
                sFlareon = false;
                sJolteon = false;
                sVaporeon = false;
            orbEevee.orbs = 0;
       }
    }

    public void flareon() {
        if (!sFlareon && orbFlareon.orbs == 3) { 
            if (sEevee){
                characterPosition = geevee.transform.position;
                geevee.SetActive(false);
                gflareon.SetActive(true);
                gflareon.transform.position = characterPosition;
            }
            else if (sFlareon){
                characterPosition = gflareon.transform.position;
                gflareon.SetActive(false);
                gflareon.SetActive(true);
                gflareon.transform.position = characterPosition;
            }
            else if (sJolteon){
                characterPosition = gjolteon.transform.position;
                gjolteon.SetActive(false);
                gflareon.SetActive(true);
                gflareon.transform.position = characterPosition;
            }
            else if(sVaporeon){
                characterPosition = gvaporeon.transform.position;
                gvaporeon.SetActive(false);
                gflareon.SetActive(true);
                gflareon.transform.position = characterPosition;
            }
            sEevee = false;
            sFlareon = true;
            sJolteon = false;
            sVaporeon = false;
            orbFlareon.orbs = 0;
       }
    }

    public void jolteon() {
        if (!sJolteon && orbJolteon.orbs == 3) { 
            if (sEevee){
                characterPosition = geevee.transform.position;
                geevee.SetActive(false);
                gjolteon.SetActive(true);
                gjolteon.transform.position = characterPosition;
            }
            else if (sFlareon){
                characterPosition = gflareon.transform.position;
                gflareon.SetActive(false);
                gjolteon.SetActive(true);
                gjolteon.transform.position = characterPosition;
            }
            else if (sJolteon){
                characterPosition = gjolteon.transform.position;
                gjolteon.SetActive(false);
                gjolteon.SetActive(true);
                gjolteon.transform.position = characterPosition;
            }
            else if (sVaporeon) {
                characterPosition = gvaporeon.transform.position;
                gvaporeon.SetActive(false);
                gjolteon.SetActive(true);
                gjolteon.transform.position = characterPosition;
            }
            sEevee = false;
            sFlareon = false;
            sJolteon = true;
            sVaporeon = false;
            orbJolteon.orbs = 0;
        }
    }

    public void vaporeon() {
        if (!sVaporeon && orbVaporeon.orbs == 3) {
            if (sEevee) {
                characterPosition = geevee.transform.position;
                geevee.SetActive(false);
                gvaporeon.SetActive(true);
                gvaporeon.transform.position = characterPosition;
            }
            else if (sFlareon) {
                characterPosition = gflareon.transform.position;
                gflareon.SetActive(false);
                gvaporeon.SetActive(true);
                gvaporeon.transform.position = characterPosition;
            }
            else if (sJolteon)  {
                characterPosition = gjolteon.transform.position;
                gjolteon.SetActive(false);
                gvaporeon.SetActive(true);
                gvaporeon.transform.position = characterPosition;
            }
            else if (sVaporeon) {
                characterPosition = gvaporeon.transform.position;
                gvaporeon.SetActive(false);
                gvaporeon.SetActive(true);
                gvaporeon.transform.position = characterPosition;
            }
            sEevee = false;
            sFlareon = false;
            sJolteon = false;
            sVaporeon = true;
            orbVaporeon.orbs = 0;
        }
    }

    public void som() {
        if (naoSom == 0) {                        //estiver com som
            naoSom = 1;                           //fica sem som
            PlayerPrefs.SetInt("som", naoSom);    //passa 1
        }
        else {                                    //estiver sem som
            naoSom = 0;                           //fica com som
            PlayerPrefs.SetInt("som", naoSom);    //passa 0
        }
    }

    public void musica() {
        if (naoMusica == 0)  {
            naoMusica = 1;
            PlayerPrefs.SetInt("musica", naoMusica);
        }
        else {
            naoMusica = 0;
            PlayerPrefs.SetInt("musica", naoMusica);
        }
    }

    public void resume() {
        play = true;
        pauseCanvas.enabled = false;
        Time.timeScale = 1;
    }

    public void restart() {
        Time.timeScale = 1;
        play = true;
        SceneManager.LoadScene("corrida");
    }

    public void exit() {
        Time.timeScale = 1;
        play = true;
        SceneManager.LoadScene("inicio");
    }

    public void skipStory() {
        play = true;
        storyCanvas.enabled = false;
        story.enabled = false;
        Time.timeScale = 1;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy"){
            pontuacao.die();
            Destroy(gameObject);
        }
    }
}
