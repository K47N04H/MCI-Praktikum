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
        if (numberCategory == 0)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[0];
            numberCategory += 1;
        }

        else if (numberCategory == 1)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[1];
            numberCategory += 1;
        }

        else if (numberCategory == 2)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[2];
            numberCategory += 1;
        }

        else if (numberCategory == 3)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[3];
            numberCategory += 1;
        }

        else if (numberCategory == 4)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[4];
            numberCategory += 1;
        }

        else if (numberCategory == 5)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[5];
            numberCategory += 1;
        }

        else if (numberCategory == 6)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[6];
            numberCategory += 1;
        }

        else if (numberCategory == 7)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[7];
            numberCategory += 1;
        }

        else if (numberCategory == 8)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[8];
            numberCategory += 1;
        }

        else if (numberCategory == 9)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[9];
            numberCategory += 1;
        }

        else if (numberCategory == 10)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[10];
            numberCategory += 1;
        }

    }

    public void ChangeCategorieBack()
    {
        if (numberCategory == 0)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[0];
            numberCategory -= 1;
        }

        else if (numberCategory == 1)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[1];
            numberCategory -= 1;
        }

        else if (numberCategory == 2)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[2];
            numberCategory -= 1;
        }

        else if (numberCategory == 3)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[3];
            numberCategory -= 1;
        }

        else if (numberCategory == 4)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[4];
            numberCategory -= 1;
        }

        else if (numberCategory == 5)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[5];
            numberCategory -= 1;
        }

        else if (numberCategory == 6)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[6];
            numberCategory -= 1;
        }

        else if (numberCategory == 7)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[7];
            numberCategory -= 1;
        }

        else if (numberCategory == 8)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[8];
            numberCategory -= 1;
        }

        else if (numberCategory == 9)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[9];
            numberCategory -= 1;
        }

        else if (numberCategory == 10)
        {
            textCategorie.GetComponent<TMPro.TMP_Text>().text = categories[10];
            numberCategory -= 1;
        }
    }
}
