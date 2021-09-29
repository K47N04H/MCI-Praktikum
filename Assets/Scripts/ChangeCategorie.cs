using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeCategorie : MonoBehaviour
{
    string[] categories = {"Gender","Bodytype","Age", "Skincolor","Hairstyle","Haircolor","Eyestyle","Beard","Clothes top color","Clothes bottom color","Shoes"};
    public TMPro.TMP_Text textCategorie;
    private int numberCategory = 0;



    // Change categorie forward while clicking the right button
    public void ChangeCategorieForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[numberCategory];
        if(numberCategory <= categories.Length)
        {
            numberCategory += 1;
        }     
}

    // Change categorie back while clicking the left button
    public void ChangeCategorieBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[numberCategory];
        if(numberCategory >= 0)
        {
            numberCategory -= 1;
        }

    }
}
