using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    private static backgroundMusic backgroundMusic1;
    void Awake()
    {
        if(backgroundMusic1 == null)
        {
            backgroundMusic1 = this;
            DontDestroyOnLoad(backgroundMusic1);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
