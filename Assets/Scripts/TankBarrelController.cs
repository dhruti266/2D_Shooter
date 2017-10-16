using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrelController : MonoBehaviour {

	private Transform _transform = null;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//move upwards
		if(Input.GetKey(KeyCode.W) && (int)(_transform.eulerAngles.z) < 50f){
			_transform.Rotate (0, 0, 47 * Time.deltaTime);
		}

		//move downwards
		if(Input.GetKey(KeyCode.S) && (_transform.eulerAngles.z > 1 && _transform.eulerAngles.z < 51f)){
			_transform.Rotate (0, 0,  -47 * Time.deltaTime);
		}
	}
		
}
