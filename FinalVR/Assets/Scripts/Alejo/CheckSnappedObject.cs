using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.SnapZone;

public class CheckSnappedObject : MonoBehaviour
{
    [SerializeField] string m_tag;
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

    public void UnsnappedElement() {
        isCorrect = false;
    }
}
