using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyStats : MonoBehaviour {

    //public endTown townScript;

    public playerShoot projectileInfo;

    public followWaypoints enemyWaypoint;

    float moveSpeed;
    float maxSpeed = 2f;
    float minSpeed = 0.5f;

    public Slider healthBar;
    const float maxHealth = 1f;
    float currentHealth;

    float damageTaken;

    public GameObject deathParticles;

    public void Awake()
    {
        enemyWaypoint = gameObject.GetComponent<followWaypoints>();
        projectileInfo = GameObject.Find("_fireingPoint").GetComponent<playerShoot>();
    }

    void Start ()
    {
        moveSpeed = Random.Range(minSpeed, maxSpeed);
        Debug.Log("moveSpeed = " + moveSpeed);
        enemyWaypoint.speed = moveSpeed;
        //healthBar = gameObject.GetComponent<Slider>();
        healthBar.value = maxHealth;
        currentHealth = maxHealth;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            damageTaken = projectileInfo.projectileDamage;
            healthBar.value = currentHealth - damageTaken;
            currentHealth = healthBar.value;
            updateHealth();
        }
    }

    void updateHealth()
    {
        healthBar.value = currentHealth;

        if(currentHealth <= 0)
        {
            die();
        }
    }

    void die()
    {
        Instantiate(deathParticles, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
