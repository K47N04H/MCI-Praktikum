using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Beard : MonoBehaviour

{
    public TMPro.TMP_Text textCategorie;
    public GameObject anchorGoat;
    public GameObject anchorSparse;
    public GameObject chinCurtainStubble;
    public GameObject chinCurtainThick;
    public GameObject mustacheChevron;
    public GameObject mustachePencil;
    public GameObject sideburnsSparse;
    public GameObject sideburnsStubble;

    private int numberBeardstyle = 0;

    public void ChangeCategoryTextForward()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Clothes Top";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Eyecolor";
    }

    public void ChangeSettingBeardstyleForward()
    {
        if (numberBeardstyle == 0)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 1)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(true);
            sideburnsStubble.SetActive(true);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 2)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }


        else if (numberBeardstyle == 3)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(true);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 4)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(true);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 5)
        {
            anchorGoat.SetActive(true);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);
     
            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 6)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);

            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 7)
        {
            anchorGoat.SetActive(true);
            anchorSparse.SetActive(true);
            chinCurtainStubble.SetActive(true);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(true);
            sideburnsSparse.SetActive(true);
            sideburnsStubble.SetActive(true);

            numberBeardstyle = 0;
        }
    }

    public void ChangeSettingBeardstyleBack()
    {
        if (numberBeardstyle == 0)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);

            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 1)
        {
            anchorGoat.SetActive(true);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);

            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 2)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(true);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 3)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(true);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 4)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 5)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(true);
            sideburnsStubble.SetActive(true);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 6)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 7)
        {
            anchorGoat.SetActive(true);
            anchorSparse.SetActive(true);
            chinCurtainStubble.SetActive(true);
            chinCurtainThick.SetActive(true);
            mustacheChevron.SetActive(true);
            mustachePencil.SetActive(true);
            sideburnsSparse.SetActive(true);
            sideburnsStubble.SetActive(true);

            numberBeardstyle = 0;
        }
    }

}
