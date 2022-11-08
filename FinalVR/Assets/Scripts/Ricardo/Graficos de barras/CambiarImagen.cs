using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarImagen : MonoBehaviour
{
    [SerializeField] Image poster;
    [SerializeField] Sprite[] imagen;
    [SerializeField] REvents p1, p2, p3,p4;
    [SerializeField] bool crecer;
    void Start()
    {
        transform.localScale = Vector3.zero;
        p1.GEvent += PeliculaUno;
        p2.GEvent += PeliculaDos;
        p3.GEvent += PeliculaTres;
        p4.GEvent += PeliculaCuatro;
    }
    void PeliculaUno()
    {
        Crecer();
        poster.sprite = imagen[0];
    }
    void PeliculaDos()
    {
        Crecer();
        poster.sprite = imagen[1];
    }
    void PeliculaTres()
    {
        Crecer();
        poster.sprite = imagen[2];
    }
    void PeliculaCuatro()
    {
        Crecer();
        poster.sprite = imagen[3];
    }
    void Crecer()
    {
        if (crecer == false)
        {
            transform.LeanScale(Vector3.one, 1f).setEaseInOutQuart();
            crecer = true;
        }
    }
    private void OnDestroy()
    {
        p1.GEvent -= PeliculaUno;
        p2.GEvent -= PeliculaDos;
        p3.GEvent -= PeliculaTres;
        p4.GEvent -= PeliculaCuatro;
    }
}
