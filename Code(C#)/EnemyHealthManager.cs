﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {


    public int EnemyHealth;
    public GameObject deathEffect;

    public int pointsOnDeath;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(EnemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
		
	}

    public void giveDamage(int damageToGive)
    {
        EnemyHealth -= damageToGive;
        GetComponent<AudioSource>().Play();
    }
}
