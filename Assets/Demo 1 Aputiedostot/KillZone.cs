using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour {


    private AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        // Tämä estää audioSource-objektin tuhoutumisen uuden kohtauksen latauksen yhteydessä
        DontDestroyOnLoad(audioSource.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
	[SerializeField] private AudioClip pickAudio;
	void OnCollisionEnter(Collision collision)
	{
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        if (collision.gameObject.tag == "Player") {
            
            Debug.Log ("Level Failed!");
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
            

		}
	}
}
