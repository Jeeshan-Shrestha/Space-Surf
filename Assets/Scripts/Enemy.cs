using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathVFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScorePerHit=15;

    ScoreBoard scoreBoard;

    private void Start() {
        //Look through all GameObjects in the scene and find the one that has the ScoreBoard script attached.
       scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    
    private void OnParticleCollision(GameObject other)
    {
        EnemyKilled();
        //Increase Score when enemy is killed;
        scoreBoard.IncreaseScore(ScorePerHit);

    }

    private void EnemyKilled()
    {
        GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity); //Quaternion.identiy menas we dont need rotation
        vfx.transform.parent = parent; //putting the vfx in the parent object to keep the hierarchy clean
        Destroy(gameObject);
    }
}
