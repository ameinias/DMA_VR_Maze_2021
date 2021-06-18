using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportDebug : MonoBehaviour
{



    public GameObject teleportLocation;

    // Start is called before the first frame update
    public void DebugOne()
    {
        Debug.Log("DebugOne");
    }

    public void DebugTwo()
    {
        Debug.Log("DebugTwo");

    }

    public void Jump()

    {


        this.gameObject.transform.position = teleportLocation.transform.position;


    }
}
