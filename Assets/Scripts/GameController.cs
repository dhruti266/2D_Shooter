/*	
 * File : GameController.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to get control on Canvas elements.
 * Revision History : v1.0
 */

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


	// disables the text labels such as gameOver, highscore and restart button 
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

	// method will be called when life is zero and displays high score
	public void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.text =  "High Score :" + Player.Instance.Score;
		highScoreLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
	}

	// method will update the score and life status
	public void updateUI(){
		scoreLabel.text = "Score :" + Player.Instance.Score;
		lifeLabel.text = "Life :" + Player.Instance.Life;
	}

	// Use this for initialization
	void Start () {
		Player.Instance.gameController = this;
		initialize ();
	}

	// method will be called when restart button is pressed and loads the main game scene to replay
	public void ResetBtnClick(){
		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);
	}

	// Adds enemy randomly to the scene
	private IEnumerator AddEnemy(){
		int time = Random.Range (20,40);

		yield return new WaitForSeconds ((float)time);
		Instantiate (plane);
		Instantiate (plane2);
		StartCoroutine ("AddEnemy");
	}
}
