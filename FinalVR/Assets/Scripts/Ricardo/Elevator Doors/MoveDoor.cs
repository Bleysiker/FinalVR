using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    [SerializeField] REvents abrir, cerrar;
    [SerializeField] Vector3 cerrada, abierta;
    [SerializeField] float desplazamiento,tiempoDesplazamiento;
    [SerializeField] bool izq;
    void Start()
    {
        cerrada = transform.position;
        abierta = cerrada;
        if (izq == true)
        {
            abierta.x -= desplazamiento;
        }
        else
        {
            abierta.x += desplazamiento;
        }
        Abrir();
        abrir.GEvent += Abrir;
        cerrar.GEvent += Cerrar;
    }
    void Abrir()
    {
        transform.LeanMoveLocal(abierta, tiempoDesplazamiento).setEaseOutQuart();
    }
    void Cerrar()
    {
        transform.LeanMoveLocal(cerrada, tiempoDesplazamiento).setEaseOutQuart();
    }
    private void OnDestroy()
    {
        abrir.GEvent -= Abrir;
        cerrar.GEvent -= Cerrar;
    }
}
