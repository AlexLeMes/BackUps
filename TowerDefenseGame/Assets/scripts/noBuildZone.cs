using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noBuildZone : MonoBehaviour {

    public spawnTower towerSpawner;

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "noBuildZone")
        {
            towerSpawner.canSpawnHere = false;
        }
        
        if (other.gameObject.tag == "BuildZone")
        {
            towerSpawner.canSpawnHere = true;
        }
        else
        {
            towerSpawner.canSpawnHere = false;
        }
    }

    /*
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "noBuildZone")
        {
            towerSpawner.canSpawnHere = true;
        }
    }
    */

}
