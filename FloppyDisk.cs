using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloppyDisk : MonoBehaviour {

    public int pointsToAdd;

    void OnTriggerEnter2D (Collider2D other)
    {


        if (other.GetComponent<PlayerController>() == null)
            return;
        other.GetComponent<AudioSource>().Play();

        ScoreManager.AddPoints(pointsToAdd);

        Destroy(gameObject);
    }
}
