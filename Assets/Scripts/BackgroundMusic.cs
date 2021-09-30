using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgrroundMusic;

    void Awake()
    {
        if(backgrroundMusic == null)
        {
            backgrroundMusic = this;
            DontDestroyOnLoad(backgrroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }

    }
}
