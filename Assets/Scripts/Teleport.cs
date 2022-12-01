using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleportMarker;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = teleportMarker.transform.position;
    }
}
