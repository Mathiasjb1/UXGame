using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUnDestroy : MonoBehaviour
{
    [SerializeField] private GameObject hideObjectHere;
    void DestroyThisGameObject()
    {
        Destroy(gameObject);
    }

    public void DestroyLeObject()
    {
        DestroyThisGameObject();
    }

    public void HideThisObject()
    {
        hideObjectHere.SetActive(false);
    }

    public void UnHideThisObject()
    {
        hideObjectHere.SetActive(true);
    }
}
