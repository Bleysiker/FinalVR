using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperButton : MonoBehaviour
{
    [SerializeField] REvents disappear;
    [SerializeField] GameObject button;
    void Start()
    {
        disappear.GEvent += Disappear;
    }

    void Disappear()
    {
        button.SetActive(false);
    }
}
