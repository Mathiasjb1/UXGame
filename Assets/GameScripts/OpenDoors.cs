using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] private Animator Door1;
    [SerializeField] private Animator Door2;

    public void openLeDoors()
    {
        Door1.SetBool("DoorsOpen?", true);
        Door2.SetBool("DoorsOpen?", true);
    }
}
