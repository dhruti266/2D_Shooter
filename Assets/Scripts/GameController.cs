using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button resetBtn;
	[SerializeField]
	GameObject plane;
	[SerializeField]
	GameObject plane2;


	private void initialize(){

		Player.Instance.Score = 0;
		Player.Instance.Life = 3;

		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);

		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
		StartCoroutine ("AddEnemy");
	}

	public void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
	}
	
	public void updateUI(){
		scoreLabel.text = "Score :" + Player.Instance.Score;
		lifeLabel.text = "Life : " + Player.Instance.Life;
	}

	// Use this for initialization
	void Start () {
		Player.Instance.gameCtrl = this;
		initialize ();
	}

	public void ResetBtnClick(){

		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);

	}

	private IEnumerator AddEnemy(){
		int time = Random.Range (20,40);

		yield return new WaitForSeconds ((float)time);
		Instantiate (plane);
		Instantiate (plane2);
		StartCoroutine ("AddEnemy");
	}
}
