using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

public class IfStatements : MonoBehaviour
{
    public int sum; 
    public int rage;
    public GameObject bulletPrefab;
    public Transform spawnBullet;
    private int count;
    public Message angryMessage = null;
        
    private void Start()
    {

        for (rage = 0; rage < 10; rage++)
        {

            sum = 0;
            if (sum == 10 - 10)
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
    }

    void Fire()
    {
        var bullet = Instantiate(bulletPrefab, spawnBullet.position, spawnBullet.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * 5;
        Destroy(bullet, 2.0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();


        }
    }

  
}
