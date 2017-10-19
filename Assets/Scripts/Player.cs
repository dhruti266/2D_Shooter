using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

	public GameController gameCtrl;
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
			gameCtrl.updateUI();
		}

	}

	public int Life{
		get{ return _life; }
		set{ 
			_life = value;

			if (_life <= 0) {
				//game over
				gameCtrl.gameOver();

			}else{
				gameCtrl.updateUI();
			}
		}
	}
}
