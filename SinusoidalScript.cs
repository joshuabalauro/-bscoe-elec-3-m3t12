using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,Mathf.Abs(Mathf.Sin (Time.time) * 20 ) + 5,transform.position.z);
	}
}
