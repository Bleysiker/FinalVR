using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] Animator m_anim;   
    public void Open()
    {
        m_anim.SetBool("isOpen", true);
    }

    public void Close()
    {
        m_anim.SetBool("isOpen", false);
    }
   
}
