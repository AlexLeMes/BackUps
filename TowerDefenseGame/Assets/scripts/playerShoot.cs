using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour {

    public GameObject projectile;
    GameObject spawnedProjectile;

    float destoryTime = 5f;

    public float projectileDamage = 15f;

    Rigidbody projectileRb;

    public float projectileForce = 25f;

	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnedProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
            projectileRb = spawnedProjectile.GetComponent<Rigidbody>();
            projectileRb.AddForce(transform.forward * projectileForce);

            Destroy(spawnedProjectile, destoryTime);
        }
	}
}
