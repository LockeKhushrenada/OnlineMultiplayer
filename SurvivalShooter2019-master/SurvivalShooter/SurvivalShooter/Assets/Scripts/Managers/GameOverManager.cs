using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;

public class GameOverManager : NetworkBehaviour
{
    public PlayerHealth playerHealth;
    public PlayerHealth[] playerHealths;
	public float restartDelay = 5f;


    Animator anim;
	float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(playerHealth = null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
            playerHealths = FindObjectsOfType<PlayerHealth>();
            if (playerHealth.currentHealth <= 0)
            {
                if(playerHealths.Length <=0)
                {
                    anim.SetTrigger("GameOver");

                    restartTimer += Time.deltaTime;

                    if (restartTimer >= restartDelay)
                    {
                        SceneManager.LoadScene(0);
                    }
                }
                
            }
        }
        
    }
}
