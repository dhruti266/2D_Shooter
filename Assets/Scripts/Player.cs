/*	
 * File : Player.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified : October 21, 2017
 * Program Description : This script has Score and Life get, set properties to update 
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

	public GameController gameController;
	private static Player _instance;

	public static Player Instance{
		get{
			if(_instance == null){
				_instance = new Player();
			}
			return _instance;
		}
	}
	private int _score = 0;
	private int _life = 3;

	public int Score{
		get{ return _score; }
		set{ 
			_score = value;
			gameController.updateUI();
		}

	}

	public int Life{
		get{ return _life; }
		set{ 
			_life = value;

			if (_life <= 0) {
				//game over
				gameController.gameOver();

			}else{
				gameController.updateUI();
			}
		}
	}
}
