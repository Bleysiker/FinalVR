using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrecerBarra : MonoBehaviour
{
    [SerializeField] Image barra;
    [SerializeField] Color ganancia, perdida;
    [SerializeField] bool recaudo;
    [SerializeField] float tiempoBarra,tamanofinal,porcentajeRecaudo;
    [SerializeField] REvents aparecer;
    [SerializeField] CanvasGroup tituloBarra;
    void Start()
    {
        transform.transform.LeanScaleX(0, 0f).setEaseInOutQuart();
        aparecer.GEvent += EstablecerBarra;
        tituloBarra.alpha = 0;
    }

    void EstablecerBarra()
    {
        transform.LeanScaleX(tamanofinal, tiempoBarra).setEaseInOutQuart();
        tituloBarra.LeanAlpha(1f, tiempoBarra/2);
    }
    private void Update()
    {
        if (recaudo == false)
        {
            if (transform.transform.localScale.x < porcentajeRecaudo)
            {
                barra.color = perdida;
            }
            else
            {
                barra.color = ganancia;
            }
        }
    }
    private void OnDestroy()
    {
        aparecer.GEvent -= EstablecerBarra;
    }
}
