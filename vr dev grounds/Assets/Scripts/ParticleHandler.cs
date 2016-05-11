//GameState.cs

using UnityEngine;
using System;


public class ParticleHandler : MonoBehaviour 
{
	public GameObject particlePrefab;
	void Start () {
		particlePrefab = GetComponent<GameObject>();
    }

    void OnTriggerEnter (Collision col) {
	    if (col.gameObject.tag == "Player") {
	    	Instantiate(particlePrefab);
	    }
	}

 
}
