using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingLayerName = "Everything Else";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
