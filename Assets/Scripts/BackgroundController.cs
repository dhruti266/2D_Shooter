/*	
 * File : BackgroundController.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to rotate background from right to left
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	[SerializeField]
	private float speed = 5f; 
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;	

	private Transform _backgroundTransform = null;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_backgroundTransform = gameObject.GetComponent<Transform>();
		_currentPos = _backgroundTransform.position;
		Reset ();
	}
	
	// updates the position of an object
	void Update () {
		_currentPos = _backgroundTransform.position;

		_currentPos -= new Vector2 (speed, 0); 
		_backgroundTransform.position = _currentPos;

		if(_currentPos.x < endX){
			Reset ();
		}
	}

	// reset the background object to rotate right to left from the start position
	private	void Reset(){
		_backgroundTransform.position = new Vector2(startX, 0);
	}

	
}
