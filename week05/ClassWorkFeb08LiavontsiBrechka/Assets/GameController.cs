using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {
	public int number = 42;
	private int number2 = 10;
	public Object thisMyGeneralObject = new Object ();

	public GameObject enemy;
	public GameObject level;

	// Use this for initialization
	void Start () {
		float PI = (float) System.Math.PI;
		for (int i = 0; i < number2; i++) {
//			Transform transform = level.transform;
//			Instantiate (enemy, transform);
			Vector3 position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-10, 10));
			Instantiate (enemy, position, 
				new Quaternion (
					Random.Range (-PI, PI), 
					Random.Range (-PI, PI), 
					Random.Range (-PI, PI), 
					Random.Range (-PI, PI)));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
