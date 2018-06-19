using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ugoku : MonoBehaviour {

	private Vector3 center;

	// Use this for initialization
	void Start () {
		this.center = transform.localPosition;
	}

	private double i = 0;

	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (center.x + (float)Math.Cos (i), center.y, center.z + (float)Math.Sin (i));
		i += 0.01;
	}
}
