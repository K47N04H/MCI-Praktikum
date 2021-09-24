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
    public void ChangeCategorieColorRight()
    {
        textCategorie.GetComponent<Text>().color = colorCategorie;
        femalMessyHigh.material.color = colorCategorie;
        femalShortPonytail.material.color = colorCategorie;
        femalShortPonytailEins.material.color = colorCategorie;
        femalSpaceBunBig.material.color = colorCategorie;

    }

    // Change color while clicking the right button
    public void ChangeCategorieColorLeft()
    {
        textCategorie.GetComponent<Text>().color = colorCategorie;
        femalMessyHigh.material.color = colorCategorie;
        femalShortPonytail.material.color = colorCategorie;
        femalShortPonytailEins.material.color = colorCategorie;
        femalSpaceBunBig.material.color = colorCategorie;
    }
}
