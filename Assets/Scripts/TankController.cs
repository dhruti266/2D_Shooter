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

	private Transform _transform = null;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;

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

		//apply changes
		_transform.position = _currentPos;
	}

	private void CheckBoundry(){
		if (_currentPos.x < leftX) {
			_currentPos.x = leftX;
		}

		if (_currentPos.x > rightX) {
			_currentPos.x = rightX;
		}
	}
}
