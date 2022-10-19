using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapTrack : MonoBehaviour
{
    [SerializeField] Image[] zona;
    [SerializeField] Color colorO, colorD;
    [SerializeField] REvents artefactos, criaturas, principal, cartelera, entrada;

    void Start()
    {
        Entrada();
        artefactos.GEvent += Artefactos;
        criaturas.GEvent += Criaturas;
        principal.GEvent += Principal;
        cartelera.GEvent += Cartelera;
        entrada.GEvent += Entrada;
    }

    void Artefactos()
    {
        OcupadoyDesocupado(zona[0], zona[4], zona[1], zona[2], zona[3]);
    }
    void Criaturas()
    {
        OcupadoyDesocupado(zona[1], zona[0], zona[4], zona[2], zona[3]);
    }
    void Principal()
    {
        OcupadoyDesocupado(zona[2], zona[0], zona[1], zona[4], zona[3]);
    }
    void Cartelera()
    {
        OcupadoyDesocupado(zona[3], zona[0], zona[1], zona[2], zona[4]);
    }
    void Entrada()
    {
        OcupadoyDesocupado(zona[4], zona[0], zona[1], zona[2], zona[3]);
    }
    void OcupadoyDesocupado(Image ocupado,Image d1, Image d2, Image d3, Image d4)
    {
        ocupado.color = colorO;

        d1.color = colorD;
        d2.color = colorD;
        d3.color = colorD;
        d4.color = colorD;
    }
    private void OnDestroy()
    {
        artefactos.GEvent -= Artefactos;
        criaturas.GEvent -= Criaturas;
        principal.GEvent -= Principal;
        cartelera.GEvent -= Cartelera;
        entrada.GEvent -= Entrada;
    }
}
