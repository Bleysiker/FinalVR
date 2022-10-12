using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public void AbrirCamara() {
        Debug.Log("SE ABREEEE");
        transform.position = new Vector3(transform.position.x, 10, transform.position.z);
    }
}
