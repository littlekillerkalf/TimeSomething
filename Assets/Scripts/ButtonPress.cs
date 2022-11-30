using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public bool isButton = true;
    public GameObject objects;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PresentCube" && isButton)
        {
            Debug.Log("Fuck");
            objects.SetActive(true);
        }
        if (other.tag == "PastCube" && isButton)
        {
            Debug.Log("Fuck");
            objects.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PresentCube" && isButton)
        {
            Debug.Log("Fuck");
            objects.SetActive(false);
        }
        if (other.tag == "PastCube" && isButton)
        {
            Debug.Log("Fuck");
            objects.SetActive(false);
        }
    }
}
