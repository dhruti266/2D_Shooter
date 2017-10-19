using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public GameObject bullet;
	public Transform _transform;

	void FixedUpdate(){

		//bool fire = Input.GetButtonDown ("Fire1");// when mouse left button is pressed

		if (Input.GetKeyDown("space"))
			Instantiate (bullet, _transform.position, _transform.rotation);
		
	}
}
