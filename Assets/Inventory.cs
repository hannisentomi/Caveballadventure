using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public int amountOfKeys = 0;
    public GameObject campfireUI;
    public static bool doorOpen = false;

	void PickKey () {

		amountOfKeys = amountOfKeys + 1;

        if(amountOfKeys == 3)
        {
            Debug.Log("Ovi avattu!");
            doorOpen = true;
        }
	}
}
