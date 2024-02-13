using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

//	[SerializeField] private Transform pickAudioSource;

	void OnTriggerEnter(Collider other) {

		Debug.Log("Collision Enter " + other.gameObject.name);
		//if(other.gameObject.name == "FPSController")
        //{
			//TODO: Send a message to pick the log and update inventory
			//other.gameObject.SendMessage("PickKey");
		GameObject.Find("GameManager").SendMessage("PickKey");
			//Instantiate(this.pickAudioSource);

			//TODO: Delete the log game object that was picked from the scene
			Destroy(gameObject);			
		//}

	}

}
