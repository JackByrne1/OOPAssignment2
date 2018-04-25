using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyCubes : MonoBehaviour {

    private int count;

    public Text countText;

    private void Start()
    {
        count = 0;
        countText.text = "Count: " + count.ToString();

    }

    private void OnCollisionEnter(Collision bulletPrefab)
    {

        if (bulletPrefab.gameObject.name == "Cube")
        {
            Destroy(bulletPrefab.gameObject);
            count = count + 1;
            countText.text = "Count: " + count.ToString();

        }

    }

}
