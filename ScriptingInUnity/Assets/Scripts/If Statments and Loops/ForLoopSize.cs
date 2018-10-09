using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopSize : MonoBehaviour
{
    
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            transform.localScale += new Vector3(i * 5F, 5F, 5F);

        }
    }

    void Update()
    {
        
    }

}
