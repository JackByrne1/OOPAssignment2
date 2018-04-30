using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour {

    public float score = 0;

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
	
        if(bulletPrefab.gameObject.name == "Cube")
        {
			score = score + 10;
            Destroy(bulletPrefab.gameObject);
        }

    }
    
	/*public void TakeDamage(float amount)
	{
		health -= amount;

		if (health <= 0f)
		{
			Die ();
		}
	}

	void Die()
	{
		Destroy (gameObject);
	}*/

}
