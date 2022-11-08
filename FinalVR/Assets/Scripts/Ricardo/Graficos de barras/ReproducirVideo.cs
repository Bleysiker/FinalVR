using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ReproducirVideo : MonoBehaviour
{
    [SerializeField] VideoClip[] trailer;
    [SerializeField] VideoPlayer reproductor;
    [SerializeField] REvents t1, t2, t3, t4;
    // Start is called before the first frame update
    void Start()
    {
        reproductor = GetComponent<VideoPlayer>();
        t1.GEvent += TrailerUno;
        t2.GEvent += TrailerDos;
        t3.GEvent += TrailerTres;
        t4.GEvent += TrailerCuatro;
    }

    void TrailerUno()
    {
        reproductor.Stop();
        reproductor.clip = trailer[0];
        reproductor.Play();
    }
    void TrailerDos()
    {
        reproductor.Stop();
        reproductor.clip = trailer[1];
        reproductor.Play();
    }
    void TrailerTres()
    {
        reproductor.Stop();
        reproductor.clip = trailer[2];
        reproductor.Play();
    }
    void TrailerCuatro()
    {
        reproductor.Stop();
        reproductor.clip = trailer[3];
        reproductor.Play();
    }
    private void OnDestroy()
    {
        t1.GEvent -= TrailerUno;
        t2.GEvent -= TrailerDos;
        t3.GEvent -= TrailerTres;
        t4.GEvent -= TrailerCuatro;
    }
}
