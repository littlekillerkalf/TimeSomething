using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool present = true;
    [SerializeField]
    private GameObject presentMap;
    [SerializeField]
    private GameObject pastMap;

    private float timer = 2;
    private bool timeJump = false;

    public TextMeshProUGUI timerText;
    public bool helpTextOn = false;
    public GameObject helpText;
    // Update is called once per frame
    void Update()
    {
        if(timeJump == false)
        {
            timer = timer - Time.deltaTime;
        }
        if(timer <= 0)
        {
            timeJump = true;
        }
        if (Input.GetButtonDown("Fire1") && timeJump == true)
        {
            Time.timeScale = 0;
            TimeJumping();
            timeJump = false;
            timer = 2;
            if (helpTextOn)
            {
                helpTextOn = false;
                helpText.SetActive(false);
            }
        }
        timerText.text = "Time Jump: " + timer.ToString("f0");
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
