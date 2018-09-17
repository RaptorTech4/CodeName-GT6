using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public GameObject player;
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 cameraposition = new Vector3(player.transform.position.x,gameObject.transform.position.y,-10.0f);
		transform.position = cameraposition;
	}
}
