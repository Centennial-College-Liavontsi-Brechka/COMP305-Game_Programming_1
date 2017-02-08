using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject[] enemies;
	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy1");
		print ("Enemies count: " + enemies.Length);
		for (int i = 0; i < enemies.Length; i++) {
			print ("Enemy name: " + enemies [i].name);
		}
		GameObject.DestroyObject (enemies [0].gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
