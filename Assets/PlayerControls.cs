using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	private int attack1 = Animator.StringToHash("Attacking");

	Animator a;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		a = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
