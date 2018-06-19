using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			iTween.ShakePosition(this.gameObject, iTween.Hash("z",0.3f,"time",0.3f));
		}
	}
}
