using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideObjects : MonoBehaviour
{
    public GameObject pageToShowHide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void whenButtonIsClicked()
    {
        if (pageToShowHide.activeInHierarchy == true)
            pageToShowHide.SetActive(false);
        else
            pageToShowHide.SetActive(true);
    }
}