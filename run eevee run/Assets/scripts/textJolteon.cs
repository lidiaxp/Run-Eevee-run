using UnityEngine;
using UnityEngine.UI;

public class textJolteon : MonoBehaviour {

    Text texto;

    // Use this for initialization
    void Start()
    {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = orbJolteon.orbs.ToString() + "/5";
    }
}
