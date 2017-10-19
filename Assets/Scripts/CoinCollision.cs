using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	public AudioSource _coinSound;

	// Use this for initialization
	void Start () {
		_coinSound = gameObject.GetComponent<AudioSource> ();
	}
	
	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag.Equals ("tank")) {
			Debug.Log ("Coin Collision detected\n");
			if (_coinSound != null) {
				//Debug.Log ("audio detected\n");
				_coinSound.Play ();
			}

			//Add Points
			Player.Instance.Score += 20;

			Destroy (gameObject);
			other.gameObject.GetComponent<CoinController> ().Reset ();

		}
	}
}
