using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

	public GameObject GameObjectToCreate = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			Vector3 position = gameObject.transform.position + transform.up * 1.0f;
			GameObject newBall = Instantiate (GameObjectToCreate, position, Quaternion.identity);

			Rigidbody rigidBody = newBall.GetComponent<Rigidbody> ();
			rigidBody.AddForce (transform.up * 2000.0f);
		}
	}
}
