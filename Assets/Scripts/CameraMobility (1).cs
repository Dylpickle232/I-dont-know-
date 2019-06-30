using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMobility : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// LateUpdate is called once per frame after update
	void LateUpdate () {
        transform.position = new Vector3(player.transform.position.x + 3, transform.position.y, transform.position.z);
	}
}
