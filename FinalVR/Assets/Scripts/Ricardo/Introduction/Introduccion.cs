using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduccion : MonoBehaviour
{
    [SerializeField] AudioSource intro;
    [SerializeField] REvents iniciarExp;
    [SerializeField] float tiempoIntro,puerta;
    [SerializeField] bool ubicado;
    void Start()
    {
        ubicado = false;
        iniciarExp.GEvent += IniciarExp;
    }
    void IniciarExp()
    {
        if (ubicado == true)
        {
            StartCoroutine("Iniciar");
        }
    }
    IEnumerator Iniciar()
    {
        yield return new WaitForSeconds(puerta);
        intro.Play();
        yield return new WaitForSeconds(tiempoIntro);
        SceneManager.LoadScene("Museo");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ubicado = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ubicado = false;
        }
    }
    private void OnDestroy()
    {
        iniciarExp.GEvent -= IniciarExp;
    }
}
