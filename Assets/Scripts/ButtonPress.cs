using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public bool isButton = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PresentCube" && isButton)
        {
            Debug.Log("Fuck");
        }
        if (other.tag == "PastCube" && isButton)
        {
            Debug.Log("Fuck");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PresentCube" && isButton)
        {
            Debug.Log("Fuck");
        }
        if (other.tag == "PastCube" && isButton)
        {
            Debug.Log("Fuck");
        }
    }
}
