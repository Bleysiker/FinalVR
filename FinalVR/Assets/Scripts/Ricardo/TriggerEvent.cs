using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] REvents evento;
    [SerializeField] string tagObjeto; //el tag del objeto que va a tocar
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagObjeto))
        {
            evento.FireEvent();
        }
    }
}
