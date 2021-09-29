using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bodytype : MonoBehaviour
{
    public GameObject femaleFit;
    public GameObject femaleSlim;
    public GameObject femaleChubby;

    private int numberBodytype = 0;

    public void ChangeBodytypeForward()
    {
        if (numberBodytype == 0)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(true);
            femaleChubby.SetActive(false);

            numberBodytype += 1;
        }

        else if (numberBodytype == 1)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(true);

            numberBodytype += 1;
        }

        else if (numberBodytype == 2)
        {
            femaleFit.SetActive(true);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);

            numberBodytype = 0;
        }

    }

    public void ChangeBodytypeBack()
    {
        if (numberBodytype == 0)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(true);

            numberBodytype += 1;
        }

        else if (numberBodytype == 1)
        {
            femaleFit.SetActive(false);
            femaleSlim.SetActive(true);
            femaleChubby.SetActive(false);

            numberBodytype += 1;
        }

        else if (numberBodytype == 2)
        {
            femaleFit.SetActive(true);
            femaleSlim.SetActive(false);
            femaleChubby.SetActive(false);

            numberBodytype = 0;
        }

    }

}