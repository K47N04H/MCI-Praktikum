using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChangePanel : MonoBehaviour
{
    public GameObject wellcomePage;
    public GameObject selector;
    public GameObject congratsPage;
    public GameObject congratsPageDefault;

    // Welcome Page
    public void whenButtonClicked()
    {
        if (wellcomePage.activeInHierarchy == true)
        {
            wellcomePage.SetActive(false);
            selector.SetActive(true);
        }
    }

    // Welcome Page
    public void whenDefaultButtonClicked()
    {
        if (wellcomePage.activeInHierarchy == true)
        {
            wellcomePage.SetActive(false);
            congratsPageDefault.SetActive(true);
        }
    }

    // Selector
    public void whenSelecotrBackButtonClicked()
    {
        if (selector.activeInHierarchy == true)
        {
            selector.SetActive(false);
            wellcomePage.SetActive(true);
        }
    }

    // Selector
    public void whenSelectorReadyButtonClicked()
    {
        if (selector.activeInHierarchy == true)
        {
            selector.SetActive(false);
            congratsPage.SetActive(true);
        }
    }

    // Congrats Page
    public void whenCongratsBackButtonClicked()
    {
        if (congratsPage.activeInHierarchy == true)
        {
            congratsPage.SetActive(false);
            selector.SetActive(true);
        }
    }

    // Congrats Page Default
    public void whenCongratsDefaultBackButtonClicked()
    {
        if (congratsPageDefault.activeInHierarchy == true)
        {
            congratsPageDefault.SetActive(false);
            wellcomePage.SetActive(true);
        }
    }
}
