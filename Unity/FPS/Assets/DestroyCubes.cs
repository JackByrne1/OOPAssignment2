using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyCubes : MonoBehaviour {

    public int count = 0;
    public Text countText;

   
    private void OnCollisionEnter(Collision bulletPrefab)
    {

        if (bulletPrefab.gameObject.name == "Cube")
        {
            
            Destroy(bulletPrefab.gameObject);
            count= count+ 1;
            SetCountText();

        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

    }

}
