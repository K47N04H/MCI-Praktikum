using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClothesTopColor : MonoBehaviour
{
    Color[] topcolor =
    {
        new Color(1f, 1f, 1f, 1f),
        new Color(0.8f, 0.6f, 1f, 1f),
        new Color(0.6627451f, 0.8196079f, 0.9686275f, 1),
        new Color(0.7058824f, 0.9411765f, 0.654902f, 1f),
        new Color(1f, 1f, 0.7490196f, 1f),
        new Color(1f, 0.8745098f, 0.7450981f, 1f),
        new Color(1f, 0.6941177f, 0.6901961f, 1f),
        new Color(0f, 0f, 0f, 1f),
        new Color(0.5f, 0.5f, 0.5f, 1f),
    };

    public TMPro.TMP_Text textCategorie;
    public Renderer femaleTunic;

    private static List<int> colors = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8};

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Clothes bottom";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Eyecolor";
    }

    public void ChangeSettingTopcolorForward()
    {
        int item = colors[0];
        colors.RemoveAt(0);
        colors.Insert(colors.Count, item);

        int currentColor = colors[0];

        // Debug.Log("Forward: " + colors[0]);

        femaleTunic.material.color = topcolor[currentColor];
    }

    public void ChangeSettingTopcolorBack()
    {
        int item = colors[colors.Count - 1];
        colors.RemoveAt(colors.Count - 1);
        colors.Insert(0, item);

        int currentColor = colors[0];

        // Debug.Log("BACK: " + colors[0]);

        femaleTunic.material.color = topcolor[currentColor];
    }
 }
