using UnityEngine;
using UnityEngine.UI;

public class textVaporeon : MonoBehaviour {

    Text texto;

    // Use this for initialization
    void Start()
    {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = orbVaporeon.orbs.ToString() + "/5";
    }
}
