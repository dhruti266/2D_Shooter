/*	
 * File : FirePointController.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to fire bullet from the tank barrel with allocated force 
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointController : MonoBehaviour {

	public float bulletForce = 10000f;

	void FixedUpdate (){

		// destroy the bullet prefab when it is not visible in camera view
		if (!GetComponent<Renderer> ().isVisible)
			Destroy (gameObject);
	}

	public void OnTriggerEnter2D(Collider2D target){

		// fire bullet with allocated force
		if (target.gameObject.tag == "tank")
			GetComponent<Rigidbody2D> ().AddForce (transform.right * bulletForce);
	}

}
