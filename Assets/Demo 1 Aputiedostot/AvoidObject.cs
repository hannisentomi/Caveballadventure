using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidObject : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {

			GameObject.Find ("Main Camera").SendMessage ("HandleError");
		}
	}
}
