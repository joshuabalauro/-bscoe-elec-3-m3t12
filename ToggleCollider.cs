using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider : MonoBehaviour {

	private Collider col;

	// Use this for initialization
	void Start () {
		col = GetComponent<Collider> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.O)) {
			col.enabled = !col.enabled;
		}
	}
}
