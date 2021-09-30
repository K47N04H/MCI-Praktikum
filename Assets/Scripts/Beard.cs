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
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Eyecolor";
    }

    public void ChangeCategoryTextBack()
    {
        textCategorie.GetComponent<TMPro.TMP_Text>().text = "Haircolor";
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
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }


        else if (numberBeardstyle == 3)
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

        else if (numberBeardstyle == 4)
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

        else if (numberBeardstyle == 5)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);
     
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
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle += 1;
        }

        else if (numberBeardstyle == 3)
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

        else if (numberBeardstyle == 4)
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

        else if (numberBeardstyle == 5)
        {
            anchorGoat.SetActive(false);
            anchorSparse.SetActive(false);
            chinCurtainStubble.SetActive(false);
            chinCurtainThick.SetActive(false);
            mustacheChevron.SetActive(false);
            mustachePencil.SetActive(false);
            sideburnsSparse.SetActive(false);
            sideburnsStubble.SetActive(false);


            numberBeardstyle = 0;
        }
    }

}
