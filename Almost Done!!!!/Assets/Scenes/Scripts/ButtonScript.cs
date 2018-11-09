using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public void Attack1(){
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		if (lm.heroTurn == true) {
			bp.playerAttack1 ();
		} else {
			lm.enemyTurn ();
		}
	}

	public void Attack2(){
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();

		if (lm.heroTurn == true) {
			bp.playerAttack2 ();
		} else {
			lm.enemyTurn ();
		}

	}
	public void Attack3(){
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		if (lm.heroTurn == true) {
			bp.playerAttack3 ();
		} else {
			lm.enemyTurn ();
		}
	}

	public void Defend(){
		
	}
}
