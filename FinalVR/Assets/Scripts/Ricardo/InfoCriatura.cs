using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu(fileName = "Informacion de Criatura")]

public class InfoCriatura : ScriptableObject
{
    public string raza,peli;
    [TextArea(3,10)]
    public string informacionGeneral, habilidades, tamano;
    public Sprite aspecto,pelicula;
    
}
