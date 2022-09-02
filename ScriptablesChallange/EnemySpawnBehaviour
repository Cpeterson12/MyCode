using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//all code in this file is based off of the youtube video, "how to make an enemy spawner with scriptable objects?!" by Droei.
public class EnemySpawnBehaviour : MonoBehaviour
{

    public SpawnData[] ESSO;

    public float betweenDelayMain = 3;
    public float betweenWaveDelay;
//ESSO is referring to our scriptable object.  we are calling for the current ESSO, meaning the scriptable in use.
    private int currentESSO = 0;
    private int spawned = 0;
    private float spawnDelayMain = 0;
    private float spawnDelay = 0;
   
    void Start()
    {
        betweenWaveDelay = betweenDelayMain;
        //sets the wave delay to the main delay. THIs is for if you are planning on having multiple waves.
        spawnDelayMain = ESSO[currentESSO].spawnDelay;
        //sets a spawn delay between enemies during a wave
    }

    
    void Update()
    {
        betweenWaveDelay -= Time.deltaTime;
        //keeps the timers running at the same speed as the computer

        if (betweenWaveDelay <= 0)
        {
            spawnDelay -= Time.deltaTime;
             //says that if the timer is at zero and the amount of spawned units is less then the scriptable object,
             //then it is time to create more objects at a zeroed point until that spawn amount is hit.
            if (spawnDelay <= 0 && spawned < ESSO[currentESSO].spawnAmount)
            {
                Instantiate(ESSO[currentESSO].enemy, transform.position, Quaternion.identity);

                spawned++;

                spawnDelay = spawnDelayMain;
            }
        }
        
        
    }
}
