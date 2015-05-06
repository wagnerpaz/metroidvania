using UnityEngine;
using System.Collections;

public class Playable : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * moveSpeed;

	}
}
