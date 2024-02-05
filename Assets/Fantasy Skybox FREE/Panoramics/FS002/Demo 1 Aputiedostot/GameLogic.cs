using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Text scoreText;
	public int errors = 0;

	// Use this for initialization
	void Start () {

		scoreText = GameObject.Find ("Text").GetComponent<Text>();
		scoreText.text = "Errors: 0";
	}
	

	void HandleError () {

		errors = errors + 1;
		scoreText.text = "Errors: " + errors;
	}
}
