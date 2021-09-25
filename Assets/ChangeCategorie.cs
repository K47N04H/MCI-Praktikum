using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCategorie : MonoBehaviour
{
    public Color colorCategorie;
    public Text textCategorie;
    public Renderer femalMessyHigh;
    public Renderer femalShortPonytail;
    public Renderer femalShortPonytailEins;
    public Renderer femalSpaceBunBig;


    // Change color while clicking the right button
    public void ChangeCategorieForward()
    {
        textCategorie.GetComponent<Text>().text = "Skin Color";
    }

    // Change color while clicking the left button
    public void ChangeCategorieBack()
    {
        textCategorie.GetComponent<Text>().text = "Hair Color";
    }

    // Change color while clicking the button
    public void ChangeCategorieColor()
    {
        textCategorie.GetComponent<Text>().color = colorCategorie;
        femalMessyHigh.material.color = colorCategorie;
        femalShortPonytail.material.color = colorCategorie;
        femalShortPonytailEins.material.color = colorCategorie;
        femalSpaceBunBig.material.color = colorCategorie;

    }
}
