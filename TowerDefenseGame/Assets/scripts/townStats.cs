using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class townStats : MonoBehaviour {

    public Slider townHealthBar;

    public float townHealth = 1f;
    float currentHealth;

    float damageToTake = 0.5f;

    private void Awake()
    {
        townHealthBar.value = townHealth;
        currentHealth = townHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemyHitTown");

        if (other.gameObject.tag == "enemy")
        {
            townHealthBar.value = currentHealth - damageToTake;
            currentHealth = townHealthBar.value;

            updateHealth();
        }
    }

    void updateHealth()
    {
        townHealthBar.value = currentHealth;
        //Debug.Log("currentHealth.inUpdateHealth = " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("townDied");
        }
    }
}
