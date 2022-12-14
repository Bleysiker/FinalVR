using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.SnapZone;

public class CarteleraGameController : MonoBehaviour
{
    PlayerDetector billboardRoom;
    [SerializeField] Animator door_Anim;
    [SerializeField] REvents eventAudio;
    [SerializeField] AudioSource audio_instructions;
    readonly string doorState = "isOpen";
    [SerializeField] GameObject [] snapzones;
    CheckSnappedObject [] snaps;
    bool eventA = false;
    
    private void Awake() {
        billboardRoom = GetComponent<PlayerDetector>();
        snaps = new CheckSnappedObject[snapzones.Length];
        for(ushort i = 0; i < snapzones.Length; i++) {
            snaps[i] = snapzones[i].GetComponent<CheckSnappedObject>();
        }
        eventAudio.GEvent += InstructionsAudio;
        
    }

    void InstructionsAudio() {
        if(eventA == false) {
            audio_instructions.Play();
            eventA = true;
        }
    }

    void Update()
    {
        CloseDoor();
        CheckSnappedGO();
    }

    void CloseDoor() {
        if(billboardRoom.playerInside && billboardRoom.playerEntries == 1) {
            door_Anim.SetBool(doorState, true);
            //audio_instructions.Play();
        }
    }

    public void OpenDoor() {
        door_Anim.SetBool(doorState, false);
    }

    void CheckSnappedGO() {
        if(snaps[0].isCorrect && snaps[1].isCorrect &&
            snaps[2].isCorrect && snaps[3].isCorrect) {
            OpenDoor();
        }
    }

    private void OnDestroy() {
        eventAudio.GEvent -= InstructionsAudio;
    }
}
