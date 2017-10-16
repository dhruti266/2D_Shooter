using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointController : MonoBehaviour {

	public float bulletForce = 10000f;
	public Transform _bullet;
//	public float collisionRadius = 0.5f;
//	public bool collision = false;
//	public LayerMask collideWith;

	void FixedUpdate (){
//		collision = Physics2D.OverlapCircle (_bullet.position, collisionRadius,	collideWith);

//		//destroys the bullet when collision occurs with ground
//		if (collision)
//			Destroy (gameObject);

		// destroy the bullet when it is not visible in camera view
		if (!GetComponent<Renderer> ().isVisible)
			Destroy (gameObject);
	}

	public void OnTriggerEnter2D(Collider2D target){

		if (target.gameObject.tag == "plane")
			GetComponent<Rigidbody2D> ().AddForce (transform.right * bulletForce);
	}

}
