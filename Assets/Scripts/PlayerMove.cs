using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

    private float MOVE_SPEED = 3;
    private float ROTATION_SPEED = 100;
    //public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -ROTATION_SPEED));
            //rb.rotation += Time.deltaTime * -ROTATION_SPEED;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,0, Time.deltaTime * ROTATION_SPEED));
            //rb.rotation += Time.deltaTime * ROTATION_SPEED;
        }
        transform.position += transform.up * MOVE_SPEED * Time.deltaTime;
        //rb.velocity = rb.transform.up * MOVE_SPEED;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Could check if col == "enemy"; then Destroy(this.gameObject);
        Destroy(this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
