using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButtonEvent : MonoBehaviour
{
    [SerializeField] REvents evento;

    public void FireUIEvent()
    {
        evento.FireEvent();
    }
}
