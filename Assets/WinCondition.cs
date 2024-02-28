using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Inventory playerInventory;
    public GameObject WinText;
    public Animation anim;
    [SerializeField] private AudioClip pickAudio;


    private void Start()
    {
        
        WinText.SetActive(false); // Alussa voittoilmoitus on pois päältä
                
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerInventory.amountOfKeys == 3 && Inventory.doorOpen)
            {
                anim = GetComponent<Animation>();
                // Pelaaja koski oveen ja hänellä on 3 avainta, näytä voittoilmoitus
                WinText.SetActive(true);
                anim.Play("Door_Open");
                AudioSource.PlayClipAtPoint(pickAudio, transform.position);
            }
        }
    }
}