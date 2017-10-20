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

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -550) {
			Reset ();
		}
	}

	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYspeed, maxYspeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float x = Random.Range (-100, 100); 
		_transform.position = 
			new Vector2 (x, 600 + Random.Range (0, 100));

		float y = Random.Range (200, 500);
		_transform.position = new Vector2 (0, y);
	}
}
