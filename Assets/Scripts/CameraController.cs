using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	private void LateUpdate()
	{
		// Replicates what would happen if the camera were a child of the player.
		// However, doesn't rotate like it would.
		transform.position = player.transform.position + offset;
	}
}
