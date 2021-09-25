using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinColor : MonoBehaviour
{
    public Color colorCategorie;
    public Text textCategorie;
    public Renderer femaleBaseBody;

    // Change color while clicking the button
    public void ChangeSkinColor()
    {
        textCategorie.GetComponent<Text>().color = colorCategorie;
        femaleBaseBody.materials[1].color = colorCategorie;
        femaleBaseBody.materials[2].color = colorCategorie;
        femaleBaseBody.materials[3].color = colorCategorie;
        femaleBaseBody.materials[4].color = colorCategorie;

    }
}
