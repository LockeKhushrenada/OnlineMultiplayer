using UnityEngine;
using Mirror;

public class EnemyManager : NetworkBehaviour
{
    public PlayerHealth playerHealth;
    [SyncVar]
    public GameObject enemy;
    [SyncVar]
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Update ()
    {
        if (playerHealth == null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }

        
    }

 
    void Spawn ()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
