using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject weapon01;
    public GameObject weapon02;


    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 50f;
    public float score = 0;

    public Camera fpsCam;
    // public ParticleSystem muzzleFlash;
    // public GameObject impactEffect;


    public GameObject bulletSpawnPoint;
    public GameObject bulletPrefab;

    void Start()
    {
        weapon01.SetActive(true);
        weapon02.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            weapon01.SetActive(true);
            weapon02.SetActive(false);
        }

        if (Input.GetKeyDown("2"))
        {
            weapon01.SetActive(false);
            weapon02.SetActive(true);
        }


        /*  if (Input.GetButtonDown("Fire1"))
          {

              GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);

              bullet.transform.position = bulletSpawnPoint.transform.position;
              bullet.transform.rotation = transform.rotation;

              GetComponent<AudioSource>().Play();
          }*/


        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }


    void Shoot()
    {
        //muzzleFlash.Play(); 

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);

            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
                score = score + 5;
            }

            //  GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(impactGO, 2f);
        }




    }


    // Update is called once per frame
    /*void Update ()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
		
	}*/

}