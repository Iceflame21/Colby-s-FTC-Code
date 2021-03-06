﻿using UnityEngine.UI;
using UnityEngine;

public class StatusIndicator : MonoBehaviour {

	[SerializeField]
	private RectTransform healthBar;
	[SerializeField]
	private Text healthText;
	[SerializeField]
	private RectTransform dankMeter;
	[SerializeField]
	private Text dankText;





	public void SetHealth(int _cur, int _max){
		float _value = (float)_cur / _max;
		healthBar.localScale = new Vector3 (_value, healthBar.localScale.y, healthBar.localScale.z);
		healthText.text = _cur + "/" + _max + " HP";
	}


	public void SetDank(int _cur, int _max){
		float _value = (float)_cur / _max;
		dankMeter.localScale = new Vector3 (_value, dankMeter.localScale.y, dankMeter.localScale.z);
		dankText.text = _cur + "/" + _max + " HP";
	}
}
