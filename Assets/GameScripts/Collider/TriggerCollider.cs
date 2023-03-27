using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    [SerializeField] private GameObject HideLeObjectPls;
    [SerializeField] private GameObject ShowLeObjectPls;
    private void OnTriggerEnter(Collider other)
    {
        HideLeObjectPls.SetActive(false);
        ShowLeObjectPls.SetActive(true);
    }
}
