/*	
 * File : TankCollision.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to detect the collision of tank with the enemies (i.e Planes) 
 * 						 as well as collision with coins to collect the points
 * Revision History : v1.0
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	[SerializeField]
	GameObject tankBarrel;
	[SerializeField]
	GameObject coin;
	private AudioSource _tankSound;
	private AudioSource _coinSound;


	// Use this for initialization
	void Start () {
		_tankSound = gameObject.GetComponent<AudioSource> ();
		_coinSound = gameObject.GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D (Collider2D other)
	{	
		if (other.gameObject.tag.Equals ("enemy") || other.gameObject.tag.Equals ("enemy2")) {
			_tankSound.Play ();

			//decrease life
			Player.Instance.Life -= 1;
			other.gameObject.GetComponent<PlaneController> ().Reset ();
			StartCoroutine ("Blink");
		}

		if (other.gameObject.tag.Equals ("coin")) {
			Debug.Log ("Coin Collision detected\n");
			if (_coinSound != null) {
				//Debug.Log ("audio detected\n");
				_coinSound.Play ();
			}

			//Add Points
			Player.Instance.Score += 20;
			other.gameObject.GetComponent<CoinController> ().Reset ();

		}
	}

	// when collision occurs tank and tank barrel blink
	private IEnumerator Blink(){
		Color t, b;
		Renderer tankRenderer = gameObject.GetComponent<Renderer> ();
		Renderer barrelRenderer = tankBarrel.GetComponent<Renderer> ();
		for (int i = 0; i < 3; i++) {
			for (float f = 1f; f >= 0; f -= 0.1f) {
				t = tankRenderer.material.color;
				b = barrelRenderer.material.color;
				t.a = f;
				b.a = f;
				tankRenderer.material.color = t;
				barrelRenderer.material.color = b;
				yield return new WaitForSeconds(0.1f);
			}

			for (float f = 0f; f <= 1; f += 0.1f) {
				t = tankRenderer.material.color;
				b = barrelRenderer.material.color;
				t.a = f;
				b.a = f;
				tankRenderer.material.color = t;
				barrelRenderer.material.color = b;
				yield return new WaitForSeconds (0.1f);
			}
		}
	}
}
	
