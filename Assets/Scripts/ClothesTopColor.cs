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
        new Color(0.5943396f, 0.1319459f, 0.1037291f, 1f),
        new Color(0.07266822f, 0.6698113f, 0.1575639f, 1),
        new Color(0.0745098f, 0.1679017f, 0.6705883f, 1f),
    };

    public TMPro.TMP_Text textCategorie;
    public Renderer femaleTunic;

    private static List<int> colors = new List<int> { 0, 1, 2, 3 };

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Clothes bottom color";
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
