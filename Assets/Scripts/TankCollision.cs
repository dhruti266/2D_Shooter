using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

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
			//decrease life
			Player.Instance.Life -= 1;
			other.gameObject.GetComponent<PlaneController> ().Reset ();
			StartCoroutine ("Blink");
		}
		else if (other.gameObject.tag.Equals ("enemy2")) {
			Debug.Log ("Collision detected\n");
			if (_tankSound != null) {
				_tankSound.Play ();
			}
			//decrease life
			Player.Instance.Life -= 1;
			other.gameObject.GetComponent<PlaneController> ().Reset ();
			StartCoroutine ("Blink");
		}
	}

	private IEnumerator Blink(){
		Color c;
		Renderer renderer = gameObject.GetComponent<Renderer> ();
		for (int i = 0; i < 3; i++) {
			for (float f = 1f; f >= 0; f -= 0.1f) {
				c = renderer.material.color;
				c.a = f;
				renderer.material.color = c;
				yield return new WaitForSeconds(0.1f);
			}

			for (float f = 0f; f <= 1; f += 0.1f) {
				c = renderer.material.color;
				c.a = f;
				renderer.material.color = c;
				yield return new WaitForSeconds (0.1f);
			}
		}
	}
}
	
