using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skincolor : MonoBehaviour
{
    Color[] skincolor =
    {
        new Color(0.2924528f, 0.05086612f, 0.03448736f, 1f),
        new Color(0.1509434f, 0.04593461f, 0.03915985f, 1f),
        new Color(0.8207547f, 0.723691f, 0.7162246f, 1),
        new Color(0.08490568f, 0.0557001f, 0.0532663f, 1f)
     };

    public Renderer femaleBaseBody;
    private int numberSkincolor = 0;

    public void ChangeSettingSkincolorForward()
    {
        femaleBaseBody.materials[0].color = skincolor[numberSkincolor];
        femaleBaseBody.materials[1].color = skincolor[numberSkincolor];
        femaleBaseBody.materials[2].color = skincolor[numberSkincolor];
        femaleBaseBody.materials[3].color = skincolor[numberSkincolor];
        if (numberSkincolor == skincolor.Length)
        {
            numberSkincolor -= 1;
        }
        else
        {
            numberSkincolor += 1;
        }
    }
}
