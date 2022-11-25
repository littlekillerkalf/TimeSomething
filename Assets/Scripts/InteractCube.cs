using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCube : MonoBehaviour
{
    [SerializeField]
    private GameObject futureCube;
    [SerializeField]

    public bool hit;
    private float timer;
    private void Start()
    {

    }
    private void Update()
    {
        if (hit)
        {
            timer = timer - Time.deltaTime;
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

    public void MoveCube()
    {
        futureCube.transform.position = new Vector3(transform.position.x, transform.position.y + 400, transform.position.z);
    }
}
