using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForLoop : MonoBehaviour
{

    public GameObject box;

    void Start()
    {
        for (var i = 0; i < 10; i ++)
        {
            Instantiate(box, new Vector3(i * 2.0F, 2.0F, 2.0F), new Quaternion(0, 0, 0, 0));
        }
            
    }
    
}
