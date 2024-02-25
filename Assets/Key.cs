using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	[SerializeField] private AudioClip pickAudio;
	

    void OnTriggerEnter(Collider other) {

		Debug.Log("Collision Enter " + other.gameObject.name);
		//if(other.gameObject.name == "FPSController")
        //{
			//TODO: Send a message to pick the log and update inventory
			//other.gameObject.SendMessage("PickKey");
		GameObject.Find("GameManager").SendMessage("PickKey");
			//Instantiate(this.pickAudioSource);
		AudioSource.PlayClipAtPoint(pickAudio, transform.position);

			//TODO: Delete the log game object that was picked from the scene
			Destroy(gameObject);			
		//}

	}

}
