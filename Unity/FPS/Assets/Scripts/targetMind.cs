using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMind : MonoBehaviour
{

    // Use this for initialization
    Vector3 maxPos;
    Vector3 minPos;
    float temp;
    float tempX;
    float tempZ;
    float tempY;
    Vector3 StartPos;
    Vector3 tempPos;
    public float Tspeed = 1f;


    void Start()
    {
        var randomInt1 = Random.Range(-15, 15);
        var randomInt2 = Random.Range(-10, 10);
        var randomInt3 = Random.Range(1, 5);
        Tspeed = randomInt3;
        tempZ = randomInt1;
        tempX = randomInt2;
        tempY = 1f;
        StartPos = new Vector3(tempX, tempY, tempZ);
        transform.position = StartPos;
        temp = transform.position.x;
        maxPos = transform.position;
        minPos = transform.position;
        maxPos.x = temp + 5;
        minPos.x = temp - 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, maxPos, Tspeed * (1 * Time.deltaTime));

        if (transform.position == maxPos)
        {
            tempPos = maxPos;
            maxPos = minPos;
            minPos = tempPos;
            transform.position = Vector3.MoveTowards(transform.position, maxPos, Tspeed * (5 * Time.deltaTime));
        }
        if (transform.position == minPos)
        {
            tempPos = minPos;
            minPos = maxPos;
            maxPos = tempPos;

            transform.position = Vector3.MoveTowards(transform.position, maxPos, Tspeed * (5 * Time.deltaTime));
        }
    }
}
