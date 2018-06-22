using UnityEngine;

public class chuvaAtaques : MonoBehaviour {

    private float y;
    public float speed;

    void Start () {
	
	}
	
	void Update () {
        y = transform.position.y;
        y += speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x, y);

        if (y <= -0.96) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ground") {
            Destroy(gameObject);
        }
    }
}
