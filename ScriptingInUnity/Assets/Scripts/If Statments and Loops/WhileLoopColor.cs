using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopColor : MonoBehaviour
{
    private Color colorNow;
     
    void Start()
    {
        int i = 0;
        while (i < 40)
        {
            colorNow = new Color(i * Random.value, Random.value, Random.value);

            
            i++;
        }

    }
    
}
