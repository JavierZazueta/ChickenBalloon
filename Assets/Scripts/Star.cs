using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("are you there?");
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("hello?");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
