using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDetector : MonoBehaviour
{
    public bool playerInside = false;
    public ushort playerEntries = 0;
   
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            playerInside = true;
            playerEntries++;
        }
    }
}
