using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointController : MonoBehaviour {

	public float bulletForce = 10000f;

	public void OnTriggerEnter2D(Collider2D target){

		if (target.gameObject.tag == "plane")
			GetComponent<Rigidbody2D> ().AddForce (transform.right * bulletForce);
	}

}
