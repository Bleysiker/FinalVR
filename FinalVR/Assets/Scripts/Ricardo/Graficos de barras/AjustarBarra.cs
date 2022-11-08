using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjustarBarra : MonoBehaviour
{
    [SerializeField] float[] escalasBarra;
    [SerializeField] float tiempo;
    [SerializeField] REvents p1, p2, p3, p4;
    void Start()
    {
        transform.transform.LeanScaleX(0, 0f).setEaseInOutQuart();
        p1.GEvent += PeliculaUno;
        p2.GEvent += PeliculaDos;
        p3.GEvent += PeliculaTres;
        p4.GEvent += PeliculaCuatro;
    }

    void PeliculaUno()
    {
        transform.transform.LeanScaleX(escalasBarra[0], tiempo).setEaseInOutQuart();
    }
    void PeliculaDos()
    {
        transform.transform.LeanScaleX(escalasBarra[1], tiempo).setEaseInOutQuart();
    }
    void PeliculaTres()
    {
        transform.transform.LeanScaleX(escalasBarra[2], tiempo).setEaseInOutQuart();
    }
    void PeliculaCuatro()
    {
        transform.transform.LeanScaleX(escalasBarra[3], tiempo).setEaseInOutQuart();
    }
    private void OnDestroy()
    {
        p1.GEvent -= PeliculaUno;
        p2.GEvent -= PeliculaDos;
        p3.GEvent -= PeliculaTres;
        p4.GEvent -= PeliculaCuatro;
    }
}
