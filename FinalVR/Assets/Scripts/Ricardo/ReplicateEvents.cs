using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplicateEvents : MonoBehaviour
{
    [SerializeField] REvents evento1, evento2;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            evento1.FireEvent();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            evento2.FireEvent();
        }
    }
}
