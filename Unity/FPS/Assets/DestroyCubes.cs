using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour {

    public float health = 50f;

    private void OnCollisionEnter(Collision bulletPrefab)
    {
        /*   if(bulletPrefab.gameObject.name == "Crate001")
           {
               if (health < 0)
               {
                   Destroy(bulletPrefab.gameObject);
               }
               else
               {
                   health = health - 10f;
               }

           }*/
        if (bulletPrefab.gameObject.name == "Cube")
        {
            Destroy(bulletPrefab.gameObject);
        }

    }

}
