using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperButton : MonoBehaviour
{
    [SerializeField] REvents disappear;
    [SerializeField] GameObject[] button;
    void Start()
    {
        disappear.GEvent += Disappear;
    }

    void Disappear()
    {
        button[0].SetActive(false);
        button[1].SetActive(false);
    }
}
