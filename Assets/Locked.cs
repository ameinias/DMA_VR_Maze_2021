using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked : MonoBehaviour
{

    public GameObject lockedPopUp;

    void Start()
    {
        lockedPopUp.SetActive(false);
    }

    public void OnSelected()
    {
        if (GameController.hasKey)
        {
            Destroy(this.gameObject);
        }
        else
        {

            lockedPopUp.SetActive(true);
        }
    }

    public void OnNotSelected()
    {
        lockedPopUp.SetActive(false);
    }

}
