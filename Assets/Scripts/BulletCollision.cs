/*	
 * File : BulletCollision.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified : October 21, 2017
 * Program Description : This script is used to detect the collison of bullet with enemies (i.e Planes) and create explosion.
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;
	[SerializeField]
	GameObject explosion;

	private AudioSource _explosionSound;

	// Use this for initialization
	void Start () {
		_explosionSound = gameObject.GetComponent<AudioSource> ();
		_explosionSound.Play ();
	}

	// detect the collison with planes
	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("enemy")) {
			if (_explosionSound != null) {
				_explosionSound.Play ();
			}

			//Add Points
			Player.Instance.Score+=200;

			// create explosion
			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;

			// destroys the planes and reset its positions
			Destroy (gameObject);
			other.gameObject.GetComponent<PlaneController> ().Reset ();

		}

		if (other.gameObject.tag.Equals ("enemy2")) {
			if (_explosionSound != null) {
				_explosionSound.Play ();
			}

			// Add points
			Player.Instance.Score+=100;

			// create explosion
			Instantiate (explosion)
				.GetComponent<Transform> ()
				.position = other.gameObject
					.GetComponent<Transform> ()
					.position;

			// destroys the planes and reset its positions
			Destroy (gameObject);
			other.gameObject.GetComponent<PlaneController> ().Reset ();

		}
	}

}
