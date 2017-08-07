using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour {

    public Transform target;

    public GameObject bullet;

    public float fireRate = 2f;

    GameObject bulletFired;

    public turretBullet bulletScript;

    public void shootTarget()
    {
        bulletFired = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletScript = bulletFired.GetComponent<turretBullet>();

        bulletScript.seekTarget(target);

        if(target != null)
        {
            Invoke("shootTarget", fireRate);
        }
    }
    
}
