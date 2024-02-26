using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Inventory playerInventory;
    public GameObject winText;

    private void Start()
    {
        winText.SetActive(false); // Alussa voittoilmoitus on pois päältä
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerInventory.amountOfKeys == 3 && Inventory.doorOpen)
            {
                // Pelaaja koski oveen ja hänellä on 3 avainta, näytä voittoilmoitus
                winText.SetActive(true);
            }
        }
    }
}