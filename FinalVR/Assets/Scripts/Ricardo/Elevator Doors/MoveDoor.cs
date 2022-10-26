using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    [SerializeField] REvents abrir, cerrar;
    [SerializeField] Vector3 cerrada, abierta;
    [SerializeField] float desplazamiento,tiempoDesplazamiento;
    [SerializeField] bool izq,x,z,inverse;
    void Start()
    {
        cerrada = transform.position;
        abierta = cerrada;
        if (inverse == true)
        {
            desplazamiento = desplazamiento * -1;
        }
        SeleccionarDesplazamiento();
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
    void SeleccionarDesplazamiento()
    {
        if (izq == true) { 

            if (x == true)
            {
                abierta.x -= desplazamiento;
            }
            else
            {
                abierta.z -= desplazamiento;
            }
        }
        else
        {
            if (x == true)
            {
                abierta.x += desplazamiento;
            }
            else
            {
                abierta.z += desplazamiento;
            }
        }
    }
    private void OnDestroy()
    {
        abrir.GEvent -= Abrir;
        cerrar.GEvent -= Cerrar;
    }
}
