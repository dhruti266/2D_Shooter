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

	private Transform _transform = null;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPos = _transform.position;
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;

		// changing the X value according to given speed and move the object from right to left
		_currentPos -= new Vector2 (speed, 0); 
		_transform.position = _currentPos;

		if(_currentPos.x < endX){
			Reset ();
		}
	}
	
	private	void Reset(){
		_transform.position = new Vector2(startX, 0);
	}

	
}
