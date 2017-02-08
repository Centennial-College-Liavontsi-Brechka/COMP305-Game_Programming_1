using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Hello world!");
		print (this.transform.position);
		print (this.transform.rotation);
		print (this.transform.localScale);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			print ("key A is pressed: " + Input.GetKeyDown (KeyCode.A));
			string[] axises = new string[] { "Horizontal", "Vertical", "Jump", "Mouse X", "Mouse Y"};
			float[] values = new float[axises.Length];
			for (int i = 0; i < axises.Length; i++) {
				values [i] = Input.GetAxis (axises [i]);
				if (values[i] != 0.0F) {
					print (axises [i] + " " + values [i]);
				}
			}
		}
	}
}
