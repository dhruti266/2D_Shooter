using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

	[SerializeField]
	float minXspeed = 5f;
	[SerializeField]
	float maxXspeed = 10f;
	[SerializeField]
	float minYspeed = -2f;
	[SerializeField]
	float maxYspeed = 2f;

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -1000) {
			Reset ();
		}
	}

	public void Reset(){

		float xSpeed = Random.Range (minXspeed, maxXspeed);
		float ySpeed = Random.Range (minYspeed, maxYspeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float y = Random.Range (200, 600);
		_transform.position = new Vector2 (1000 + Random.Range (0, 100), y);
	}
}
