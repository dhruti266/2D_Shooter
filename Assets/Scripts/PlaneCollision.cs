using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour {

	[SerializeField]
	GameObject explosion;

	[SerializeField]
	Transform bullet;


	private AudioSource _explosionSound;

	// Use this for initialization
	void Start () {
		_explosionSound = gameObject.GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("enemy")) {
			Debug.Log ("Collision detected\n");
			if (_explosionSound != null) {
				_explosionSound.Play ();
			}

			Instantiate (explosion, bullet.position, transform.rotation = Quaternion.identity);
			Destroy (gameObject);

			other.gameObject.GetComponent<PlaneController> ().Reset ();
		
		}

	}
		
}
