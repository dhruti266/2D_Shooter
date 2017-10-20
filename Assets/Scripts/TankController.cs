/*	
 * File : TankCollision.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified : October 21, 2017
 * Program Description : This script is used to get control over the tank and move it either left or right
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

	[SerializeField]
	private float speed = 8f;
	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;

	private Transform _tankTransform = null;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_tankTransform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _tankTransform.position;

		//move left
		if(Input.GetKey(KeyCode.A)){
			_currentPos -= new Vector2(speed,0);
		}

		//move right
		if(Input.GetKey(KeyCode.D)){
			_currentPos += new Vector2(speed,0);
		}

		//check the bounds
		CheckBoundry ();

		_tankTransform.position = _currentPos;
	}

	// chek the bounds to move the tank
	private void CheckBoundry(){
		if (_currentPos.x < leftX) {
			_currentPos.x = leftX;
		}

		if (_currentPos.x > rightX) {
			_currentPos.x = rightX;
		}
	}
}
