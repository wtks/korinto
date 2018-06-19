using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kieru : MonoBehaviour {

	public Material kieteru;
	public Material kietenai;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Toggle() {
		var collider = gameObject.GetComponent<CapsuleCollider> ();
		collider.enabled = !collider.enabled;
		if (collider.enabled) {
			gameObject.GetComponent<MeshRenderer> ().material = kietenai;
		} else {
			gameObject.GetComponent<MeshRenderer> ().material = kieteru;
		}
	}
}
