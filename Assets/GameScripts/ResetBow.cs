using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBow : MonoBehaviour
{
    [SerializeField] private GameObject LeBow;
    public Vector3 bowStartPosition;
    private void Start()
    {
        bowStartPosition = transform.position;
    }

    public void bowReset()
    {
        //    // Only reset high level grabbables that aren't being held

        //    //kvp.Key.transform.position = kvp.Value.Position;
        //    //kvp.Key.transform.rotation = kvp.Value.Rotation;

        //    LeBow.transform.position = BowPositionStart.transform.position;


        //        Rigidbody rb = LeBow.GetComponent<Rigidbody>();
        //        if (rb)
        //        {
        //            rb.velocity = Vector3.zero;
        //            rb.angularVelocity = Vector3.zero;
        //        }

        transform.position = bowStartPosition;
        
    }
}
