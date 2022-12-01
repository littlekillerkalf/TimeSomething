using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCube : MonoBehaviour
{
    [SerializeField]
    private GameObject futureCube;
    [SerializeField]

    public bool hit;
    [SerializeField]
    private float timer = 1;
    private void Start()
    {

    }
    private void Update()
    {
        if (hit)
        {
            timer = timer - Time.deltaTime;
            Debug.Log("hit");
        }
        if(timer < 0)
        {
            hit = false;
            MoveCube();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    }

    private void MoveCube()
    {
        futureCube.SetActive(true);
        futureCube.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        futureCube.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        timer = 1;
        Debug.Log("moved");
    }
}
