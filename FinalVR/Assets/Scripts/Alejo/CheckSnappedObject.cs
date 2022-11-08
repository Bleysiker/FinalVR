using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.SnapZone;

public class CheckSnappedObject : MonoBehaviour
{
    [SerializeField] string m_tag;
    [SerializeField] REvents[] evento;
    SnapZoneFacade snapped;
    public bool isCorrect = false;

    private void Start() {
        snapped = GetComponent<SnapZoneFacade>();
    }

    public void VerifyTag() {
        if (snapped.SnappedGameObject.CompareTag(m_tag)) isCorrect = true;
        /*if (snapped.SnappedGameObject == null) isCorrect = false;
        else snapped = null;*/
    }
    public void EventVerify()
    {
        if (snapped.SnappedGameObject.CompareTag("MIB1"))
        {
            evento[0].FireEvent();
        }
        else if(snapped.SnappedGameObject.CompareTag("MIB2"))
        {
            evento[1].FireEvent();
        }
        else if (snapped.SnappedGameObject.CompareTag("MIB3"))
        {
            evento[2].FireEvent();
        }
        else if (snapped.SnappedGameObject.CompareTag("MIB4"))
        {
            evento[3].FireEvent();
        }
    }
    public void UnsnappedElement() {
        isCorrect = false;
    }
}
