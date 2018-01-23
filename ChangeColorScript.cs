using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour {

	public Transform player;
	private Renderer renderer;
	public float distance;

	void Start(){
		renderer = GetComponent<Renderer> ();
	}

	void Update(){
		ChangeColor ();
	}

	void ChangeColor(){
		
		distance = Vector3.Distance (player.position, transform.position);

		if (distance <= 10) {
			renderer.material.color = Color.blue;
		}
	}
}
