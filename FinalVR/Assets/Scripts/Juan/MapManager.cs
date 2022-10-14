using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject canvas;

    public void canvasButton()
    {
        canvas.SetActive(!canvas.activeSelf);
    }
    public void canvasActivateReloj()
    {
        canvas.SetActive(true);
    }
}
