using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameSaver : MonoBehaviour
{
    public TextMeshProUGUI nameInputField;
    public TMP_InputField congratsText;

    // Update is called once per frame
    public void setName()
    {
        nameInputField.text = congratsText.text + "!";
    }
}