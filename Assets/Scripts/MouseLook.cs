using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    private Camera cameraa;

    //public GameObject menu;

    [HideInInspector]
    public bool open;

    //public GameObject gameManager;
    private bool pause;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //menu = GameObject.Find("Menu");
        //menu.SetActive(false);
        open = false;
    }

    void Update()
    {
            if (!open)
            {
                float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);

                playerBody.Rotate(Vector3.up * mouseX);
                transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            }
            if (Input.GetKeyDown("escape"))
            {
                //Menu();
            }

    }

    private void Menu()
    {
        if (!open)
        {
            Debug.Log("works");
            //menu.gameObject.SetActive(true);
            open = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            //menu.gameObject.SetActive(false);
            open = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
