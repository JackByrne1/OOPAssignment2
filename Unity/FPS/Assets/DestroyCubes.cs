using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyCubes : MonoBehaviour {
    

    private void OnCollisionEnter(Collision bulletPrefab)
    {

        if (bulletPrefab.gameObject.name == "Cube")
        {
            Destroy(bulletPrefab.gameObject);
    
        }

    }

}
