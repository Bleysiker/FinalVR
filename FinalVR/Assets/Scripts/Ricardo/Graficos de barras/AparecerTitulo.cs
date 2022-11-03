using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerTitulo : MonoBehaviour
{
    [SerializeField] CanvasGroup titulo;
    [SerializeField] float tiempoAparicion,tiempoEspera;
    [SerializeField] REvents evento;
    // Start is called before the first frame update
    void Start()
    {
        titulo.alpha = 0;
        evento.GEvent += AparecerObjeto;
    }

    void AparecerObjeto()
    {
        StartCoroutine("Aparecer");
    }
    IEnumerator Aparecer()
    {
        yield return new WaitForSeconds(tiempoEspera);
        titulo.LeanAlpha(1f, tiempoAparicion);
    }
    private void OnDestroy()
    {
        evento.GEvent -= AparecerObjeto;
    }
}
