using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {

	public GameObject target;

	void Start(){
		transform.position = Vector3.zero;
		transform.rotation = Quaternion.identity;
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag.Equals("CollisionObject")){
			SceneManager.LoadScene (0,LoadSceneMode.Single);
		} 
		if (SceneManager.GetActiveScene ().buildIndex == (SceneManager.sceneCountInBuildSettings - 1)) {
			if (collision.gameObject.tag.Equals ("Target")) {
				target.GetComponent<Renderer> ().material.color = Color.green;
			} else {
				target.GetComponent<Renderer> ().material.color = Color.red;
			}
		} else {
			if (collision.gameObject.tag.Equals ("Target")) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1, LoadSceneMode.Single);
			}
		}
	} 
}
