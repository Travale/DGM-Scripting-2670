using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int sum = 0;
    public Rigidbody bullet;
    public int rage = 7;
        
    private void Start()
    {
        if(sum == 10 - 10 )
        {
            switch (rage)
            {
                case 7:
                    print("You threw a chair");
                    break;
                    
                case 5:
                    print("You punched a wall");
                    break;
                    
                case 3: 
                    print("You violently ate a snickers bar");
                    break;
                default:
                    print("You are not angry");
                    break;
                
            }
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Shot1"))
        {
            Rigidbody duplicate;
            duplicate = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            duplicate.velocity = transform.TransformDirection(Vector3.up * 10);

        }
    }

  
}
