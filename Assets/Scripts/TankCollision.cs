using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

	[SerializeField]
	GameObject explosion;

	private AudioSource _tankSound;

	// Use this for initialization
	void Start () {
		_tankSound = gameObject.GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("enemy")) {
			Debug.Log ("Collision detected\n");
			if (_tankSound != null) {
				_tankSound.Play ();
			}
			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;

			//other.gameObject.GetComponent<PlaneController> ().Reset ();
				
		}

	}
}
	
