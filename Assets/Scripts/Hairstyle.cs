using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hairstyle : MonoBehaviour
{
    public TMPro.TMP_Text textCategorie;
    public GameObject femaleA7;
    public GameObject femaleBabyBangs;
    public GameObject femaleLongHigh;
    public GameObject femalePonytailBack;
    public GameObject femalePonytailL;
    public GameObject femalePonytailR;
    public GameObject femaleDoubleLow;
    public GameObject femaleMessyHigh;
    public GameObject femaleMessyPonytailBack;
    public GameObject femaleSamuraiBun;
    public GameObject femaleSideBangs;
    public GameObject femaleSideBangsO;
    public GameObject femaleSpaceBun;
    public GameObject femaleStraightShortLow;
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
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(false);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(false);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 1)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(true);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 2)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(true);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(true);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(true);

            numberHairstyle += 1;
        }


        else if (numberHairstyle == 3)
        {
            femaleA7.SetActive(true);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(false);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 4)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(true);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 5)
        {
            femaleA7.SetActive(true);
            femaleBabyBangs.SetActive(true);
            femaleLongHigh.SetActive(true);
            femalePonytailBack.SetActive(true);
            femalePonytailL.SetActive(true);
            femalePonytailR.SetActive(true);
            femaleDoubleLow.SetActive(true);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(true);
            femaleSamuraiBun.SetActive(true);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(true);
            femaleStraightShortLow.SetActive(true);

            numberHairstyle = 0;
        }
    }

    public void ChangeSettingHairstyleBack()
    {
        if (numberHairstyle == 0)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(true);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 1)
        {
            femaleA7.SetActive(true);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(false);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 2)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(true);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(true);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(true);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 3)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(true);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 4)
        {
            femaleA7.SetActive(false);
            femaleBabyBangs.SetActive(false);
            femaleLongHigh.SetActive(false);
            femalePonytailBack.SetActive(false);
            femalePonytailL.SetActive(false);
            femalePonytailR.SetActive(false);
            femaleDoubleLow.SetActive(false);
            femaleMessyHigh.SetActive(false);
            femaleMessyPonytailBack.SetActive(false);
            femaleSamuraiBun.SetActive(false);
            femaleSideBangs.SetActive(false);
            femaleSideBangsO.SetActive(false);
            femaleSpaceBun.SetActive(false);
            femaleStraightShortLow.SetActive(false);

            numberHairstyle += 1;
        }

        else if (numberHairstyle == 5)
        {
            femaleA7.SetActive(true);
            femaleBabyBangs.SetActive(true);
            femaleLongHigh.SetActive(true);
            femalePonytailBack.SetActive(true);
            femalePonytailL.SetActive(true);
            femalePonytailR.SetActive(true);
            femaleDoubleLow.SetActive(true);
            femaleMessyHigh.SetActive(true);
            femaleMessyPonytailBack.SetActive(true);
            femaleSamuraiBun.SetActive(true);
            femaleSideBangs.SetActive(true);
            femaleSideBangsO.SetActive(true);
            femaleSpaceBun.SetActive(true);
            femaleStraightShortLow.SetActive(true);

            numberHairstyle = 0;
        }
    }

}
