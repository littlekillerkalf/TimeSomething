using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGenerator : MonoBehaviour
{
    public TextMeshProUGUI helpText;
    public string texttext;
    private void OnTriggerEnter(Collider other)
    {
        helpText.text = texttext;
    }
    private void OnTriggerExit(Collider other)
    {
        helpText.text = "";
    }
}
