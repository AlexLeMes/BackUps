using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretTarget : MonoBehaviour {

    public turret turretScript;

    public Transform target;

    int numOfenemies;

    public Vector3[] enemyTransforms;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "enemy")
        {
            enemyTransforms = new Vector3[other.gameObject.transform.position];
        }

        /*
        if(other.gameObject.tag == "enemy")
        {
            target = other.gameObject.transform;

            turretScript.target = target;

            turretScript.shootTarget();
        }
        */
    }
}
