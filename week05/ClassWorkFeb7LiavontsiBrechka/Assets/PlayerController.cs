using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		string[] axises = new string[] { "Horizontal", "Vertical", "Jump", "Mouse X", "Mouse Y"};
		float[] values = new float[axises.Length];
		for (int i = 0; i < axises.Length; i++)
			values [i] = Input.GetAxis (axises [i]);	

		if (values[0] != 0.0F || values[1] != 0.0F)
			this.transform.position += new Vector3(values[0], values[1], 0);
	}
}
