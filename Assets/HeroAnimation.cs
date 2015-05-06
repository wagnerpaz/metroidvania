using UnityEngine;
using System.Collections;
using System;

public class HeroAnimation : MonoBehaviour {
	int WALKING_ID = Animator.StringToHash("Walking");
	int V_SPEED_ID = Animator.StringToHash("VSpeed");
	public float V_THRESHOLD = 1f;
	public float H_THRESHOLD = 1;

	Animator anim;
	Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetInteger(V_SPEED_ID, 0);
		anim.SetBool (WALKING_ID, false);

		if (Math.Abs(rb.velocity.y) > V_THRESHOLD) {
			anim.SetInteger(V_SPEED_ID, (int) Math.Ceiling(rb.velocity.y));
		}
		if (Math.Abs(rb.velocity.x) > H_THRESHOLD) {
			anim.SetBool(WALKING_ID, true);
		}
	}

	void OnCollisionEnter(Collision c)
	{
		if (c.collider.gameObject.layer == LayerMask.NameToLayer ("Stage")) {
			Debug.Log("teste");
		}
	}
}
