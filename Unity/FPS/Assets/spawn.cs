using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    // Use this for initialization
    public Transform prefab;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(prefab, new Vector3(i * 3.0F, 0, i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
