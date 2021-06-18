using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MockInputInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 

        if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "MockHMD" || XRSettings.loadedDeviceName ==
            "MockHMDDisplay")) { Debug.Log("Using Much Headset"); }
        else { Debug.Log("Headset: " + XRSettings.loadedDeviceName); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
