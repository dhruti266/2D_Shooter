/*	
 * File : BulletController.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to instantiate bullet when "space" key is pressed 
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public GameObject bullet;
	public Transform _transform;

	// instantiate bullet prefab when space key is pressed
	void FixedUpdate(){

		if (Input.GetKeyDown("space"))
			Instantiate (bullet, _transform.position, _transform.rotation);
		
	}
}
