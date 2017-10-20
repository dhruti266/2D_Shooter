/*	
 * File : CoinController.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to drop coins randomly.
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	[SerializeField]
	float minYspeed = 3f;
	[SerializeField]
	float maxYspeed = 5f;
	[SerializeField]
	float minXSpeed = -2f;
	[SerializeField]
	float maxXSpeed = 2f;

	private Transform _coinTransform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_coinTransform = gameObject.GetComponent<Transform> ();
		_currentPosition = _coinTransform.position;
		Reset ();
	}

	// updates the position of an object
	void Update () {
		_currentPosition = _coinTransform.position;
		_currentPosition -= _currentSpeed;
		_coinTransform.position = _currentPosition;

		if (_currentPosition.y <= -550) {
			Reset ();
		}
	}

	// adds coins randomly with allocated speed and moves from top to bottom
	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYspeed, maxYspeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float x = Random.Range (-100, 100); 
		_coinTransform.position = 
			new Vector2 (x, 600 + Random.Range (0, 100));

		float y = Random.Range (200, 500);
		_coinTransform.position = new Vector2 (0, y);
	}
}
