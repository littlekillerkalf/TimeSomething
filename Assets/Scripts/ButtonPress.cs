using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PresentCube")
        {
            Debug.Log("Fuck");
        }
        if (other.tag == "PastCube")
        {
            Debug.Log("Fuck");
        }
    }
}
