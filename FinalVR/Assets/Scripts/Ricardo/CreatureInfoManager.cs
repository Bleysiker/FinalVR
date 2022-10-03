using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreatureInfoManager : MonoBehaviour
{
    [SerializeField] InfoCriatura[] criatura;
    [SerializeField] int infoPos;
    [SerializeField] float aparicionObjetos;
    [SerializeField] TextMeshProUGUI raza, tamano, general, peli, habilidades;
    [SerializeField] Image aspecto, pelicula;
    [SerializeField] bool appear;
    [SerializeField] REvents correrDerecha, correrIzquierda, interruptor;
    [SerializeField] Vector3 inicialScale;
    void Start()
    {
        inicialScale = transform.localScale;
        infoPos = 0;
        appear = false;
        AssignInfo();
        transform.localScale = Vector3.zero;
        correrDerecha.GEvent += ChangeRight;
        correrIzquierda.GEvent += ChangeLeft;
        interruptor.GEvent += AppearDisappear;
    }

    void AppearDisappear()
    {
        if (appear == false)
        {
            transform.LeanScale(inicialScale, aparicionObjetos).setEaseOutQuart();
            appear = true;
        }
        else
        {
            transform.LeanScale(Vector3.zero, aparicionObjetos).setEaseOutQuart();
            appear = false;
        }
    }
    void ChangeRight()
    {
        infoPos++;
        if (infoPos > criatura.Length - 1)
        {
            infoPos = 0;
        }
        AssignInfo();
    }
    void ChangeLeft()
    {
        infoPos--;
        if (infoPos < 0)
        {
            infoPos = criatura.Length - 1;
        }
        AssignInfo();
    }
    void AssignInfo()
    {
        raza.text = criatura[infoPos].raza;
        tamano.text= criatura[infoPos].tamano;
        general.text = criatura[infoPos].informacionGeneral;
        peli.text= criatura[infoPos].peli;
        habilidades.text = criatura[infoPos].habilidades;
        aspecto.sprite= criatura[infoPos].aspecto;
        pelicula.sprite = criatura[infoPos].pelicula;
    }
    private void OnDestroy()
    {
        correrDerecha.GEvent -= ChangeRight;
        correrIzquierda.GEvent -= ChangeLeft;
        interruptor.GEvent -= AppearDisappear;
    }
}
