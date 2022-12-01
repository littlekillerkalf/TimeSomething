using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public bool isButton = true;
    public GameObject objects;
    public bool invert = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!invert)
        {
            if (other.tag == "PresentCube" && isButton)
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
        else if (invert)
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

    private void OnTriggerExit(Collider other)
    {
        if (!invert)
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
        else if (invert)
        {
            if (other.tag == "PresentCube" && isButton)
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
    }
}
