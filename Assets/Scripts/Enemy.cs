using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathVFX;
    [SerializeField] GameObject hitVFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScorePerHit=15;

    [SerializeField] int hitPoints = 20;

    ScoreBoard scoreBoard;

    private void Start() {
        //Look through all GameObjects in the scene and find the one that has the ScoreBoard script attached.
       scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    
    private void OnParticleCollision(GameObject other)
    {
        enemyHit();
        if(hitPoints < 1)
        {
        EnemyKilled();    
        }
    }

    private void enemyHit()
    {
        //Create VFX for hit effect
        GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parent; //putting the vfx in the parent object to keep the hierarchy clean
        //Decrease enemy health
        hitPoints--;
         //Increase Score when enemy is hit;
        scoreBoard.IncreaseScore(ScorePerHit);
    }

    private void EnemyKilled()
    {
        GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity); //Quaternion.identiy menas we dont need rotation
        vfx.transform.parent = parent; //putting the vfx in the parent object to keep the hierarchy clean
        Destroy(gameObject);
    }
}
