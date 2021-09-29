using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skincolor : MonoBehaviour
{
    Color[] skincolor =
    {
        new Color(1f, 1f, 1f, 1f),
        new Color(0.5764706f, 0.3647059f, 0.2156863f, 1f),
        new Color(0.4823529f, 0.2941177f, 0.1647059f, 1),
        new Color(0.282353f, 0.2156863f, 0.1568628f, 1f)
     };

    public TMPro.TMP_Text textCategorie;
    public Renderer femaleBaseBody;
    private int numberSkincolor = 0;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Haircolor";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Age";
    }

    public void ChangeSettingSkincolorForward()
    {
        if (numberSkincolor == 0)
        {
            femaleBaseBody.materials[0].color = skincolor[1];
            femaleBaseBody.materials[1].color = skincolor[1];
            femaleBaseBody.materials[2].color = skincolor[1];
            femaleBaseBody.materials[3].color = skincolor[1];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 1)
        {
            femaleBaseBody.materials[0].color = skincolor[2];
            femaleBaseBody.materials[1].color = skincolor[2];
            femaleBaseBody.materials[2].color = skincolor[2];
            femaleBaseBody.materials[3].color = skincolor[2];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 2)
        {
            femaleBaseBody.materials[0].color = skincolor[3];
            femaleBaseBody.materials[1].color = skincolor[3];
            femaleBaseBody.materials[2].color = skincolor[3];
            femaleBaseBody.materials[3].color = skincolor[3];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 3)
        {
            femaleBaseBody.materials[0].color = skincolor[0];
            femaleBaseBody.materials[1].color = skincolor[0];
            femaleBaseBody.materials[2].color = skincolor[0];
            femaleBaseBody.materials[3].color = skincolor[0];
            numberSkincolor = 0;
        }
    }

    public void ChangeSettingSkincolorBack()
    {
        if (numberSkincolor == 0)
        {
            femaleBaseBody.materials[0].color = skincolor[3];
            femaleBaseBody.materials[1].color = skincolor[3];
            femaleBaseBody.materials[2].color = skincolor[3];
            femaleBaseBody.materials[3].color = skincolor[3];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 1)
        {
            femaleBaseBody.materials[0].color = skincolor[2];
            femaleBaseBody.materials[1].color = skincolor[2];
            femaleBaseBody.materials[2].color = skincolor[2];
            femaleBaseBody.materials[3].color = skincolor[2];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 2)
        {
            femaleBaseBody.materials[0].color = skincolor[1];
            femaleBaseBody.materials[1].color = skincolor[1];
            femaleBaseBody.materials[2].color = skincolor[1];
            femaleBaseBody.materials[3].color = skincolor[1];
            numberSkincolor += 1;
        }

        else if (numberSkincolor == 3)
        {
            femaleBaseBody.materials[0].color = skincolor[0];
            femaleBaseBody.materials[1].color = skincolor[0];
            femaleBaseBody.materials[2].color = skincolor[0];
            femaleBaseBody.materials[3].color = skincolor[0];
            numberSkincolor = 0;
        }
    }

}
