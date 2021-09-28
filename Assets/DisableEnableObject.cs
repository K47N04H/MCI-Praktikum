using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableObject : MonoBehaviour
{
    public GameObject categoriesPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void whenButtonClicked() {
        if (categoriesPage.activeInHierarchy == true)
            categoriesPage.SetActive(false);
        else
        {
            categoriesPage.SetActive(true);
        }
    }
    
}
