using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Haircolor : MonoBehaviour
{
    Color[] haircolor =
    {
        new Color(1, 1f, 1f, 1f),
        new Color(0.8588235f, 0.8588235f, 0.8588235f, 1f),
        new Color(0.7215686f, 0.5921569f, 0.4705882f, 1f),
        new Color(0.3058824f, 0.2627451f, 0.2470588f, 1f),
        new Color(0.5943396f, 0.1319459f, 0.1037291f, 1f),
        new Color(0.03529412f, 0.03137255f, 0.02352941f, 1f),
        new Color(0.07266822f, 0.6698113f, 0.1575639f, 1),
        new Color(0.0745098f, 0.1679017f, 0.6705883f, 1f),
        new Color(0.8207547f, 0.1587308f, 0.5216417f, 1f)
     };

    public TMPro.TMP_Text textCategorie;
    public Color colorCategorie;
    public Renderer femaleA7;
    public Renderer femaleBabyBangs;
    public Renderer femaleLongHigh;
    public Renderer femalePonytailBack;
    public Renderer femalePonytailL;
    public Renderer femalePonytailR;
    public Renderer femaleDoubleLow;
    public Renderer femaleMessyHigh;
    public Renderer femaleMessyPonytailBack;
    public Renderer femaleSamuraiBun;
    public Renderer femaleSideBangs;
    public Renderer femaleSideBangsO;
    public Renderer femaleSpaceBun;
    public Renderer femaleStraightShortLow;

    private static List<int> colors = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };


    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Hairstyle";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Skincolor";
    }

    // Change categorie forward while clicking the right button
    public void ChangeSettingHaircolorForward()
    {
        int item = colors[0];
        colors.RemoveAt(0);
        colors.Insert(colors.Count, item);

        int currentColor = colors[0];

        // Debug.Log("Forward: " + colors[0]);

        femaleA7.material.color = haircolor[currentColor];
        femaleBabyBangs.material.color = haircolor[currentColor];
        femaleLongHigh.material.color = haircolor[currentColor];
        femalePonytailBack.material.color = haircolor[currentColor];
        femalePonytailL.material.color = haircolor[currentColor];
        femalePonytailR.material.color = haircolor[currentColor];
        femaleDoubleLow.material.color = haircolor[currentColor];
        femaleMessyHigh.material.color = haircolor[currentColor];
        femaleMessyPonytailBack.material.color = haircolor[currentColor];
        femaleSamuraiBun.material.color = haircolor[currentColor];
        femaleSideBangs.material.color = haircolor[currentColor];
        femaleSideBangsO.material.color = haircolor[currentColor];
        femaleSpaceBun.material.color = haircolor[currentColor];
        femaleStraightShortLow.material.color = haircolor[currentColor];
    }

    public void ChangeSettingHaircolorBack()
    {
        int item = colors[colors.Count - 1];
        colors.RemoveAt(colors.Count - 1);
        colors.Insert(0, item);

        int currentColor = colors[0];

        // Debug.Log("BACK: " + colors[0]);

        femaleA7.material.color = haircolor[currentColor];
        femaleBabyBangs.material.color = haircolor[currentColor];
        femaleLongHigh.material.color = haircolor[currentColor];
        femalePonytailBack.material.color = haircolor[currentColor];
        femalePonytailL.material.color = haircolor[currentColor];
        femalePonytailR.material.color = haircolor[currentColor];
        femaleDoubleLow.material.color = haircolor[currentColor];
        femaleMessyHigh.material.color = haircolor[currentColor];
        femaleMessyPonytailBack.material.color = haircolor[currentColor];
        femaleSamuraiBun.material.color = haircolor[currentColor];
        femaleSideBangs.material.color = haircolor[currentColor];
        femaleSideBangsO.material.color = haircolor[currentColor];
        femaleSpaceBun.material.color = haircolor[currentColor];
        femaleStraightShortLow.material.color = haircolor[currentColor];
    }
}