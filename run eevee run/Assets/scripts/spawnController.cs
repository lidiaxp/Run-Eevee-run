using UnityEngine;
using System.Collections;

public class spawnController : MonoBehaviour {

    public GameObject arbok;
    public GameObject weezing;
    public GameObject platAarbok;
    public GameObject platWeezing;
    public GameObject platOrbEevee;
    public GameObject platOrbFlareon;
    public GameObject platOrbJolteon;
    public GameObject platOrbVaporeon;
    public GameObject OrbEevee;
    public GameObject OrbFlareon;
    public GameObject OrbJolteon;
    public GameObject OrbVaporeon;

    public float rateSpawn;
    public float currentTime;
    private int posicao;
    private int plataforma;
    private int plataforma2;
    private float y;

	// Use this for initialization
	void Start () {
        currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn) {
            currentTime = 0;
            posicao = Random.Range(1,120);
            plataforma = Random.Range(1, 160);
            plataforma2 = Random.Range(1, 160);



            if (posicao <= 40) {
                y = -0.5f;
                rateSpawn = 3.5f;
                if (plataforma <= 30) {
                    GameObject tempPrefab = Instantiate(arbok) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 30 && plataforma <= 60) {
                    GameObject tempPrefab = Instantiate(weezing) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 60 && plataforma <= 85) {
                    GameObject tempPrefab = Instantiate(OrbEevee) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, -0.64f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 85 && plataforma <= 110) {
                    GameObject tempPrefab = Instantiate(OrbFlareon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, -0.64f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 110 && plataforma <= 135) {
                    GameObject tempPrefab = Instantiate(OrbJolteon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, -0.64f, tempPrefab.transform.position.z);
                }
                else {
                    GameObject tempPrefab = Instantiate(OrbVaporeon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, -0.64f, tempPrefab.transform.position.z);
                }

            } else if (posicao > 40 && posicao <= 80) {
                y = 0.15f;
                rateSpawn = 3f;
                if (plataforma <= 40) {
                    GameObject tempPrefab = Instantiate(platWeezing) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 40 && plataforma <= 80) {
                    GameObject tempPrefab = Instantiate(platAarbok) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 80 && plataforma <= 100) {
                    GameObject tempPrefab = Instantiate(platOrbEevee) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 100 && plataforma <= 120) {
                    GameObject tempPrefab = Instantiate(platOrbFlareon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else if (plataforma > 120 && plataforma <= 140) {
                    GameObject tempPrefab = Instantiate(platOrbJolteon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
                else  {
                    GameObject tempPrefab = Instantiate(platOrbVaporeon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, y, tempPrefab.transform.position.z);
                }
            }
            else {
                y = 1.4f;
                rateSpawn = 4;
                if (plataforma <= 40) {
                    GameObject tempPrefab = Instantiate(platWeezing) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 40 && plataforma <= 80) {
                    GameObject tempPrefab = Instantiate(platAarbok) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 80 && plataforma <= 100)  {
                    GameObject tempPrefab = Instantiate(platOrbEevee) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 100 && plataforma <= 120) {
                    GameObject tempPrefab = Instantiate(platOrbFlareon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                else if (plataforma > 120 && plataforma <= 140) {
                    GameObject tempPrefab = Instantiate(platOrbJolteon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                else {
                    GameObject tempPrefab = Instantiate(platOrbVaporeon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x, 0.1f, tempPrefab.transform.position.z);
                }
                //----------------plataforma 2-----------------------------------
                if (plataforma2 <= 40) {
                    GameObject tempPrefab = Instantiate(platWeezing) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
                else if (plataforma2 > 40 && plataforma2 <= 80) {
                    GameObject tempPrefab = Instantiate(platAarbok) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
                else if (plataforma2 > 80 && plataforma2 <= 100)  {
                    GameObject tempPrefab = Instantiate(platOrbEevee) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
                else if (plataforma2 > 100 && plataforma2 <= 120) {
                    GameObject tempPrefab = Instantiate(platOrbFlareon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
                else if (plataforma2 > 120 && plataforma2 <= 140) {
                    GameObject tempPrefab = Instantiate(platOrbJolteon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
                else {
                    GameObject tempPrefab = Instantiate(platOrbVaporeon) as GameObject;
                    tempPrefab.transform.position = new Vector3(transform.position.x + 4, y, tempPrefab.transform.position.z);
                }
            }
        }
	}
}
