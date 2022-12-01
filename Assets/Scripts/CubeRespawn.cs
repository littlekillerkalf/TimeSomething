using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{
    public GameObject TeleportPoint;
    public GameObject cube;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            cube.gameObject.transform.position = TeleportPoint.gameObject.transform.position;
        }
    }
}
