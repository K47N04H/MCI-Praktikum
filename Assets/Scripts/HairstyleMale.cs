using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HairstyleMale : MonoBehaviour
{
    public TMPro.TMP_Text textCategorie;
    public GameObject maleHalfUp;
    public GameObject maleSamuraiBun;
    public GameObject maleShortBlowback;
    public GameObject maleSpaceBun;
    public GameObject maleUndercut;

    private int numberHairstyle = 0;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Eyecolor";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Haircolor";
    }

    public void ChangeSettingHairstyleForward()
    {
        if (numberHairstyle == 0)
        {
            maleHalfUp.SetActive(false);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 1)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(true);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 2)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(true);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(true);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 3)
        {
            maleHalfUp.SetActive(false);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(true);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 4)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(true);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 5)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(true);
            maleShortBlowback.SetActive(true);
            maleSpaceBun.SetActive(true);
            maleUndercut.SetActive(true);

            numberHairstyle = 0;
        }

    }

    public void ChangeSettingHairstyleBack()
    {
        if (numberHairstyle == 0)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(true);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 1)
        {
            maleHalfUp.SetActive(false);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(true);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 2)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(true);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(true);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 3)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(true);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 4)
        {
            maleHalfUp.SetActive(false);
            maleSamuraiBun.SetActive(false);
            maleShortBlowback.SetActive(false);
            maleSpaceBun.SetActive(false);
            maleUndercut.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 5)
        {
            maleHalfUp.SetActive(true);
            maleSamuraiBun.SetActive(true);
            maleShortBlowback.SetActive(true);
            maleSpaceBun.SetActive(true);
            maleUndercut.SetActive(true);

            numberHairstyle = 0;
        }
    }

}
