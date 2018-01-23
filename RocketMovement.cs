using UnityEngine;

public class RocketMovement : MonoBehaviour {

	private Rigidbody rb;
	private AudioSource audio;
	private float speed = 600;
	private float rotationSpeed = 100;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();

		rb.mass = 0.6f;
	}

	void FixedUpdate () {
		Movement ();
	}

	private void Movement(){
		if(Input.GetKey(KeyCode.Space)){
			rb.AddRelativeForce (Vector3.up * speed * Time.deltaTime);
			audio.Play ();
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate (Vector3.forward  * rotationSpeed * Time.deltaTime );
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate ( Vector3.back * rotationSpeed * Time.deltaTime);
		}
	}
}
