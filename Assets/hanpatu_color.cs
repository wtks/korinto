using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanpatu_color : MonoBehaviour {

	Renderer Renderer;

	public Material AtatteruMaterial;
	public Material AtattenaiMaterial;

	public GameObject kesu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake() {
		Renderer = GetComponent<Renderer>();
	}

	void OnCollisionEnter(Collision collision) {
		kesu.SendMessage ("Toggle");
		Renderer.material = AtatteruMaterial;
	}

	void OnCollisionExit(Collision collisionInfo) {
		Renderer.material = AtattenaiMaterial;
	}

}
