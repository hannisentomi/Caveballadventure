using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	[SerializeField] private AudioClip pickAudio;
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Level Failed!");
			AudioSource.PlayClipAtPoint(pickAudio, transform.position);
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);

		}
	}
}
