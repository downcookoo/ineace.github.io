using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {

    public float speed;

    public PlayerController player;

    //public GameObject enemyDeathEffect;


    public int damageToGive;

    public GameObject impactEffect;


    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if (player.transform.position.x < transform.position.x)
            speed = -speed;
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            //Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);
            //Destroy(other.gameObject);

            HealthManager.HurtPlayer(damageToGive);
        }
        Instantiate(impactEffect, other.transform.position, other.transform.rotation);
        Destroy(gameObject);

    }
}
