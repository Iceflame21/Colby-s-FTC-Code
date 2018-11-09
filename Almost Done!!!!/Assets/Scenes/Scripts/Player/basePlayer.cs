using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basePlayer : MonoBehaviour {

[SerializeField]
private StatusIndicator statusIndicator;


[System.Serializable]
public class Stats
{

	private int _curHealth;
	public  int maxhealth = 100;

	private int _curDank;
	public int maxDank = 100;

	public int curHealth{
		get{ return _curHealth;}
		set{ _curHealth = Mathf.Clamp(value, 0, maxhealth);}
	}

	public int curDank{
			get{ return _curDank;}
			set{ _curDank = Mathf.Clamp (value, 0, maxDank);}
	}





	public void Init(){
		_curHealth = maxhealth;

		_curDank = maxDank;
	}
}

public Stats stats = new Stats();
void Start(){
	stats.Init ();

	if (statusIndicator != null) {
		statusIndicator.SetHealth (stats.curHealth, stats.maxhealth );
			statusIndicator.SetDank (stats.curDank, stats.maxDank);
	}
}
	public void DamagePlayer (int damage){
		stats.curHealth -= damage;
		if (stats.curHealth <= 0) {
			LevelManager.FindObjectOfType<LevelManager> ();
			LevelManager.killPlayer (this);
		}
		if (statusIndicator != null) {
			statusIndicator.SetHealth (stats.curHealth, stats.maxhealth);
		}

	}

	public void changeDank(int amount){
		stats.curDank -= amount;
		if (statusIndicator != null) {
			statusIndicator.SetDank (stats.curDank, stats.maxDank);
		}

	}

	public void addDank(int amount){
		stats.curDank += amount;
		if (statusIndicator != null) {
			statusIndicator.SetDank (stats.curDank, stats.maxDank);
		}
	}

	public void playerAttack1(){
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();

		Enemy ee = lm.E [Random.Range (0, lm.E.Count)];
		if (ee != null) {
			ee.DamageEnemy (25);
		} else {
			playerAttack2 ();
		}
		addDank (10);
		lm.heroTurn = false;
	}

	public void playerAttack2(){
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();

		if (stats.curDank - 10 <= 0) {
			bp.DamagePlayer (2);
		} else {

			Enemy ee = lm.E [Random.Range (0, lm.E.Count)];
			if (ee != null) {
				ee.DamageEnemy (50);
			} else {
				playerAttack2 ();
			}

		}
		changeDank (10);
		lm.heroTurn = false;
	}

	public void playerAttack3(){

		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();

		foreach(Enemy ee in LevelManager.FindObjectsOfType<Enemy>()){
			if(Random.Range(0f, lm.E.Count) > 0){
				if(ee == null){
					continue;
				}
				ee.DamageEnemy (25);

			}
		}
		bp.DamagePlayer (10);
		bp.changeDank (25);
		lm.heroTurn = false;
	}


	public void playerDefend(){
	
	}


}

