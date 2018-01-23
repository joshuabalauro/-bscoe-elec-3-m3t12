using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Abs(Mathf.Sin (Time.time * 0.5f) * 30 ) + 5,transform.position.y,transform.position.z);
	}
}
