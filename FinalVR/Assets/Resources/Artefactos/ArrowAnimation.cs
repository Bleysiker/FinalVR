using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimation : MonoBehaviour
{
    [SerializeField] Vector3 posicionNueva;
    [SerializeField] float tiempoRebote;
    void Start()
    {
        transform.LeanMoveLocal(posicionNueva, tiempoRebote).setEaseOutQuart().setLoopPingPong();
    }

}
