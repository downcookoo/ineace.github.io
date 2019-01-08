using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


    public GameObject currentCheckpoint;

    private PlayerController player;

    public GameObject deathPartTan;
    public GameObject deathPartBlack;

    public HealthManager healthManager;

    public float respawnDelay;

	// Use this for initialization
	void Start () {

        player = FindObjectOfType<PlayerController>();

        healthManager = FindObjectOfType<HealthManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathPartBlack, player.transform.position, player.transform.rotation);
        Instantiate(deathPartTan, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ScoreManager.score = ScoreManager.score - 10;
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.knockbackCount = 0;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        healthManager.FullHealth();
        healthManager.isDead = false;
        player.transform.position = currentCheckpoint.transform.position;
        player.GetComponent<Rigidbody2D>().gravityScale = 5f;
    }
}
