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
    private static List<int> colors = new List<int> { 0, 1, 2, 3};

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

        int item = colors[0];
        colors.RemoveAt(0);
        colors.Insert(colors.Count, item);

        int currentColor = colors[0];

        // Debug.Log("Forward: " + colors[0]);

        femaleBaseBody.materials[0].color = skincolor[currentColor];
        femaleBaseBody.materials[1].color = skincolor[currentColor];
        femaleBaseBody.materials[2].color = skincolor[currentColor];
        femaleBaseBody.materials[3].color = skincolor[currentColor];
    }

    public void ChangeSettingSkincolorBack()
    {
        int item = colors[colors.Count - 1];
        colors.RemoveAt(colors.Count - 1);
        colors.Insert(0, item);

        int currentColor = colors[0];

        // Debug.Log("BACK: " + colors[0]);
        femaleBaseBody.materials[0].color = skincolor[currentColor];
        femaleBaseBody.materials[1].color = skincolor[currentColor];
        femaleBaseBody.materials[2].color = skincolor[currentColor];
        femaleBaseBody.materials[3].color = skincolor[currentColor];
    }

}
