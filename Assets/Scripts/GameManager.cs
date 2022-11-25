using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool present = true;
    [SerializeField]
    private GameObject presentMap;
    [SerializeField]
    private GameObject pastMap;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Time.timeScale = 0;
            TimeJumping();
        }
    }

    private void TimeJumping()
    {
        if (present)
        {
            Debug.Log("past");
            present = false;
            presentMap.SetActive(false);
            pastMap.SetActive(true);
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("present");
            present = true;
            presentMap.SetActive(true);
            pastMap.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
