using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueArrow"))
        {

        }
    }
        

       
}
