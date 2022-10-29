using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteleraGameController : MonoBehaviour
{
    PlayerDetector billboardRoom;
    [SerializeField] Animator door_Anim;
    readonly string doorState = "isOpen";

    private void Awake() {
        billboardRoom = GetComponent<PlayerDetector>();
    }

    void Update()
    {
        CloseDoor();
       
    }

    void CloseDoor() {
        if(billboardRoom.playerInside && billboardRoom.playerEntries == 1) {
            door_Anim.SetBool(doorState, true);
        }
    }

    public void OpenDoor() {
        door_Anim.SetBool(doorState, false);
    }
}
