using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeJump : MonoBehaviour
{
    private bool present = true;
    public bool helpTextOn = false;
    public GameObject helpText;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            TimeJumping();
            if (helpTextOn)
            {
                helpTextOn = false;
                helpText.SetActive(false);
            }
        }
    }

    private void TimeJumping()
    {
        if (present)
        {
            Debug.Log("yes");
            transform.position = new Vector3(transform.position.x, transform.position.y - 400, transform.position.z);
            present = false;
        }
        else
        {
            Debug.Log("no");
            transform.position = new Vector3(transform.position.x, transform.position.y + 400, transform.position.z);
            present = true;
        }
    }
}
