using UnityEngine;
using UnityEngine.UI;

public class textFlareon : MonoBehaviour {

    Text texto;

    // Use this for initialization
    void Start()
    {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = orbFlareon.orbs.ToString() + "/5";
    }
}
