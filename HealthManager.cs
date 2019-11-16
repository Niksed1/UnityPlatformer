using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

    //public int currentHealth;
   // public int maxHealth;

    public PlayerMovement thePlayer;

    private bool isRespawning;
    private Vector3 respawnPoint;

    public float respawnLength;

    public int index;

    public float timer;

    // Use this for initialization
    void Start ()
    {
        //  currentHealth = maxHealth;
        respawnLength = 0.2f;

        thePlayer = FindObjectOfType<PlayerMovement>();

        respawnPoint = thePlayer.transform.position; //respawn at the initial point

        index = SceneManager.GetActiveScene().buildIndex;

       // timer = 1f;

        isRespawning = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }

    public void DamagePlayer(int damage, Vector3 direction)
    {
       // currentHealth = currentHealth- damage;

      /*  if (currentHealth <= 0)
        {
            Respawn();
        }
        else
        {
            thePlayer.KnockBack(direction);
        } */
    }

    public void HealPlayer(int heal)
    {
        /*currentHealth += heal;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth; */
    }

    public void Respawn()
    {

        if (!isRespawning) 
        {
            SceneManager.LoadScene(index);
            isRespawning = true;
            //StartCoroutine("RespawnCoroutine");
        }
        
    }

    /*public IEnumerator RespawnCoroutine()
    {
        isRespawning = true;
        thePlayer.gameObject.SetActive(false);

        //wait for the character to die
        yield return null; //new WaitForSeconds(respawnLength);
    
        isRespawning = false;
        thePlayer.gameObject.SetActive(true);

        thePlayer.transform.position = respawnPoint;
    } */
}
