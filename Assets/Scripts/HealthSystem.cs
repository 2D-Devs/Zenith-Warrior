using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class HealthSystem : MonoBehaviour
{
    public event EventHandler OnHealthChanged;
    private static HealthSystem hm;
    private int healthMax;
    public int health;

    public Transform spawnPoint;

    public void RespawnPlayer()
    {

        transform.position = spawnPoint.position;
        gameObject.SetActive(true);
    }






    private static int _remainingLives = 3;

    public static int RemainingLives
    {
        get { return _remainingLives; }
    }



    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;



        if (hm == null)
        {
            hm = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
            UnityEngine.Debug.Log("TODO: Add Spawn Particles");

        }
    }

    public int GetHealth()
    {
        return health;
    }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {

            gameObject.SetActive(false);
            SceneManager.LoadScene(1);

        }


        ///This was an attempt to allow a set amount of deaths and respawns but for some reason, 
        ///the enemies wont attack after respawn. The workaround was loading the scene again after
        ///death.
/*
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            hm.RespawnPlayer();
            health = healthMax;
            SceneManager.LoadScene(1);

        }*/



 /*       _remainingLives -= 1;


        if (_remainingLives <= 0)
        {
            EndGame();
        }

        UnityEngine.Debug.Log("Dead");*/

        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }



    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax) health = healthMax;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }



/*    public void EndGame()
    {
        UnityEngine.Debug.Log("GAME OVER");

    }*/



}

