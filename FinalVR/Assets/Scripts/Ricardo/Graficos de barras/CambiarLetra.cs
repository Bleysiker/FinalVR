using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiarLetra : MonoBehaviour
{
    [SerializeField] string[] titulo;
    [SerializeField] TextMeshProUGUI letrero;
    [SerializeField] bool num;
    [SerializeField] REvents p1, p2, p3, p4;
    void Start()
    {
        if (num == false)
        {
            letrero.text = "no hay pelicula";
        }
        
        p1.GEvent += PeliculaUno;
        p2.GEvent += PeliculaDos;
        p3.GEvent += PeliculaTres;
        p4.GEvent += PeliculaCuatro;
    }

    void PeliculaUno()
    {
        letrero.text = titulo[0];
    }
    void PeliculaDos()
    {
        letrero.text = titulo[1];
    }
    void PeliculaTres()
    {
        letrero.text = titulo[2];
    }
    void PeliculaCuatro()
    {
        letrero.text = titulo[3];
    }
    private void OnDestroy()
    {
        p1.GEvent -= PeliculaUno;
        p2.GEvent -= PeliculaDos;
        p3.GEvent -= PeliculaTres;
        p4.GEvent -= PeliculaCuatro;
    }
}
