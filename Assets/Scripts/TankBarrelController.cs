/*	
 * File : Player.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to get control over Tank barrel to move it on specified angle (i.e from 0 degree to 50) 
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrelController : MonoBehaviour {

	private Transform _barrelTransform = null;

	// Use this for initialization
	void Start () {
		_barrelTransform = gameObject.GetComponent<Transform> ();
	}
	
	// to move barrel upwards 50 degree angle and downwards till 0 degree
	void FixedUpdate () {

		//move upwards when "W" is pressed
		if(Input.GetKey(KeyCode.W) && (int)(_barrelTransform.eulerAngles.z) < 50f){
			_barrelTransform.Rotate (0, 0, 47 * Time.deltaTime);
		}

		//move downwards when "S" is pressed
		if(Input.GetKey(KeyCode.S) && (_barrelTransform.eulerAngles.z > 1 && _barrelTransform.eulerAngles.z < 51f)){
			_barrelTransform.Rotate (0, 0,  -47 * Time.deltaTime);
		}
	}
		
}
