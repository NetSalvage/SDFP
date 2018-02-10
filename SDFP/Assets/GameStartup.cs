using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //need this for SceneManager
using UnityEngine;

public class GameStartup : MonoBehaviour {
    TestScript test;
	// Use this for initialization
	void Start () {
         test = gameObject.AddComponent(typeof(TestScript)) as TestScript;
        SceneManager.LoadScene("MenuMain", LoadSceneMode.Additive);
        Debug.Log("New scene loaded");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
