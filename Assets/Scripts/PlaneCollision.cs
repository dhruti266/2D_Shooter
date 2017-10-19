using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	[SerializeField]
	GameObject explosion;

	[SerializeField]
	GameObject bullet;

	public AudioSource _explosionSound;



	// Use this for initialization
	void Start () {
		_explosionSound = gameObject.GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("enemy")) {
			if (_explosionSound != null) {
				//Debug.Log ("audio detected\n");
				_explosionSound.Play ();
			}

			//Add Points
			Player.Instance.Score+=200;

			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;
			
			Destroy (gameObject);
			other.gameObject.GetComponent<PlaneController> ().Reset ();
		
		}

		if (other.gameObject.tag.Equals ("enemy2")) {
			if (_explosionSound != null) {
				_explosionSound.Play ();
			}
			Player.Instance.Score+=100;

			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;

			Destroy (gameObject);
			other.gameObject.GetComponent<PlaneController> ().Reset ();

		}
	}
		
}
